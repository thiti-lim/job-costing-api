CREATE TABLE [dbo].[customer]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[name] NVARCHAR(50) NOT NULL, 
	[location] NVARCHAR(50) NOT NULL, 
	[contact] NVARCHAR(50) NOT NULL, 
	[phone_number] NVARCHAR(20) NOT NULL, 
)
