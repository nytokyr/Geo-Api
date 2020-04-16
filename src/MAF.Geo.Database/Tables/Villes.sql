CREATE TABLE [dbo].[Villes]
(
	[VilleId] INT NOT NULL PRIMARY KEY IDENTITY,  
    [PaysId] INT NOT NULL , 
    [RegionAdministrativeId] INT NULL,
    [DepartementId] int NULL,
	[RisqueId] INT NULL , 
    [NiveauSismiciteId] INT NOT NULL, 
    [CodeInsee] NVARCHAR(5) NULL, 
    [CodePostal] NVARCHAR(5) NOT NULL, 
    [NomVille] NVARCHAR(50) NOT NULL, 
    [SimpleVille] NVARCHAR(50) NOT NULL, 
    [Latitude] DECIMAL(10, 6) NULL, 
    [Longitude] DECIMAL(10, 6) NULL,
    CONSTRAINT FK_CodePostalVille_Pays FOREIGN KEY ([PaysId])
        REFERENCES Pays ([PaysId]),
    CONSTRAINT FK_Region_Ville FOREIGN KEY ([RegionAdministrativeId])
        REFERENCES RegionAdministratives ([RegionAdministrativeId]),
    CONSTRAINT FK_Departement_Ville FOREIGN KEY ([DepartementId])
        REFERENCES Departements ([DepartementId]),
    CONSTRAINT FK_CodePostalVille_Risques FOREIGN KEY ([RisqueId])
        REFERENCES Risques ([RisqueId]),
)
