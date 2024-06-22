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