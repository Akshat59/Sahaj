/**********************************************************************************************************************************************
*
*
*
*d1_cdt_users
*
*
*
*
**********************************************************************************************************************************************/
BEGIN TRY
	DECLARE @errorMsg VARCHAR(MAX)

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

	END

		PRINT 'Script Deployment Report'
		PRINT '-------------------------------------------------------------------------------------------------------------------'
		PRINT 'SERVER:																				'+@@SERVERNAME
		PRINT 'DATABASE:																			'+CONVERT(VARCHAR,DB_NAME())
		PRINT 'USER:																				'+CONVERT(VARCHAR,SYSTEM_USER)
		PRINT 'DATE:																				'+CONVERT(VARCHAR,GETDATE(),120)

	IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME= 'd1_cdt_users')
	BEGIN		
		PRINT 'Database objet Deployed Successfully:												'+'d1_cdt_users'
	END
	ELSE
	BEGIN
		PRINT CHAR(12)+'!!!!Database objet Deployment FAILED!!!										'+'d1_cdt_users'
	END
END TRY
BEGIN CATCH
	SELECT @errorMsg = ERROR_MESSAGE()
		PRINT CHAR(12)+'!!!!Database objet Deployment FAILED!!!										'+'d1_cdt_users'
		PRINT 'Error Message																		'+@errorMsg
END CATCH











/*********************************************************************************************************************************************/

