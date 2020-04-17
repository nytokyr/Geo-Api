
MERGE INTO Villes AS Target
USING (VALUES
  (1, null,null,1,1, N'01053' , N'01000', N'Bourg-en-Bresse', N'BOURG-EN-BRESSE',46.200000,5.216667),
  (1, null,null,1,1, N'01344' , N'01000', N'Saint-Denis-lès-Bourg', N'SAINT-DENIS-LES-BOURG',46.202056,5.1906345),
  (1, null,null,1,1, N'01053' , N'01001', N'BOURG EN BRESSE CEDEX', N'BOURG EN BRESSE CEDEX',46.200001,5.21667),
  (1, null,null,1,1, N'01053' , N'01002', N'BOURG EN BRESSE CEDEX', N'BOURG EN BRESSE CEDEX',46.200001,5.21667),
  (2, null,null,1,1, null , N'3200', N'Aarschot', N'AARSCHOT',50.9833,4.8333)
)
AS Source (PaysId
           ,RegionAdministrativeId
           ,DepartementId
           ,RisqueId
           ,NiveauSismiciteId
           ,CodeInsee
           ,CodePostal
           ,NomVille
           ,SimpleVille
           ,Latitude
           ,Longitude)
ON  Target.PaysId = Source.PaysId 
AND Target.CodePostal = Source.CodePostal 
And Target.SimpleVille = Source.SimpleVille
-- update matched rows
WHEN MATCHED THEN
    UPDATE SET 
           RegionAdministrativeId = Source.RegionAdministrativeId
           ,DepartementId = Source.DepartementId
           ,RisqueId = Source.RisqueId
           ,NiveauSismiciteId = Source.NiveauSismiciteId
           ,CodeInsee = Source.CodeInsee        
           ,NomVille = Source.NomVille
           ,Latitude = Source.Latitude
           ,Longitude = Source.Longitude
-- insert new rows
WHEN NOT MATCHED BY TARGET THEN
 INSERT     (PaysId
           ,RegionAdministrativeId
           ,DepartementId
           ,RisqueId
           ,NiveauSismiciteId
           ,CodeInsee
           ,CodePostal
           ,NomVille
           ,SimpleVille
           ,Latitude
           ,Longitude)
     VALUES
           (PaysId
           ,RegionAdministrativeId
           ,DepartementId
           ,RisqueId
           ,NiveauSismiciteId
           ,CodeInsee
           ,CodePostal
           ,NomVille
           ,SimpleVille
           ,Latitude
           ,Longitude);
GO

