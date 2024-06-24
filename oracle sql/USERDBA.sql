-------------------------------------------------------------------------------
-- XEM DANH SACH CAC USERS
SELECT username FROM dba_users;

--------------------------------------------------------------------------------
-- XEM DANH SACH CAC ROLES
SELECT role FROM dba_roles;

--------------------------------------------------------------------------------
--- XEM ROLE CUA USER
CREATE OR REPLACE PROCEDURE check_role (
     p_username VARCHAR2,
     sys_rc out SYS_REFCURSOR)
IS 
BEGIN
    OPEN sys_rc FOR
        SELECT GRANTEE AS USERNAME, ROLE 
        FROM DBA_ROLES R
        LEFT JOIN DBA_ROLE_PRIVS RP ON R.ROLE = RP.GRANTED_ROLE
        WHERE GRANTEE = UPPER(p_username);
END;
/

--------------------------------------------------------------------------------
-- XEM QUYEN USER
CREATE OR REPLACE VIEW user_privileges AS (
    SELECT grantee AS username,
           granted_role AS privilege,
           '--' AS owner,
           '--' AS table_name,
           '--' AS column_name,
           admin_option AS admin_option,
           'ROLE' AS access_type
    FROM dba_role_privs RP
    JOIN dba_roles R ON RP.granted_role = R.role
    WHERE grantee IN (SELECT username FROM dba_users)

    UNION ALL

    SELECT grantee AS username,
           privilege AS privilege,
           '--' AS owner,
           '--' AS table_name,
           '--' AS column_name,
           admin_option AS admin_option,
           'SYSTEM' AS access_type
    FROM dba_sys_privs
    WHERE grantee IN (SELECT username FROM dba_users)

    UNION ALL

    SELECT grantee AS username,
           privilege AS privilege,
           owner AS owner,
           table_name AS table_name,
           '--' AS column_name,
           grantable AS grant_option,
           'TABLE' AS access_type
    FROM dba_tab_privs
    WHERE grantee IN (SELECT username FROM dba_users)

    UNION ALL

    SELECT DP.grantee AS username,
           privilege AS privilege,
           owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
           '--' AS admin_option,
           'ROLE' AS access_type
    FROM role_tab_privs RP
    JOIN dba_role_privs DP ON RP.role = DP.granted_role
    WHERE DP.grantee IN (SELECT username FROM dba_users)

    UNION ALL

    SELECT grantee AS username,
           privilege AS privilege,
            owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
           grantable AS grant_option,
           'COLUMN' AS access_type
    FROM dba_col_privs
    WHERE grantee IN (SELECT username FROM dba_users)
);
/
  
CREATE OR REPLACE PROCEDURE check_privilege (
     p_username VARCHAR2,
     sys_rc out SYS_REFCURSOR)
IS 
BEGIN
    OPEN sys_rc FOR
        SELECT *
        FROM user_privileges
        WHERE USERNAME = p_username or USERNAME = UPPER(p_username);
END;
/
VAR rc refcursor;
EXEC check_role('NV001', :rc);
PRINT rc;

--------------------------------------------------------------------------------
-- XEM QUYEN ROLE

CREATE OR REPLACE VIEW role_privileges AS (
    SELECT grantee AS role,
           granted_role AS privilege,
           '--' AS owner,
           '--' AS table_name,
           '--' AS column_name,
           admin_option AS admin_option,
           'ROLE' AS access_type
    FROM dba_role_privs RP
    INNER JOIN dba_roles R ON UPPER(RP.granted_role) = UPPER(R.role)
    WHERE grantee IN (SELECT role FROM dba_roles)

    UNION ALL

    SELECT grantee AS role,
           privilege AS privilege,
           '--' AS owner,
           '--' AS table_name,
           '--' AS column_name,
           admin_option AS admin_option,
           'SYSTEM' AS access_type
    FROM dba_sys_privs
    WHERE grantee IN (SELECT role FROM dba_roles)

    UNION ALL

    SELECT grantee AS role,
           privilege AS privilege,
           owner AS owner,
           table_name AS table_name,
           '--' AS column_name,
           grantable AS grant_option,
           'TABLE' AS access_type
    FROM dba_tab_privs
    WHERE grantee IN (SELECT role FROM dba_roles)

    UNION ALL

    SELECT DP.grantee AS role,
           privilege AS privilege,
           owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
           '--' AS admin_option,
           'ROLE' AS access_type
    FROM role_tab_privs RP
    JOIN dba_role_privs DP ON RP.role = DP.granted_role
    WHERE DP.grantee IN (SELECT role FROM dba_roles)

    UNION ALL

    SELECT grantee AS role,
           privilege AS privilege,
           owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
           grantable AS grant_option,
           'COLUMN' AS access_type
    FROM dba_col_privs
    WHERE grantee IN (SELECT role FROM dba_roles)
);
/

