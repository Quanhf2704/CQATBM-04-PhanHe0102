--KIỂM TRA OLS ĐÃ BẬT CHƯA
SELECT * FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';

--NẾU CHƯA CHẠY CÁC LỆNH SAU
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER USER LBACSYS ACCOUNT UNLOCK;
ALTER USER LBACSYS IDENTIFIED BY 111;
ALTER SESSION SET CONTAINER = XEPDB1;
EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;

--TẠO USERDBA
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
CREATE USER USERDBA IDENTIFIED BY "111";
GRANT CONNECT TO USERDBA;
GRANT DBA TO USERDBA;
GRANT SELECT ANY DICTIONARY TO userdba;
GRANT ALL PRIVILEGES TO userdba;

--------------------------------------------------------------------------------
--YÊU CẦU 1
-- CS1
EXEC USERDBA.drop_user('NV098');
EXEC USERDBA.create_user ('NV098', '"123"');
DROP ROLE NHANVIENCOBAN;
-- Tạo role nhân viên cơ bản
CREATE OR REPLACE PROCEDURE SP_CREATE_AND_GRANT_PERMISSION_TO_NHANVIENCOBAN
AS
    U_ROLE VARCHAR(20);
BEGIN
    U_ROLE := 'NHANVIENCOBAN';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.create_role(''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT, UPDATE(DT)'', ''USERDBA.UV_SEL_NHANVIEN'', ''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT'', ''USERDBA.SINHVIEN'', ''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT'', ''USERDBA.DONVI'', ''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT'', ''USERDBA.HOCPHAN'', ''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT'', ''USERDBA.KHMO'', ''' || U_ROLE || '''); END;';
END;
/
EXEC SP_CREATE_AND_GRANT_PERMISSION_TO_NHANVIENCOBAN;
EXEC USERDBA.grant_role_for_user('NHANVIENCOBAN', 'NV098');
/* TEST
    SET ROLE NHANVIENCOBAN;
    SELECT * FROM USERDBA.UV_SEL_NHANVIEN;
    UPDATE USERDBA.UV_SEL_NHANVIEN SET DT = '0123456789';
    SELECT * FROM USERDBA.DONVI;
    SELECT * FROM USERDBA.HOCPHAN;
    SELECT * FROM USERDBA.SINHVIEN;
    SELECT * FROM USERDBA.KHMO;
*/
-----------------------------------------------------------------
-- CS#2
-- Giảng viên
EXEC USERDBA.drop_user('NV018');
EXEC USERDBA.create_user ('NV018', '"123"');
EXEC USERDBA.drop_role('GIANGVIEN');
EXEC USERDBA.create_role('GIANGVIEN');
-- DROP ROLE GIANGVIEN;
-- GRANT NHANVIENCOBAN TO GIANGVIEN;
EXEC USERDBA.grant_role_for_user('NHANVIENCOBAN', 'GIANGVIEN');
EXEC USERDBA.grant_role_for_user('GIANGVIEN', 'NV018');

EXEC USERDBA.grant_permission_role('SELECT', 'UV_SEL_GIANGVIEN_PHANCONG', 'GIANGVIEN');

