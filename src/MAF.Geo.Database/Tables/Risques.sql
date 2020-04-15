CREATE TABLE [dbo].[Risques]
(
	[RisquesId] INT NOT NULL PRIMARY KEY, 
    [Libelle] NVARCHAR(MAX) NOT NULL, 
    [DateUpdate] DATETIME2 NULL
)
