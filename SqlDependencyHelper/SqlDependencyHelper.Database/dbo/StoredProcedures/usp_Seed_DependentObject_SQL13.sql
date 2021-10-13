CREATE PROCEDURE [dbo].[usp_Seed_DependentObject_SQL13]	
AS
BEGIN	
	TRUNCATE TABLE [dbo].[DependentObject];

	INSERT INTO [dbo].[DependentObject]([DatabaseName],[SchemaName],[ObjectName],[ObjectType],[ObjectDefinition])
	VALUES ('MDF0880_Member','','MDF0880_Member','Database','CREATE DATABASE MDF0880_Member')
	, ('MDF0880_Member','dbo','MemberUnit','Table','CREATE TABLE dbo.MemberUnit (ID INT)');
END