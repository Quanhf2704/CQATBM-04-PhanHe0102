--------------------------------------------------------------------------------
-- XEM DANH SACH CAC USERS
SELECT username FROM dba_users;

--------------------------------------------------------------------------------
-- XEM DANH SACH CAC ROLES
SELECT * FROM dba_roles;

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
        INNER JOIN DBA_ROLE_PRIVS RP ON R.ROLE = RP.GRANTED_ROLE
        WHERE GRANTEE = UPPER(p_username);
END;

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
           grantable AS admin_option,
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
           grantable AS admin_option,
           owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
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


--------------------------------------------------------------------------------
-- XEM QUYEN ROLE
CREATE VIEW role_privileges AS (
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
           grantable AS admin_option,
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
           grantable AS admin_option,
           owner AS owner,
           table_name AS table_name,
           column_name AS column_name,
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
EXEC sys.create_user ('user1', '111');

--------------------------------------------------------------------------------
----Xoa user----
CREATE OR REPLACE PROCEDURE drop_user (
    p_username VARCHAR2
) IS
BEGIN
    -- Xóa user
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/
EXEC drop_user ('user3');

--------------------------------------------------------------------------------
----Tao role----
CREATE OR REPLACE PROCEDURE create_role (
    p_rolename VARCHAR2
    --p_password VARCHAR2 DEFAULT NULL
) IS
BEGIN
    -- Tạo mới role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    --IF(p_password = ' ') THEN
        EXECUTE IMMEDIATE 'CREATE  ROLE ' || p_rolename;
    --ELSE
      --  EXECUTE IMMEDIATE 'CREATE  ROLE ' || p_rolename || ' IDENTIFIED BY ' || p_password;
    --END IF;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/
EXEC create_role('sinhvien');

--------------------------------------------------------------------------------
----Xoa role----
CREATE OR REPLACE PROCEDURE drop_role (
    p_rolename VARCHAR2
) IS
BEGIN
    -- Xoa role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE'; 
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_rolename;
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE'; 
END;
/
EXEC drop_role ('sinhvien');

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
    -- Cấp quy�?n
    IF (p_tablename = ' ') THEN
        EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' TO ' || p_grantee;
    ELSE
        EXECUTE IMMEDIATE 'GRANT ' || p_privilege || ' ON ' || p_tablename || ' TO ' || p_grantee;
    END IF;
END;
/
EXEC grant_permission_role('RESOURCE',' ','sinhvien');
EXEC grant_permission_role('sinhvien','INSERT (TENHP)','PROJECT_HOCPHAN');

--------------------------------------------------------------------------------
----Cap quyen cho user
CREATE OR REPLACE PROCEDURE grant_permission_user (
    p_privilege VARCHAR2,
    p_tablename VARCHAR2,
    p_grantee VARCHAR2,
    p_with_grant_option CHAR
) IS
BEGIN
    -- Cấp quy�?n
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
EXEC grant_permission_user('sinhvien','test',' ', '0');
EXEC grant_permission_user('INSERT (TENHP)','test','PROJECT_HOCPHAN', 1);

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
    -- Thu hồi quy�?n hạn
    IF (p_tablename = ' ') THEN
        EXECUTE IMMEDIATE 'REVOKE ' || p_privilege || ' FROM ' || p_grantee;
    ELSE
        EXECUTE IMMEDIATE 'REVOKE ' || p_privilege || ' ON ' || p_tablename || ' FROM ' || p_grantee;
    END IF;
END;
/
EXEC revoke_permission ('SINHVIEN',' ','test');

--------------------------------------------------------------------------------
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
EXEC alter_role ('sinhvien', ' ');

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
EXEC alter_role ('sinhvien', '123');


CREATE OR REPLACE PROCEDURE grant_role_for_user (
    p_role VARCHAR2,
    p_user VARCHAR2
) IS
BEGIN
        EXECUTE IMMEDIATE 'GRANT ' || p_role || ' TO ' || p_user;
END;

EXEC grant_role_for_user ('sinhvien', 'test');


CREATE OR REPLACE PROCEDURE revoke_role_from_user (
    p_role VARCHAR2,
    p_user VARCHAR2
) IS
BEGIN
        EXECUTE IMMEDIATE 'REVOKE ' || p_role || ' FROM ' || p_user;
END;
/
EXEC revoke_role_from_user ('sinhvien','test');


