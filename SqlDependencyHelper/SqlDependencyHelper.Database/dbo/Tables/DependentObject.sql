CREATE TABLE [dbo].[DependentObject]
(
	[DependentObjectID] INT NOT NULL,
	[DatabaseName] VARCHAR(255),
	[SchemaName] VARCHAR(255),
	[ObjectName] VARCHAR(255),
	[ObjectType] VARCHAR(255),
	[ObjectDefinition] VARCHAR(MAX),
	CONSTRAINT PK_DependentObject PRIMARY KEY (DependentObjectID)
)
