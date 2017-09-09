
/****************INSERT SCRIPTS*********************/

--d1_cdt_users
BEGIN
truncate table d1_cdt_users;
insert into d1_cdt_users
 ([user_id],[user_name],user_first_name,user_last_name,[password],role_id) 
VALUES('A001659','akshats','Akshat','Soni','Test123!',1);

select * from d1_cdt_users;
END



INSERT INTO d1_cdt_employees(,d1_cdt_employees,emp_id,firstname,lastname,petname,dob,gender,emptype,empaddress,pincode,homephone,mobile,education,aadhaarno,addressproof,dl_no,dl_htmv,dl_hmv,dl_lmv,dl_rto,hiring_manager_id,experience,attributes,otherdetails) VALUES 
(@emp_id,@firstname,@lastname,@petname,@dob,@gender,@emptype,@empaddress,@pincode,@homephone,@mobile,@education,@aadhaarno,@addressproof,@dl_no,@dl_htmv,@dl_hmv,@dl_lmv,@dl_rto,@hiring_manager_id,@experience,@attributes,@otherdetails)