--- XEM QUYEN CUA ROLE
CREATE OR REPLACE PROCEDURE check_privilege_role (
     p_role VARCHAR2,
     sys_rc out SYS_REFCURSOR)
IS 
BEGIN
    OPEN sys_rc FOR
        SELECT *
        FROM role_privileges
        WHERE ROLE = UPPER(p_role);
END;
/

--------------------------------------------------------------------------------
----Tao user----
CREATE OR REPLACE PROCEDURE create_user (
    p_username VARCHAR2,
    p_password VARCHAR2
) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'CREATE  USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_username;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/

--------------------------------------------------------------------------------
----Xoa user----
CREATE OR REPLACE PROCEDURE drop_user (
    p_username VARCHAR2
) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/

--------------------------------------------------------------------------------
----Tao role----
CREATE OR REPLACE PROCEDURE create_role (
    p_rolename VARCHAR2
) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'CREATE  ROLE ' || p_rolename;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/

--------------------------------------------------------------------------------
----Xoa role----
CREATE OR REPLACE PROCEDURE drop_role (
    p_rolename VARCHAR2
) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_rolename;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/

--------------------------------------------------------------------------------
--Only INSERT, UPDATE, and REFERENCES privileges can be granted at the column level.
--When granting INSERT at the column level, you must include all the not null columns in the row.
----Cap quyen cho role
CREATE OR REPLACE PROCEDURE grant_permission_role (
    p_privilege VARCHAR2,
    p_tablename VARCHAR2,
    p_grantee VARCHAR2
  
) IS
BEGIN
    IF (p_tablename = ' ') THEN
        EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' TO ' || p_grantee;
    ELSE
        EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' ON ' || p_tablename || ' TO ' || p_grantee;
    END IF;
END;
/

--------------------------------------------------------------------------------
----Cap quyen cho user
CREATE OR REPLACE PROCEDURE grant_permission_user (
    p_privilege VARCHAR2,
    p_tablename VARCHAR2,
    p_grantee VARCHAR2,
    p_with_grant_option CHAR
) IS
BEGIN
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    IF (p_with_grant_option = '0') THEN
        IF (p_tablename = ' ') THEN
            EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' TO ' || p_grantee;
        ELSE
            EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' ON ' || p_tablename || ' TO ' || p_grantee;
        END IF;
    ELSE
        IF (p_tablename = ' ') THEN
            EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' TO ' || p_grantee || ' WITH GRANT OPTION';
        ELSE
            EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' ON ' || p_tablename || ' TO ' || p_grantee || ' WITH GRANT OPTION';
        END IF;
    END IF;
END;
/

--------------------------------------------------------------------------------
--Oracle does not allow revoking permissions from a specific column.
--You must revoke permissions from the entire table instead of individual columns.
----Thu hoi quyen role/user
CREATE OR REPLACE PROCEDURE revoke_permission (
    p_privilege VARCHAR2,
    p_tablename VARCHAR2,
    p_grantee VARCHAR2
) IS
BEGIN
    IF (p_tablename = ' ') THEN
        EXECUTE IMMEDIATE 'REVOKE ' || p_privilege || ' FROM ' || p_grantee;
    ELSE
        EXECUTE IMMEDIATE 'REVOKE ' || p_privilege || ' ON ' || p_tablename || ' FROM ' || p_grantee;
    END IF;
END;
/

--------------------------------------------------------------------------------
/*
CREATE OR REPLACE PROCEDURE alter_role (
    p_rolename VARCHAR2,
    p_password VARCHAR2
) IS
BEGIN
    IF (p_password = ' ') THEN
        EXECUTE IMMEDIATE 'ALTER ROLE '|| p_rolename|| ' NOT IDENTIFIED';
    ELSE
        EXECUTE IMMEDIATE 'ALTER ROLE '|| p_rolename|| ' IDENTIFIED BY '|| p_password;
    END IF;
END;
/
*/
--------------------------------------------------------------------------------
----chinh sua user----
CREATE OR REPLACE PROCEDURE alter_user (
    p_username VARCHAR2,
    p_newpassword VARCHAR2
) IS
BEGIN
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
        EXECUTE IMMEDIATE 'ALTER USER '|| p_username|| ' IDENTIFIED BY '|| p_newpassword;
