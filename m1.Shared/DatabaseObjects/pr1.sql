--SELECT CONVERT(VARCHAR,GETDATE(),120);

--insert into d1_cdt_users (user_id,user_name) VALUES('A01659','akshats');

select * from d1_cdt_users;

select [user_id],[user_name],user_first_name,user_last_name,role_id,last_accessed,last_pwd_change,profilepic from d1_cdt_users where [user_name] = 'akshats';

insert into d1_cdt_employees (emp_id,emailid) VALUES('A01659','akshats');

 select * from d1_cdt_employees;

--delete from d1_cdt_employees;

INSERT INTO d1_cdt_employees(emp_id,firstname,lastname,petname,dob,gender,emptype,designation,empaddress,pincode,homephone,mobile,emailid,education,aadhaarno,addressproof,dl_no,dl_htmv,dl_hmv,dl_lmv,dl_rto,hiring_manager_id,experience,attributes,otherdetails,emp_status) VALUES 
('u01002','Ram','Kumar','ramu','01-01-1983','M','Driver','Driver','1234 Mohala 1 Nagrota Bagwan Hp','176047','01892252000','9418012345','ram_kumar@gmail.com','Graduation','123456789012','rashan card','hp-40-123456789','Y','Y','Y','nagrota bagwan','','5 years with national 3 years with shivalik','Long Route driver','smoker, drinker','A')

select * from d1_cdt_empdocs;

--delete from d1_cdt_employees where e_uid > 13


select doctype,doc_name,doc_extn,doc_img from d1_cdt_empdocs where emp_id = '@empid' and active_ind = 'A';


select * from d1_cdt_empdocs where emp_id = 'e120003' order by active_ind desc,update_date;

select * from d1_cdt_usernotes order by note_date;
--truncate table d1_cdt_empdocs ;



