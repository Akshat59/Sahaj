
/***********************Table Creation*******************************************/

/*
d1 - application - sahaj
cdt - common data tables /
xrt - Reference data tables /
trt - transaction tables]
csp - common stored procedure

*/

begin

BEGIN
	IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_cdt_users')
	BEGIN
		DROP TABLE d1_cdt_users
		PRINT 'TABLE  d1_cdt_users Dropped Successfully'
	END

	BEGIN
		CREATE TABLE d1_cdt_users (
		 [usr_id] INT IDENTITY(1,1) NOT NULL
		,[user_id] VARCHAR(7) NOT NULL
		,[user_name] VARCHAR(20) NOT NULL
		,user_first_name VARCHAR(20) DEFAULT ''
		,user_last_name VARCHAR(30) DEFAULT ''
		,[password] VARCHAR(15) DEFAULT ''
		,encyrpted_pwd NVARCHAR(200) DEFAULT ''
		,role_id INT DEFAULT 0
		,last_accessed DATETIME DEFAULT GETDATE()
		,last_pwd_change DATETIME DEFAULT GETDATE()
		,profilepic VARCHAR(10) DEFAULT 'img_usr000'
		
		,create_id VARCHAR(30) DEFAULT SYSTEM_USER
		,create_date DATETIME DEFAULT GETDATE()
		,update_id VARCHAR(30) DEFAULT SYSTEM_USER
		,update_date DATETIME DEFAULT GETDATE()
		)

		ALTER TABLE d1_cdt_users ADD CONSTRAINT pk_d1_cdt_users PRIMARY KEY NONCLUSTERED ([user_id])
		ALTER TABLE d1_cdt_users ADD CONSTRAINT uk_d1_cdt_users UNIQUE ([user_name])

		--select * from d1_cdt_users
	END
END--d1_cdt_users    


BEGIN --d1_cdt_employees  --select * from d1_cdt_employees
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_cdt_employees')
BEGIN
	DROP TABLE d1_cdt_employees
	PRINT 'TABLE  d1_cdt_employees Dropped Successfully'
END

BEGIN
	--DROP TABLE d1_cdt_employees
CREATE TABLE d1_cdt_employees(e_uid INT IDENTITY(6110001,1)
,emp_id VARCHAR(7) DEFAULT '' NOT NULL
,firstname VARCHAR(30) DEFAULT ''
,lastname VARCHAR(30) DEFAULT ''
,petname VARCHAR(10) DEFAULT ''
,dob VARCHAR(10) DEFAULT '' --DD-MM-YYYY   
,gender CHAR(1) DEFAULT ''
,emptype VARCHAR(20) DEFAULT ''
,designation VARCHAR(20) DEFAULT ''
,empaddress VARCHAR(1000) DEFAULT ''
,pincode VARCHAR(6) DEFAULT ''
,homephone VARCHAR(15) DEFAULT ''
,mobile VARCHAR(10) DEFAULT ''
,emailid VARCHAR(30) DEFAULT ''
,education VARCHAR(20) DEFAULT ''
,aadhaarno VARCHAR(12) DEFAULT ''
,addressproof VARCHAR(20) DEFAULT ''
,dl_no VARCHAR(40) DEFAULT ''
,dl_htmv VARCHAR(1) DEFAULT ''
,dl_hmv CHAR(1) DEFAULT ''
,dl_lmv CHAR(1) DEFAULT ''
,dl_rto VARCHAR(30) DEFAULT ''
,dl_expdt VARCHAR(10) DEFAULT ''
,hiring_manager_id VARCHAR(7) DEFAULT ''
,hiring_date VARCHAR(10) DEFAULT ''
,experience VARCHAR(300) DEFAULT ''
,attributes VARCHAR(1000) DEFAULT ''
,otherdetails VARCHAR(1000) DEFAULT ''
,emp_status VARCHAR(4) DEFAULT ''
,allow_login CHAR(1) DEFAULT 'N'
,create_id VARCHAR(50) DEFAULT SUSER_NAME()
,create_date DATETIME DEFAULT GETDATE()
,update_id VARCHAR(50) DEFAULT SUSER_NAME()
,update_date DATETIME DEFAULT GETDATE()
)


	ALTER TABLE d1_cdt_employees ADD CONSTRAINT pk_d1_cdt_employees PRIMARY KEY NONCLUSTERED (emp_id)

END
end

BEGIN
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_app_info')
BEGIN
	DROP TABLE d1_app_info
	PRINT 'TABLE  d1_app_info Dropped Successfully'
END

BEGIN
	CREATE TABLE d1_app_info (
		[app_name] VARCHAR(20) DEFAULT ('Sahaj')
		,[version] VARCHAR(20) DEFAULT ('0.01')
		,[app_owner] VARCHAR(20) DEFAULT 'New Prem Bus Service'
	)

--select * from d1_app_info insert into d1_app_info(app_name) values ('Sahaj')
END
END--d1_app_info