END;
/


CREATE OR REPLACE PROCEDURE grant_role_for_user (
    p_role VARCHAR2,
    p_user VARCHAR2
) IS
BEGIN
        EXECUTE IMMEDIATE 'GRANT ' || p_role || ' TO ' || p_user;
END;
/

CREATE OR REPLACE PROCEDURE revoke_role_from_user (
    p_role VARCHAR2,
    p_user VARCHAR2
) IS
BEGIN
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
        EXECUTE IMMEDIATE 'REVOKE ' || p_role || ' FROM ' || p_user;
END;
/
-- CS1
-- Tạo view chỉ xem được bản thân trong bảng NHANSU
CREATE OR REPLACE VIEW UV_SEL_NHANVIEN
AS
    SELECT * 
    FROM USERDBA.NHANSU 
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    WITH CHECK OPTION;
/
-- CS2
-- Quyền xem dữ liệu phân công giảng dạy liên quan đến bản thân
CREATE OR REPLACE VIEW UV_SEL_GIANGVIEN_PHANCONG
AS
    SELECT * 
    FROM USERDBA.PHANCONG
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER')
/
-- Quyền xem dữ liệu trên quan hệ ĐĂNG KÝ liên quan đến các lớp học phần mà giảng viên được phân công giảng dạy
CREATE OR REPLACE VIEW UV_SEL_GIANGVIEN_DANGKY AS
    SELECT * FROM USERDBA.DANGKY
    WHERE MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
-- CS4
CREATE OR REPLACE VIEW UV_TDV_XEM_PHANCONG_GIANGVIEN_CUA_DONVI
AS
    SELECT PC.MAGV, PC.MAHP, PC.HK, PC.NAM, PC.MACT
    FROM USERDBA.PHANCONG PC, USERDBA.NHANSU NS, USERDBA.DONVI DV
    WHERE DV.TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER') AND DV.MADV = NS.MADV AND NS.MANV = PC.MAGV
/
--SELECT * FROM DBA_POLICIES;
CREATE OR REPLACE VIEW UV_TDV_MODIFY_PHANCONG
AS
    SELECT PC.MAGV, PC.MAHP,PC.HK, PC.NAM, PC.MACT
    FROM USERDBA.PHANCONG PC, USERDBA.HOCPHAN HP, USERDBA.DONVI DV
    WHERE PC.MAHP = HP.MAHP AND HP.MADV = DV.MADV AND DV.TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    WITH CHECK OPTION;
/  

--KIỂM TRA VAI TRÒ CỦA USER
DROP FUNCTION CHECKING_USER;
CREATE OR REPLACE FUNCTION CHECKING_USER (
    USER VARCHAR2)
RETURN NUMBER
AS
    VAI_TRO VARCHAR2(50);
    V_COUNT NUMBER;
BEGIN
     SELECT VAITRO INTO VAI_TRO FROM NHANSU WHERE MANV = USER;
        IF VAI_TRO = N'Trưởng khoa' THEN
            RETURN 1;
        ELSIF VAI_TRO = N'Trưởng đơn vị' then
            return 2;
        elsif VAI_TRO = N'Giáo vụ' then
            return 3;
        elsif VAI_TRO = N'Giảng viên' then
            return 4;
        elsif VAI_TRO = N'Nhân viên cơ bản' then 
            return 5;
        END IF;  
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            NULL; -- If no matching role is found, continue to the next check
    SELECT COUNT(*) INTO V_COUNT FROM USERDBA.SINHVIEN WHERE MASV = USER;
        IF V_COUNT > 0 THEN
            RETURN 6;
        END IF;
    RETURN 0;
END;
/
SET SERVEROUTPUT ON;
declare
  x number;
begin
  x := CHECKING_USER('NV100');
  DBMS_OUTPUT.PUT_LINE('User role code: ' || x);
end;

--------------------------------------------------------------------------------
-- TẠO BẢNG THONGBAO
--DROP TABLE THONGBAO CASCADE CONSTRAINTS;
CREATE TABLE THONGBAO (
    ID NUMBER PRIMARY KEY,
    NOIDUNG VARCHAR2(4000),
    CAPBAC VARCHAR2(50),
    LINHVUC VARCHAR2(10),
    COSO VARCHAR2(10)
);
/

