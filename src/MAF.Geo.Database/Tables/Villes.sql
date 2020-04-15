CREATE TABLE [dbo].[Villes]
(
	[PaysId] INT NOT NULL , 
	[RisquesId] INT NULL , 
    [NiveauSismiciteId] INT NOT NULL, 
    [CodeInsee] NVARCHAR(5) NULL, 
    [CodePostal] NVARCHAR(5) NOT NULL, 
    [Ville] NVARCHAR(50) NOT NULL, 
    [SimpleVille] NVARCHAR(50) NOT NULL, 
    [Latitude] DECIMAL(9, 6) NULL, 
    [Longitude] DECIMAL(9, 6) NULL,
    CONSTRAINT FK_CodePostalVille_Pays FOREIGN KEY ([PaysId])
        REFERENCES Pays ([PaysId]),
    CONSTRAINT FK_CodePostalVille_Risques FOREIGN KEY ([RisquesId])
        REFERENCES Risques ([RisquesId]),
)