BEGIN --d1_cdt_empdocs  select * from d1_cdt_empdocs
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_cdt_empdocs')
BEGIN
	DROP TABLE d1_cdt_empdocs
	PRINT 'TABLE  d1_cdt_empdocs Dropped Successfully'
END

BEGIN
CREATE TABLE d1_cdt_empdocs(
 empdoc_id INT IDENTITY(6120001,1)
,emp_id VARCHAR(7) DEFAULT '' NOT NULL
,doctype VARCHAR(3) DEFAULT ''
,doctype_id VARCHAR(4) DEFAULT ''
,doc_name VARCHAR(50) DEFAULT ''
,doc_extn VARCHAR(10) DEFAULT ''
,doc_img IMAGE
,active_ind CHAR(1) DEFAULT ''
,create_id VARCHAR(50) DEFAULT SUSER_NAME()
,create_date DATETIME DEFAULT GETDATE()
,update_id VARCHAR(50) DEFAULT SUSER_NAME()
,update_date DATETIME DEFAULT GETDATE())
END


END

BEGIN --d1_cdt_usernotes  select * from d1_cdt_usernotes
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_cdt_usernotes')
BEGIN
	DROP TABLE d1_cdt_usernotes
	PRINT 'TABLE  d1_cdt_usernotes Dropped Successfully'
END

BEGIN
CREATE TABLE d1_cdt_usernotes(
 note_id INT IDENTITY(6130000,1)
,[user_id] VARCHAR(7) DEFAULT '' NOT NULL
,note_date DATE DEFAULT GETDATE()
,note_text VARCHAR(3000) DEFAULT ''
,create_id VARCHAR(50) DEFAULT SUSER_NAME()
,create_date DATETIME DEFAULT GETDATE()
,update_id VARCHAR(50) DEFAULT SUSER_NAME()
,update_date DATETIME DEFAULT GETDATE())
END

--DELETE FROM d1_cdt_usernotes WHERE [user_id] = @user_id AND note_date = @note_date
--INSERT INTO d1_cdt_usernotes ([user_id],note_date,note_text,create_id,create_date,update_id,update_date) VALUES (@user_id,@note_date,@note_text,@create_id,@create_date,@update_id,@update_date)
--SELECT note_text FROM d1_cdt_usernotes WHERE [user_id] = @user_id and note_date =@note_date
END






end



--SP
go
begin

begin
--drop procedure d1_csp_searchentity

alter PROCEDURE d1_csp_searchentity (
@searchtype varchar(20)
,@entId varchar(9)
,@name varchar(50)
) 
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	SET @name = convert(varchar(50),REPLACE(@name,' ',''))
	SET @entId = convert(varchar(9),REPLACE(@entId,' ',''))
	if @name= ''
	begin
		set @name = 'zzzzz'
	end
	if @entId= ''
	begin
		set @entId = 'zzzzz'
	end
		
	if (@searchtype='EMPLOYEE')
	begin
	select emp_id "Employee ID",firstname+' '+lastname Name ,petname+' '+emptype+' '+empaddress+' '+mobile Details
	,case when emp_status = 'A' THEN 'Active' ELSE 'Terminated' END AS 'Status'
	from d1_cdt_employees 
	where (emp_id in (@entId) or convert(varchar(50),replace(firstname,' ','')) like '%'+@name+'%' or convert(varchar(50),replace(lastname,' ','')) like '%'+@name+'%'
		or replace(convert(varchar(50),firstname)+convert(varchar(50),lastname),' ','') like '%'+@name+'%') /*AND emp_status = 'A'*/
	end
END


end


end






begin
------------Insert Update Emp
UPDATE d1_cdt_employees SET firstname = @firstname,lastname= @lastname,petname= @petname,dob= @dob,gender= @gender,emptype= @emptype,designation= @designation,empaddress= @empaddress,pincode= @pincode,homephone= @homephone,mobile= @mobile,emailid= @emailid,education= @education,aadhaarno= @aadhaarno,addressproof= @addressproof,dl_no= @dl_no,dl_htmv= @dl_htmv,dl_hmv= @dl_hmv,dl_lmv= @dl_lmv,dl_rto= @dl_rto,dl_expdt= @dl_expdt,hiring_manager_id= @hiring_manager_id,hiring_date= @hiring_date,experience= @experience,attributes= @attributes,otherdetails= @otherdetails,emp_status= @emp_status,allow_login= @allow_login,update_id= @update_id,update_date= @update_date WHERE emp_id =@emp_id

UPDATE d1_cdt_employees SET emp_status= @emp_status,allow_login= @allow_login,update_id= @update_id,update_date= @update_date WHERE emp_id =@emp_id


UPDATE d1_cdt_empdocs SET active_ind= @active_ind,update_id= @update_id,update_date= @update_date WHERE emp_id =@emp_id

UPDATE d1_cdt_empdocs SET doc_name= @doc_name,doc_extn= @doc_extn,doc_img= @doc_img,active_ind= @active_ind,update_id= @update_id,update_date= @update_date WHERE emp_id =@emp_id AND doctype = @doc_type ;

--@doc_type
end