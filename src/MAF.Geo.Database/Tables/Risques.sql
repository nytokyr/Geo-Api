CREATE TABLE [dbo].[Risques]
(
	[RisqueId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Libelle] NVARCHAR(MAX) NOT NULL, 
    [DateUpdate] DATETIME2 NULL
)
