EXECUTE SA_SYSDBA.DROP_POLICY(policy_name => 'CHINHSACH');
EXECUTE SA_SYSDBA.CREATE_POLICY (policy_name => 'CHINHSACH', column_name => 'OLS_COLUMN');

EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 1000, short_name => 'TK', long_name => 'TRƯỞNG KHOA');
EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 800, short_name => 'TDV', long_name => 'TRƯỞNG ĐƠN VỊ');
EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 600, short_name => 'GV', long_name => 'GIẢNG VIÊN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 400, short_name => 'GVU', long_name => 'GIÁO VỤ');
EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 200, short_name => 'NV', long_name => 'NHÂN VIÊN');
EXECUTE SA_COMPONENTS.CREATE_LEVEL (policy_name => 'CHINHSACH', level_num => 100, short_name => 'SV', long_name => 'SINH VIÊN');

EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 10, short_name => 'HTTT', long_name => 'HỆ THỐNG THÔNG TIN');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 20, short_name => 'CNPM', long_name => 'CÔNG NGHỆ PHẦN MỀM');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 30, short_name => 'KHMT', long_name => 'KHOA HỌC MÁY TÍNH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 40, short_name => 'CNTT', long_name => 'CÔNG NGHỆ TRI THỨC');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 50, short_name => 'TGMT', long_name => 'THỊ GIÁC MÁY TÍNH');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT (policy_name => 'CHINHSACH', comp_num => 60, short_name => 'MMT', long_name => 'MẠNG MÁY TÍNH');

EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'CHINHSACH', group_num => 20, short_name => 'TRUONG', long_name => 'TRƯỜNG');
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'CHINHSACH', group_num => 40, short_name => 'CS1', long_name => 'CƠ SỞ 1', parent_name => 'TRUONG');
EXECUTE SA_COMPONENTS.CREATE_GROUP (policy_name => 'CHINHSACH', group_num => 60, short_name => 'CS2', long_name => 'CƠ SỞ 2', parent_name => 'TRUONG');

--TẠO NHÃN
--TRƯỞNG KHOA
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '100', label_value => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:TRUONG');

--TRƯỞNG ĐƠN VỊ
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '110', label_value => 'TDV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '120', label_value => 'TDV:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '130', label_value => 'TDV:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '140', label_value => 'TDV:CNPM:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '150', label_value => 'TDV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '160', label_value => 'TDV:KHMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '170', label_value => 'TDV:CNTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '180', label_value => 'TDV:CNTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '190', label_value => 'TDV:TGMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '200', label_value => 'TDV:TGMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '210', label_value => 'TDV:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '220', label_value => 'TDV:MMT:CS2');

--GIẢNG VIÊN
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '300', label_value => 'GV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '310', label_value => 'GV:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '320', label_value => 'GV:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '330', label_value => 'GV:CNPM:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '340', label_value => 'GV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '350', label_value => 'GV:KHMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '360', label_value => 'GV:CNTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '370', label_value => 'GV:CNTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '380', label_value => 'GV:TGMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '390', label_value => 'GV:TGMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '400', label_value => 'GV:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '410', label_value => 'GV:MMT:CS2');

--GIÁO VỤ
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '500', label_value => 'GVU:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '510', label_value => 'GVU:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '520', label_value => 'GVU:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '530', label_value => 'GVU:CNPM:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '540', label_value => 'GVU:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '550', label_value => 'GVU:KHMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '560', label_value => 'GVU:CNTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '570', label_value => 'GVU:CNTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '580', label_value => 'GVU:TGMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '590', label_value => 'GVU:TGMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '600', label_value => 'GVU:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '610', label_value => 'GVU:MMT:CS2');

--NHÂN VIÊN
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '700', label_value => 'NV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '710', label_value => 'NV:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '720', label_value => 'NV:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '730', label_value => 'NV:CNPM:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '740', label_value => 'NV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '750', label_value => 'NV:KHMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '760', label_value => 'NV:CNTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '770', label_value => 'NV:CNTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '780', label_value => 'NV:TGMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '790', label_value => 'NV:TGMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '800', label_value => 'NV:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '810', label_value => 'NV:MMT:CS2');

--SINH VIÊN
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '900', label_value => 'SV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '910', label_value => 'SV:HTTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '920', label_value => 'SV:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '930', label_value => 'SV:CNPM:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '940', label_value => 'SV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '950', label_value => 'SV:KHMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '960', label_value => 'SV:CNTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '970', label_value => 'SV:CNTT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '980', label_value => 'SV:TGMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '990', label_value => 'SV:TGMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '1000', label_value => 'SV:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL (policy_name => 'CHINHSACH', label_tag => '1010', label_value => 'SV:MMT:CS2');

--GÁN CHÍNH SÁCH CHO BẢNG THONGBAO
EXECUTE SA_POLICY_ADMIN.APPLY_TABLE_POLICY (policy_name => 'CHINHSACH', schema_name => 'USERDBA', table_name => 'THONGBAO', table_options => 'NO_CONTROL');

--KIỂM TRA CHÍNH SÁCH
SELECT * FROM DBA_SA_LEVELS; 
SELECT * FROM DBA_SA_COMPARTMENTS;
SELECT * FROM DBA_SA_GROUPS;
SELECT * FROM DBA_SA_LABELS;
/

--GỠ VÀ GÁN CHÍNH SÁCH MỚI CHO BẢNG THONGBAO
EXECUTE SA_POLICY_ADMIN.REMOVE_TABLE_POLICY(policy_name => 'CHINHSACH', schema_name => 'USERDBA', table_name => 'THONGBAO');
/
EXECUTE SA_POLICY_ADMIN.APPLY_TABLE_POLICY (policy_name => 'CHINHSACH', schema_name => 'USERDBA', table_name => 'THONGBAO', table_options => 'READ_CONTROL');
/

--GÁN NHÃN CHO USERS
--CÂU A
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV001', max_read_label => 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:TRUONG');
--CÂU B
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV002', max_read_label => 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:TRUONG');
--CÂU C
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV008', max_read_label => 'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:TRUONG');
--CÂU D
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV003', max_read_label => 'TDV:CNTT:CS2');
--CÂU E
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'SV0001', max_read_label => 'SV:HTTT:CS1');
--CÂU F
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV004', max_read_label => 'TDV:KHMT:CS1');
--CÂU G
EXECUTE SA_USER_ADMIN.SET_USER_LABELS (policy_name => 'CHINHSACH', user_name => 'NV005', max_read_label => 'TDV:KHMT:CS2');

--LỆNH TEST
--SELECT * FROM USERDBA.THONGBAO;