--SELECT ISNULL(MAX(emp_id),'e1') FROM d1_cdt_employees WHERE substring(emp_id,0,2) = 'e1'



SELECT isnull(max(left(emp_id + replicate('0',5),5)),'') FROM d1_cdt_employees --u01002

SELECT case When isnull(max(emp_id),'') = '' then replicate('0',5)+1 else (substring(isnull(max(emp_id),''),3,LEN(max(emp_id))-2)+1) end as qq FROM d1_cdt_employees
--group by emp_id;

--delete from d1_cdt_employees

SELECT REPLACE(STR(substring(isnull(emp_id,''),2,4),3),' ','0') as 'NumberFull',* FROM d1_cdt_employees
-- WHERE substring(emp_id,0,2) = 'e1'


declare @localvariable as int=0,@output varchar(7)

set @output =stuff( cast (@localvariable as varchar(7))+1,1,0,'0')
+ cast(REPLICATE('0',7-len(@localvariable)-2) as varchar(8))

select @output

select * from d1_cdt_employees

SELECT SUBSTRING(ltrim(emp_id),1,3)
--,'e12' + RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX(emp_id),'e120000'),4,4)+1) AS VARCHAR(4))),4) 
FROM d1_cdt_employees
 WHERE SUBSTRING(emp_id,1,3) = 'e12'

select SUSER_NAME()

SELECT RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX(emp_id),'E110001'),4,4)+1) AS VARCHAR(4))),4 ) FROM d1_cdt_employees;

 --where SUBSTRING(;

select substring(isnull('u010001',''),4,4)


SELECT 'e12' + RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX(emp_id),'e120000'),4,4)+1) AS VARCHAR(4))),4) FROM d1_cdt_employees WHERE SUBSTRING(emp_id,0,3) = 'e12'

SELECT 'e12345' + RIGHT(replicate('0',7-6)+ (CAST((SUBSTRING(ISNULL(MAX(emp_id),'e12345'+replicate('0',7-6)),6,2)+1) AS VARCHAR(1))),1) 
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,6) = 'e12345';


select 'e123'+RIGHT('0'+(CAST((substring((ISNULL(MAX(emp_id),'e123'+replicate('0',7-4))),4+1,7-4) +1)AS VARCHAR(1))),3)
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,4) = 'e123';

select (substring((ISNULL(MAX(emp_id),'e12'+replicate('0',7-4))),4+1,7-4) +1)
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,4) = 'e12';

select (substring(ISNULL(MAX(emp_id),0),5+1,7-5) +1)
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,5) = 'e1234';

insert into d1_cdt_employees(emp_id) values('e123409');

select max(emp_id)
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,3) = 'e12';

select *
FROM d1_cdt_employees WHERE SUBSTRING(emp_id,1,3) = 'e12';