INSERT INTO THONGBAO VALUES (1,     'Thông báo từ Trưởng khoa về hội nghị',                 'Trưởng khoa',       null,   null);
INSERT INTO THONGBAO VALUES (2,     'Thông báo từ Trưởng đơn vị về nghiên cứu',             'Trưởng đơn vị',    'CNPM', 'CS2');
INSERT INTO THONGBAO VALUES (3,     'Thông báo từ Giảng viên về lịch học',                  'Giảng viên',       'KHMT', 'CS1');
INSERT INTO THONGBAO VALUES (4,     'Thông báo từ Giáo vụ về quy định mới',                 'Giáo vụ',          'CNTT', 'CS2');
INSERT INTO THONGBAO VALUES (5,     'Thông báo từ Nhân viên về bảo trì',                    'Nhân viên',        'TGMT', 'CS1');
INSERT INTO THONGBAO VALUES (6,     'Thông báo cho Sinh viên về kỳ thi',                    'Sinh viên',        'MMT',  'CS2');
INSERT INTO THONGBAO VALUES (7,     'Thông báo từ Trưởng khoa về định hướng nghiên cứu',    'Trưởng khoa',       null,   null);
INSERT INTO THONGBAO VALUES (8,     'Thông báo từ Trưởng đơn vị về hội thảo',               'Trưởng đơn vị',    'TGMT', 'CS2');
INSERT INTO THONGBAO VALUES (9,     'Thông báo từ Giảng viên về seminar',                   'Giảng viên',       'MMT',  'CS1');
INSERT INTO THONGBAO VALUES (10,    'Thông báo từ Giáo vụ về lịch họp',                     'Giáo vụ',          'HTTT', 'CS2');
INSERT INTO THONGBAO VALUES (11,    'Thông báo từ Nhân viên về bảo dưỡng hệ thống',         'Nhân viên',        'CNPM', 'CS1');
INSERT INTO THONGBAO VALUES (12,    'Thông báo cho Sinh viên về hoạt động ngoại khóa',      'Sinh viên',        'KHMT', 'CS2');
INSERT INTO THONGBAO VALUES (13,    'Thông báo từ Trưởng khoa về chính sách mới',           'Trưởng khoa',       null,   null);
INSERT INTO THONGBAO VALUES (14,    'Thông báo từ Trưởng đơn vị về hợp tác quốc tế',        'Trưởng đơn vị',    'KHMT', 'CS2');
INSERT INTO THONGBAO VALUES (15,    'Thông báo từ Giảng viên về nghiên cứu mới',            'Giảng viên',       'CNTT', 'CS1');
INSERT INTO THONGBAO VALUES (16,    'Thông báo từ Giáo vụ về quy chế thi cử',               'Giáo vụ',          'TGMT', 'CS2');
INSERT INTO THONGBAO VALUES (17,    'Thông báo từ Nhân viên về sự kiện trường',             'Nhân viên',        'MMT',  'CS1');
INSERT INTO THONGBAO VALUES (18,    'Thông báo cho Sinh viên về học bổng',                  'Sinh viên',        'HTTT', 'CS2');
INSERT INTO THONGBAO VALUES (19,    'Thông báo từ Trưởng khoa về kế hoạch đào tạo',         'Trưởng khoa',       null,   null);
INSERT INTO THONGBAO VALUES (20,    'Thông báo từ Trưởng đơn vị về đề tài nghiên cứu',      'Trưởng đơn vị',    'CNPM', 'CS2');
/

--------------------------------------------------------------------------------
--GÁN NHÃN CHO THÀNH PHẦN CỦA BẢNG
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:TRUONG') WHERE CAPBAC = 'Trưởng khoa';

UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:HTTT:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'HTTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:HTTT:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'HTTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:CNPM:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'CNPM' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:CNPM:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'CNPM' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:KHMT:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'KHMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:KHMT:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'KHMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:CNTT:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'CNTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:CNTT:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'CNTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:TGMT:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'TGMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:TGMT:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'TGMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:MMT:CS1') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'MMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:MMT:CS2') WHERE CAPBAC = 'Trưởng đơn vị' AND LINHVUC = 'MMT' AND COSO = 'CS2';

UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:HTTT:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'HTTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:HTTT:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'HTTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:CNPM:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'CNPM' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:CNPM:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'CNPM' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:KHMT:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'KHMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:KHMT:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'KHMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:CNTT:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'CNTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:CNTT:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'CNTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:TGMT:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'TGMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:TGMT:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'TGMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:MMT:CS1') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'MMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GV:MMT:CS2') WHERE CAPBAC = 'Giảng viên' AND LINHVUC = 'MMT' AND COSO = 'CS2';

UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:HTTT:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'HTTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:HTTT:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'HTTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:CNPM:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'CNPM' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:CNPM:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'CNPM' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:KHMT:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'KHMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:KHMT:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'KHMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:CNTT:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'CNTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:CNTT:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'CNTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:TGMT:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'TGMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:TGMT:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'TGMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:MMT:CS1') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'MMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'GVU:MMT:CS2') WHERE CAPBAC = 'Giáo vụ' AND LINHVUC = 'MMT' AND COSO = 'CS2';

UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:HTTT:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'HTTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:HTTT:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'HTTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:CNPM:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'CNPM' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:CNPM:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'CNPM' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:KHMT:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'KHMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:KHMT:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'KHMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:CNTT:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'CNTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:CNTT:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'CNTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:TGMT:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'TGMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:TGMT:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'TGMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:MMT:CS1') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'MMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:MMT:CS2') WHERE CAPBAC = 'Nhân viên' AND LINHVUC = 'MMT' AND COSO = 'CS2';

UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:HTTT:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'HTTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:HTTT:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'HTTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:CNPM:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'CNPM' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:CNPM:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'CNPM' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:KHMT:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'KHMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:KHMT:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'KHMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:CNTT:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'CNTT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:CNTT:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'CNTT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:TGMT:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'TGMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:TGMT:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'TGMT' AND COSO = 'CS2';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:MMT:CS1') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'MMT' AND COSO = 'CS1';
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:MMT:CS2') WHERE CAPBAC = 'Sinh viên' AND LINHVUC = 'MMT' AND COSO = 'CS2';

--CÂU D
INSERT INTO THONGBAO VALUES (21,    't1: Thông báo đến Trưởng đơn vị về đề tài nghiên cứu',      'Trưởng đơn vị',       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV') WHERE ID = 21;

--CÂU E
INSERT INTO THONGBAO VALUES (22,    't2: Thông báo đến sinh viên khoa HTTT CS1 dời lịch học',      'Sinh viên',       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV:HTTT:CS1') WHERE ID = 22;

--CÂU F
INSERT INTO THONGBAO VALUES (23,    't3: Thông báo đến trưởng bộ môn KHMT CS1 họp chuyên ngành',      'Trưởng đơn vị',       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:KHMT:CS1') WHERE ID = 23;

--CÂU G
INSERT INTO THONGBAO VALUES (24,    't4: Thông báo đến trưởng bộ môn KHMT tham dự lễ tốt nghiệp',      'Trưởng đơn vị',       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'TDV:KHMT') WHERE ID = 24;

--CÂU H
--H1: t5: phát tán thông báo đến tất cả user trong database
INSERT INTO THONGBAO VALUES (25,    't5: Thông báo đến toàn trường lịch sửa chữa mạng lưới điện 2 cơ sở.',      null,       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'SV') WHERE ID = 25;
--H2: t6: phát đến đến toàn đội ngũ nhân viên trong trường
INSERT INTO THONGBAO VALUES (26,    't6: Thông báo đến đội ngũ nhân viên kế hoạch giảng dạy năm 2025.',      null,       null, null, null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV') WHERE ID = 26;
--H3: t7: phát tán đến nhân viên của bộ môn công nghệ tri thức 
INSERT INTO THONGBAO VALUES (27,    't7: Thông báo đến đội ngũ nhân viên bộ môn công nghệ tri thức cơ sở 2 thời điêm kết thúc năm học.',      'Nhân viên',  'CNTT', 'CS2', null);
UPDATE THONGBAO SET OLS_COLUMN = TO_DATA_LABEL('CHINHSACH', 'NV:CNTT:CS2') WHERE ID = 27;

--TẠO USER
CREATE USER NV003 IDENTIFIED BY 123;
CREATE USER NV004 IDENTIFIED BY 123;
CREATE USER NV005 IDENTIFIED BY 123;
GRANT CONNECT TO NV003, NV004, NV005;
EXEC USERDBA.grant_role_for_user('TRUONGDONVI', 'NV003');
EXEC USERDBA.grant_role_for_user('TRUONGDONVI', 'NV004');
EXEC USERDBA.grant_role_for_user('TRUONGDONVI', 'NV005');


GRANT SELECT ON THONGBAO TO NV001, NV002, NV003, NV004, NV005,NV008, SV0001;

SELECT * FROM THONGBAO;
