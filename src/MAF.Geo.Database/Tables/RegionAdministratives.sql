CREATE TABLE [dbo].[RegionAdministratives]
(
	[RegionAdministrativeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomRegion] NVARCHAR(50) NOT NULL, 
    [CodeRegion] NVARCHAR(10) NOT NULL,

)
