SET ROLE GIANGVIEN;
    SELECT * FROM USERDBA.UV_SEL_NHANVIEN;
    UPDATE USERDBA.UV_SEL_NHANVIEN SET DT = '0123456789';
    SELECT * FROM USERDBA.DONVI;
    SELECT * FROM USERDBA.HOCPHAN;
    SELECT * FROM USERDBA.SINHVIEN;
    SELECT * FROM USERDBA.KHMO;
SELECT * FROM USERDBA.UV_SEL_GIANGVIEN_PHANCONG;  
SELECT * FROM USERDBA.UV_SEL_GIANGVIEN_DANGKY;
UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET MASV = 'SV0695' WHERE MASV = 'SV0614' AND MAGV = 'NV018' AND MAHP = 'HP001' AND HK = 1 AND NAM = 2024 AND MACT = 'CLC';
UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMTH = '8.9' WHERE MASV = 'SV0614' AND MAGV = 'NV018' AND MAHP = 'HP001' AND HK = 1 AND NAM = 2024 AND MACT = 'CLC';