-- Quyền cập nhật điểm số
DROP TRIGGER GIANGVIEN_DANGKY_TRIGGER;
CREATE OR REPLACE TRIGGER GIANGVIEN_DANGKY_TRIGGER
BEFORE UPDATE OF DIEMTH, DIEMQT, DIEMCK, DIEMTK ON USERDBA.DANGKY
FOR EACH ROW
WHEN (NEW.MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER'))
BEGIN
    NULL; -- Trigger body, logic can be added here if needed
END GIANGVIEN_DANGKY_TRIGGER;
/
EXEC USERDBA.grant_permission_role('UPDATE(DIEMTH, DIEMQT, DIEMTK, DIEMCK)', 'UV_SEL_GIANGVIEN_DANGKY', 'GIANGVIEN');
EXEC USERDBA.grant_permission_role('SELECT', 'UV_SEL_GIANGVIEN_DANGKY', 'GIANGVIEN');
-------------------------------------------------------------------
-- CS#3 
-- Giáo vụ
EXEC USERDBA.drop_user('NV008');
EXEC USERDBA.create_user ('NV008', '"123"');
drop role GIAOVU;
-- DROP ROLE GIAOVU;
EXEC USERDBA.create_role('GIAOVU');

-- Như một người dùng có vai trò “Nhân viên cơ bản”
GRANT NHANVIENCOBAN TO GIAOVU;
GRANT GIAOVU TO NV008;
--select * from DBA_POLICIES;
-- Xem, Thêm mới hoặc Cập nhật dữ liệu trên các quan hệ SINHVIEN, ĐONVI, HOCPHAN, KHMO
EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE', 'USERDBA.SINHVIEN', 'GIAOVU');
EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE', 'USERDBA.DONVI', 'GIAOVU');
EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE', 'USERDBA.HOCPHAN', 'GIAOVU');
EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE', 'USERDBA.KHMO', 'GIAOVU');

-- Xem dữ liệu trên toàn bộ quan hệ PHANCONG
EXEC USERDBA.grant_permission_role('SELECT', 'USERDBA.PHANCONG', 'GIAOVU');
-- Chỉ được sửa trên các dòng dữ liệu phân công liên quan các học phần do “Văn phòng khoa” phụ trách phân công giảng dạy
CREATE OR REPLACE FUNCTION PC_GIAOVU_FUNCTION (
    object_schema IN VARCHAR2,
    object_name IN VARCHAR2
) RETURN VARCHAR2 AS
BEGIN
    RETURN 'MAHP IN (SELECT DISTINCT HP.MAHP FROM USERDBA.HOCPHAN HP, USERDBA.DONVI DV
                    WHERE HP.MADV = DV.MADV AND DV.TENDV = N''Văn phòng khoa'')';
END;
/

-- Xóa chính sách của GIAOVU
BEGIN
  DBMS_RLS.DROP_POLICY(
    OBJECT_SCHEMA => 'USERDBA',
    OBJECT_NAME   => 'PHANCONG',
    POLICY_NAME   => 'PC_GIAOVU_POLICY'
  );
END;
/
-- Thêm chính sách cho giáo vụ
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'USERDBA',
        object_name     => 'PHANCONG',
        policy_name     => 'PC_GIAOVU_POLICY',
        policy_function => 'PC_GIAOVU_FUNCTION',
        statement_types => 'UPDATE',
        update_check => true
    );
END;
/

EXEC USERDBA.grant_permission_role('UPDATE', 'USERDBA.PHANCONG', 'GIAOVU');
-- Xóa hoặc Thêm mới dữ liệu trên quan hệ DANGKY
CREATE OR REPLACE TRIGGER DANGKY_INSERT_UPDATE
BEFORE INSERT OR DELETE ON USERDBA.DANGKY
FOR EACH ROW
DECLARE
    v_hoc_ky_start DATE;
BEGIN
    SELECT CASE
        WHEN :NEW.HK = 1 THEN TO_DATE('01-01-' || :NEW.NAM, 'DD-MM-YYYY')
        WHEN :NEW.HK = 2 THEN TO_DATE('01-05-' || :NEW.NAM, 'DD-MM-YYYY')
        WHEN :NEW.HK = 3 THEN TO_DATE('01-09-' || :NEW.NAM, 'DD-MM-YYYY')
    END INTO v_hoc_ky_start
    FROM dual;
    
    IF SYSDATE > v_hoc_ky_start + 14 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Không thể thêm hoặc xóa đăng ký học phần sau 14 ngày kể từ ngày bắt đầu học kỳ.');
    END IF;
END;
/

EXEC USERDBA.grant_permission_role('SELECT, INSERT, DELETE', 'USERDBA.DANGKY', 'GIAOVU');
------------------------------------------
---------CS#4
EXEC USERDBA.drop_user('NV002');
EXEC USERDBA.create_user('NV002', '"123"');
EXEC USERDBA.drop_role('TRUONGDONVI');
CREATE OR REPLACE PROCEDURE SP_CREATE_AND_GRANT_PERMISSION_TO_TRUONGDONVI
AS
    U_ROLE VARCHAR(20);
