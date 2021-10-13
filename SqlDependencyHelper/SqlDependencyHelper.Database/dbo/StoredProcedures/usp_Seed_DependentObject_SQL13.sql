CREATE PROCEDURE [dbo].[usp_Seed_DependentObject_SQL13]	
AS
BEGIN	
	TRUNCATE TABLE [dbo].[DependentObject];

	INSERT INTO [dbo].[DependentObject]([DependentObjectID],[DatabaseName],[SchemaName],[ObjectName],[ObjectType],[ObjectDefinition])
	VALUES (1,'MDF0880_Member','','MDF0880_Member','Database','CREATE DATABASE MDF0880_Member')
	, (2,'MDF0880_Member','dbo','MemberUnit','Table','CREATE TABLE MDF0880_Member.dbo.MemberUnit (ID INT)');
END