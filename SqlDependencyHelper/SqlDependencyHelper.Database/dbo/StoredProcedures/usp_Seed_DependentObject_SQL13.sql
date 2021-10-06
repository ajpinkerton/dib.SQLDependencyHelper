CREATE PROCEDURE [dbo].[usp_Seed_DependentObject_SQL13]	
AS
BEGIN	
	TRUNCATE TABLE [dbo].[DependentObject];

	INSERT INTO [dbo].[DependentObject]([DatabaseName],[SchemaName],[ObjectName],[ObjectType])
	VALUES ('MDF0880_Member','dbo','MemberUnit','Table');
END