BEGIN
    U_ROLE := 'TRUONGDONVI';
    EXECUTE IMMEDIATE 'BEGIN USERDBA.create_role(''' || U_ROLE || '''); END;';
    EXECUTE IMMEDIATE 'GRANT GIANGVIEN ' || ' TO ' || U_ROLE;
    EXECUTE IMMEDIATE 'BEGIN USERDBA.grant_permission_role(''SELECT, INSERT, DELETE, UPDATE'', ''USERDBA.PHANCONG'', ''' || U_ROLE || '''); END;';
    --EXECUTE IMMEDIATE 'BEGIN grant_permission_role(''SELECT'', ''PHANCONG'', ''' || U_ROLE || '''); END;';
END;
/
EXEC SP_CREATE_AND_GRANT_PERMISSION_TO_TRUONGDONVI;
/
--EXEC drop_role('TRUONGDONVI');
--/
EXEC USERDBA.grant_role_for_user('TRUONGDONVI', 'NV002');
/

CREATE OR REPLACE TRIGGER TDV_INSERT_UV_TDV_MODIFY_PHANCONG
INSTEAD OF INSERT OR UPDATE ON USERDBA.UV_TDV_MODIFY_PHANCONG
FOR EACH ROW
DECLARE
    v_exists INTEGER;
BEGIN
    -- Kiểm tra điều kiện trước khi chèn dữ liệu
    SELECT COUNT(1) INTO v_exists
    FROM USERDBA.HOCPHAN HP, USERDBA.DONVI DV
    WHERE HP.MAHP = :NEW.MAHP AND HP.MADV = DV.MADV AND DV.TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER');

    IF v_exists > 0 THEN
        -- Xử lý trường hợp INSERT
        IF INSERTING THEN
            INSERT INTO USERDBA.PHANCONG (MAGV, MAHP, HK, NAM, MACT)
            VALUES (:NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT);

        -- Xử lý trường hợp UPDATE
        ELSIF UPDATING THEN
            UPDATE USERDBA.PHANCONG
            SET MAGV = :NEW.MAGV,
                MAHP = :NEW.MAHP,
                HK = :NEW.HK,
                NAM = :NEW.NAM,
                MACT = :NEW.MACT
            WHERE MAGV = :OLD.MAGV
              AND MAHP = :OLD.MAHP
              AND HK = :OLD.HK
              AND NAM = :OLD.NAM
              AND MACT = :OLD.MACT;
        END IF;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Vi phạm điều kiện WITH CHECK OPTION');
    END IF;
END;
/
EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE, DELETE', 'UV_TDV_MODIFY_PHANCONG', 'TRUONGDONVI');
EXEC USERDBA.grant_permission_role('SELECT', 'UV_TDV_XEM_PHANCONG_GIANGVIEN_CUA_DONVI', 'TRUONGDONVI');
INSERT INTO USERDBA.PHANCONG VALUES ('NV033', 'HP039', '1', '2024', 'CTTT');
--------------------------------------------------------------
-- CS#5
--- Trưởng khoa
EXEC USERDBA.drop_user('NV001')
EXEC USERDBA.create_user ('NV001', '"123"');
DROP ROLE TRUONGKHOA;
EXEC USERDBA.create_role('TRUONGKHOA');
-- DROP ROLE TRUONGKHOA;
-- GRANT GIANGVIEN TO TRUONGKHOA;

EXEC USERDBA.grant_permission_role('SELECT, INSERT, UPDATE, DELETE', 'USERDBA.NHANSU', 'TRUONGKHOA');

BEGIN
    FOR r IN (SELECT table_name FROM all_tables WHERE owner = 'USERDBA') LOOP
        EXECUTE IMMEDIATE 'GRANT SELECT ON USERDBA.' || r.table_name || ' TO TRUONGKHOA';
    END LOOP;
END;
/
CREATE OR REPLACE FUNCTION PC_FUNCTION_TRUONGKHOA (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    MA VARCHAR2(5);
    V_COUNT NUMBER;
    STRSQL VARCHAR2(2000);
    CURSOR CUR IS (SELECT DISTINCT HP.MAHP FROM USERDBA.HOCPHAN HP, USERDBA.DONVI DV
                    WHERE HP.MADV = DV.MADV
                    AND DV.TENDV = N'Văn phòng khoa');
BEGIN
    SELECT COUNT (*) INTO V_COUNT FROM USERDBA.HOCPHAN HP, USERDBA.DONVI DV
                    WHERE HP.MADV = DV.MADV
                    AND DV.TENDV = N'Văn phòng khoa' AND TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
    IF V_COUNT > 0 THEN 
        BEGIN
        OPEN CUR;
        LOOP
            FETCH CUR INTO MA;
            EXIT WHEN CUR%NOTFOUND;
            IF (STRSQL IS NOT NULL) THEN
                STRSQL := STRSQL ||''',''';
            END IF;
            STRSQL := STRSQL || MA;
        END LOOP;
        RETURN 'MAHP IN ('''||STRSQL||''')';
        EXCEPTION 
            WHEN NO_DATA_FOUND THEN 
                DBMS_OUTPUT.PUT_LINE('CANNOT FIND ANY HOCPHAN');
        END;
    END IF;
    RETURN '';
END;
/
-- Xóa chính sách của TRUONGKHOA
BEGIN
  DBMS_RLS.DROP_POLICY(
    OBJECT_SCHEMA => 'USERDBA',
    OBJECT_NAME   => 'PHANCONG',
    POLICY_NAME   => 'PC_TRUONGKHOA'
  );
END;
/
-- Tạo chính sách cho trưởng khoa
BEGIN
    DBMS_RLS.ADD_POLICY(
    OBJECT_SCHEMA =>'USERDBA',
    OBJECT_NAME=>'PHANCONG',
    POLICY_NAME =>'PC_TRUONGKHOA',
    POLICY_FUNCTION=>'PC_FUNCTION_TRUONGKHOA',
    STATEMENT_TYPES=>'INSERT, DELETE, UPDATE',
    UPDATE_CHECK => TRUE
    );
END;
/


EXEC USERDBA.grant_permission_role('INSERT, DELETE, UPDATE', 'PHANCONG', 'TRUONGKHOA');
EXEC USERDBA.grant_role_for_user('GIANGVIEN', 'TRUONGKHOA');
EXEC USERDBA.grant_role_for_user('TRUONGKHOA', 'NV001');
INSERT INTO USERDBA.HOCPHAN VALUES ('HP039', 'TEST_TK', 5, 55, 5, 55, 'DV001');
INSERT INTO USERDBA.KHMO VALUES ('HP039', 1, 2024, 'CTTT');
INSERT INTO USERDBA.KHMO VALUES ('HP039', 1, 2024, 'CQ');

----------------------------------------------------------
-- CS6
-- sinh viên
EXEC USERDBA.drop_user('SV0001');
EXEC USERDBA.create_user('SV0001', '"123"');
EXEC USERDBA.drop_role('SINHVIEN');
EXEC USERDBA.create_role('SINHVIEN');
EXEC USERDBA.grant_role_for_user('SINHVIEN', 'SV0001');
-- Trên quan hệ SINHVIEN, sinh viên chỉ được xem thông tin của chính mình, được Chỉnh sửa thông tin địa chỉ (ĐCHI) và số điện thoại liên lạc (ĐT) của chính sinh viên.
CREATE OR REPLACE FUNCTION PC_CHECKING_SINHVIEN (p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    v_user VARCHAR2(30);
    v_count INTEGER;
BEGIN
    v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Kiểm tra xem user có trong bảng SINHVIEN hay không
    SELECT COUNT(*)
    INTO v_count
    FROM USERDBA.SINHVIEN
    WHERE MASV = v_user;

    -- Nếu user là sinh viên, áp dụng điều kiện lọc
    IF v_count > 0 THEN
        RETURN 'MASV = ''' || v_user || '''';
    END IF;
    RETURN '';
END PC_CHECKING_SINHVIEN;
/
-- drop
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'SINHVIEN',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_SEE_ONLY_THEM_ON_SINHVIEN' -- Tên chính sách cần xóa
  );
END;
/
--add policy
BEGIN
	dbms_rls.add_policy(	
    	OBJECT_SCHEMA =>'USERDBA',
    	OBJECT_NAME => 'SINHVIEN',
    	POLICY_NAME =>'SINHVIEN_SEE_ONLY_THEM_ON_SINHVIEN',
    	POLICY_FUNCTION=>'PC_CHECKING_SINHVIEN',
    	STATEMENT_TYPES=>'SELECT, UPDATE',
    	UPDATE_CHECK => TRUE
	);
END;
/
-- Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương trình đào tạo mà sinh viên đang theo học.
CREATE OR REPLACE FUNCTION SEC_INFO_KHMO_FUNCTION (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS 
    USER VARCHAR2(100);
    MA_CT VARCHAR2(10);
    V_COUNT NUMBER;
BEGIN
    USER := SYS_CONTEXT('USERENV', 'SESSION_USER');
    SELECT COUNT(*) INTO V_COUNT FROM USERDBA.SINHVIEN WHERE MASV = USER;

    IF V_COUNT > 0 THEN
        SELECT SV.MACT INTO MA_CT
        FROM USERDBA.SINHVIEN SV
        WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER'); 
        RETURN 'MACT = ''' || MA_CT || '''';
    END IF;
    RETURN '';
END;
/
-- DROP POLICY
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'KHMO',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_SEE_ONLY_THEM_ON_KHMO' -- Tên chính sách cần xóa
  );
END;
/
-- ADD POLICY
BEGIN
	dbms_rls.add_policy(	
    	OBJECT_SCHEMA =>'USERDBA',
    	OBJECT_NAME => 'KHMO',
    	POLICY_NAME =>'SINHVIEN_SEE_ONLY_THEM_ON_KHMO',
    	POLICY_FUNCTION=>'SEC_INFO_KHMO_FUNCTION',
    	STATEMENT_TYPES=>'SELECT',
    	UPDATE_CHECK => TRUE
	);
END;
/
--SELECT * FROM DBA_POLICIES;
CREATE OR REPLACE FUNCTION SEC_INFO_HOCPHAN_FUNCTION (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS 
    MA_HP VARCHAR2(10);
    STRSQL VARCHAR2(2000);
    V_COUNT NUMBER;
    CURSOR CUR IS (SELECT DISTINCT HP.MAHP
                    FROM USERDBA.HOCPHAN HP
                    INNER JOIN USERDBA.KHMO ON HP.MAHP = KHMO.MAHP
                    INNER JOIN USERDBA.SINHVIEN SV ON SV.MACT = KHMO.MACT
                    WHERE SV.MASV = SYS_CONTEXT('USERENV', 'SESSION_USER'));
BEGIN
    SELECT COUNT(*) INTO V_COUNT FROM USERDBA.SINHVIEN WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    STRSQL := NULL;
    IF V_COUNT > 0 THEN 
        OPEN CUR; 
        LOOP
        FETCH CUR INTO MA_HP;	
            EXIT WHEN CUR%NOTFOUND;
 
            IF (STRSQL IS NOT NULL) THEN
                STRSQL := STRSQL ||''',''';
            END IF;

            STRSQL := STRSQL || MA_HP;
        END LOOP;
        RETURN 'MAHP IN (''' || STRSQL || ''')';
    END IF;
    RETURN '';
END;
/
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'HOCPHAN',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_SEE_ONLY_THEM_ON_HOCPHAN' -- Tên chính sách cần xóa
  );
END;
/
BEGIN
	dbms_rls.add_policy(	
    	OBJECT_SCHEMA =>'USERDBA',
    	OBJECT_NAME => 'HOCPHAN',
    	POLICY_NAME =>'SINHVIEN_SEE_ONLY_THEM_ON_HOCPHAN',
    	POLICY_FUNCTION=>'SEC_INFO_HOCPHAN_FUNCTION',
    	STATEMENT_TYPES=>'SELECT',
    	UPDATE_CHECK => TRUE
	);
END;
/

CREATE OR REPLACE FUNCTION NO_UPDATE_GRADE (p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    v_user VARCHAR2(30);
    v_count INTEGER;
BEGIN
    v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');

    SELECT COUNT(*)
    INTO v_count
    FROM USERDBA.SINHVIEN
    WHERE MASV = v_user;

    IF v_count > 0 THEN
        RETURN '1=0'; -- Ngăn không cho phép cập nhật nếu là sinh viên
    ELSE
        RETURN NULL; -- Cho phép cập nhật nếu không phải là sinh viên
    END IF;
END no_update_grade;
/
-- policy: sinh viên không được chỉnh sửa cột nào liên quan tới điểm
-- dtbtl bảng sinhvien
-- drop
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'SINHVIEN',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_CANNOT_UPDATE_DTBTL_ON_SINHVIEN' -- Tên chính sách cần xóa
  );
END;
/
-- add
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'USERDBA', -- Tên schema chứa bảng
    object_name     => 'SINHVIEN',     -- Tên bảng chứa điểm
    policy_name     => 'SINHVIEN_CANNOT_UPDATE_DTBTL_ON_SINHVIEN', -- Tên chính sách
    policy_function => 'NO_UPDATE_GRADE',  -- Tên hàm chính sách
    statement_types => 'UPDATE',            -- Áp dụng cho câu lệnh UPDATE
    update_check    => TRUE,               -- Chỉ áp dụng khi cập nhật
    sec_relevant_cols => 'DTBTL'
  );
END;
/
-- các cột điểm trong bảng dangky
-- drop
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'DANGKY',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_CANNOT_UPDATE_DTBTL_ON_DANGKY' -- Tên chính sách cần xóa
  );
END;
/
-- add
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'USERDBA', -- Tên schema chứa bảng
    object_name     => 'DANGKY',     -- Tên bảng chứa điểm
    policy_name     => 'SINHVIEN_CANNOT_UPDATE_DTBTL_ON_DANGKY', -- Tên chính sách
    policy_function => 'NO_UPDATE_GRADE',  -- Tên hàm chính sách
    statement_types => 'UPDATE',            -- Áp dụng cho câu lệnh UPDATE
    update_check    => TRUE,               -- Chỉ áp dụng khi cập nhật
    sec_relevant_cols => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK'
  );
END;
/
CREATE OR REPLACE FUNCTION PC_CHECKING_SINHVIEN (p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    v_user VARCHAR2(30);
    v_count INTEGER;
BEGIN
    v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Kiểm tra xem user có trong bảng SINHVIEN hay không
    SELECT COUNT(*)
    INTO v_count
    FROM USERDBA.SINHVIEN
    WHERE MASV = v_user;

    -- Nếu user là sinh viên, áp dụng điều kiện lọc
    IF v_count > 0 THEN
        RETURN 'MASV = ''' || v_user || '''';
    ELSE
        RETURN '1=1'; -- Cho phép truy cập tất cả dữ liệu nếu không phải là sinh viên
    END IF;
END PC_CHECKING_SINHVIEN;
/
-- policy: sinh viên chỉ xem thông tin của chính họ trên bảng DANGKY
-- DROP
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'DANGKY',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_SEE_ONLY_THEM_ON_DANGKY' -- Tên chính sách cần xóa
  );
END;
/
-- ADD
BEGIN
  DBMS_RLS.ADD_POLICY(
    object_schema   => 'USERDBA', -- Tên schema chứa bảng
    object_name     => 'DANGKY',           -- Tên bảng chứa thông tin đăng ký
    policy_name     => 'SINHVIEN_SEE_ONLY_THEM_ON_DANGKY', -- Tên chính sách
    policy_function => 'PC_CHECKING_SINHVIEN',    -- Tên hàm chính sách
    statement_types => 'SELECT'            -- Áp dụng cho câu lệnh SELECT
  );
END;
/
CREATE OR REPLACE FUNCTION SINHVIEN_HIEU_CHINH_DKHP (
    p_schema VARCHAR2,
    p_obj VARCHAR2
) RETURN VARCHAR2 AS
    START_DATE DATE;
    HOCKI NUMBER;
    NAM NUMBER;
    STRSQL VARCHAR2(1000) := '';
    CURSOR cur IS 
        SELECT DISTINCT HK, NAM 
        FROM USERDBA.KHMO;
       -- WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    OPEN cur;
    LOOP
        FETCH cur INTO HOCKI, NAM;
        EXIT WHEN cur%NOTFOUND;
        
        -- Xác định ngày bắt đầu học kỳ
        IF HOCKI = 1 THEN 
            START_DATE := TO_DATE(NAM || '-01-01', 'YYYY-MM-DD');
        ELSIF HOCKI = 2 THEN 
            START_DATE := TO_DATE(NAM || '-05-01', 'YYYY-MM-DD');
        ELSIF HOCKI = 3 THEN 
            START_DATE := TO_DATE(NAM || '-09-01', 'YYYY-MM-DD');
        END IF;
        
        -- Kiểm tra nếu ngày hiện tại không vượt quá 14 ngày so với ngày bắt đầu học kỳ
        IF (TRUNC(SYSDATE) - 14 <= START_DATE) THEN 
            IF STRSQL IS NOT NULL AND STRSQL != '' THEN 
                STRSQL := STRSQL || ' OR ';
            END IF;
            STRSQL := STRSQL || '(HK = ' || HOCKI || ' AND NAM = ' || NAM || ')';
        END IF;
    END LOOP;
    CLOSE cur;
    
    -- Trả về chuỗi điều kiện SQL
    IF STRSQL IS NULL OR STRSQL = '' THEN
        RETURN '1=0'; -- Không cho phép nếu không có điều kiện nào thỏa mãn
    ELSE
        RETURN STRSQL;
    END IF;
END SINHVIEN_HIEU_CHINH_DKHP;
/
-- policy: sinh viên chỉ được thêm, xóa thông tin đăng kí nếu ngày hiện tại không hơn 14 ngày kể từ ngày bắt đầu học kì
-- drop
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'DANGKY',     -- Tên bảng chứa điểm
    policy_name   => 'SINHVIEN_HIEU_CHINH_DKHP' -- Tên chính sách cần xóa
  );
END;
/
-- add
BEGIN
    DBMS_RLS.ADD_POLICY (
        object_schema   => 'USERDBA',      -- Thay bằng schema của bạn
        object_name     => 'DANGKY',
        policy_name     => 'SINHVIEN_HIEU_CHINH_DKHP',
        policy_function => 'SINHVIEN_HIEU_CHINH_DKHP',
        statement_types => 'INSERT, DELETE',  -- Đảm bảo sử dụng đúng cú pháp
        update_check => TRUE
    );
END;
/
-- policy: sinh viên chỉ được thêm, xóa thông tin đăng kí của mình
-- drop
BEGIN
  DBMS_RLS.DROP_POLICY(
    object_schema => 'USERDBA', -- Tên schema chứa bảng
    object_name   => 'DANGKY',     -- Tên bảng chứa điểm
    policy_name   => 'DIEUKIEN_DKHP_SV' -- Tên chính sách cần xóa
  );
END;
/
-- add
BEGIN
    DBMS_RLS.ADD_POLICY (
        object_schema   => 'USERDBA',      -- Thay bằng schema của bạn
        object_name     => 'DANGKY',
        policy_name     => 'DIEUKIEN_DKHP_SV',
        policy_function => 'PC_CHECKING_SINHVIEN',
        statement_types => 'INSERT, DELETE',  -- Đảm bảo sử dụng đúng cú pháp
        update_check => TRUE
    );
END;
/
GRANT SELECT, INSERT, DELETE ON USERDBA.DANGKY TO SINHVIEN;
GRANT SELECT, UPDATE(DCHI, DT, DTBTL) ON USERDBA.SINHVIEN TO SINHVIEN;
GRANT SELECT ON USERDBA.HOCPHAN TO SINHVIEN;
GRANT SELECT ON USERDBA.KHMO TO SINHVIEN;
--SELECT MAHP FROM USERDBA.KHMO WHERE MACT = 'CTTT';
--SELECT * FROM DBA_POLICIES;
/* test
    SELECT * FROM USERDBA.SINHVIEN;
    UPDATE USERDBA.SINHVIEN SET DTBTL = '10' WHERE MASV =  'SV001';
    SELECT * FROM USERDBA.DANGKY;
    UPDATE USERDBA.DANGKY SET DIEMTH = '10' WHERE MASV = 'SV001';
    INSERT INTO USERDBA.DANGKY VALUES ('SV001', 'NV001', 'HP001', '3', '2024', 'CQ', '8', '9', '10', '7.4');
    DELETE FROM USERDBA.DANGKY WHERE MASV = 'SV001' AND MAGV = 'NV001' AND MAHP = 'HP001' AND HK = '1' AND NAM = '2024';
    DELETE FROM USERDBA.DANGKY WHERE MASV = 'SV001' AND MAGV = 'NV001' AND MAHP = 'HP001' AND HK = '3' AND NAM = '2024';
    INSERT INTO USERDBA.DANGKY VALUES ('SV001', 'NV001', 'HP001', 1, 2024, 'CQ', 8.5, 8.7, 9.0, 8.7)
*/
-- OLS

EXEC USERDBA.create_user('NV004', '"123"');
EXEC USERDBA.grant_role_for_user('TRUONGDONVI', 'NV004');

-- AUDIT
SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Unified Auditing';
SELECT * FROM DBA_AUDIT_TRAIL;
SELECT * FROM DBA_OBJ_AUDIT_OPTS;

-- Chuyển sang Container Database (CDB)
ALTER SESSION SET CONTAINER = CDB$ROOT;
-- Kích hoạt chế độ ghi nhật ký hệ thống
ALTER SYSTEM SET audit_trail = DB, EXTENDED SCOPE = SPFILE;

-- Khởi động lại Oracle để thay đổi có hiệu lực
SHUTDOWN IMMEDIATE;
STARTUP;

ALTER SESSION SET CONTAINER = XEPDB1;

AUDIT SELECT, UPDATE, INSERT ON USERDBA.SINHVIEN BY ACCESS;
AUDIT SELECT ON USERDBA.DONVI BY SESSION;
AUDIT SELECT ON USERDBA.HOCPHAN BY ACCESS;
AUDIT SELECT ON USERDBA.KHMO BY ACCESS;
AUDIT SELECT, UPDATE ON USERDBA.UV_SEL_NHANVIEN BY ACCESS;
AUDIT SELECT, INSERT, UPDATE, DELETE ON USERDBA.DANGKY BY ACCESS;
AUDIT SELECT ON USERDBA.UV_SEL_GIANGVIEN_PHANCONG BY ACCESS;
AUDIT SELECT, UPDATE ON USERDBA.PHANCONG BY ACCESS;
AUDIT SELECT, UPDATE, DELETE ON USERDBA.UV_TDV_MODIFY_PHANCONG BY ACCESS;
AUDIT SELECT ON USERDBA.UV_TDV_XEM_PHANCONG_GIANGVIEN_CUA_DONVI BY ACCESS;
AUDIT SELECT, INSERT, DELETE, UPDATE ON USERDBA.NHANSU BY ACCESS;

SELECT * FROM DBA_AUDIT_TRAIL;
SELECT * FROM DBA_OBJ_AUDIT_OPTS;
select action_name,SQL_TEXT,UNIFIED_AUDIT_POLICIES ,EVENT_TIMESTAMP from unified_AUDIT_trail;
