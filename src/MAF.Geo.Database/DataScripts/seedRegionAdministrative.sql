SET IDENTITY_INSERT RegionAdministratives ON
GO

MERGE INTO RegionAdministratives AS Target
USING (VALUES
  (1, N'Guadeloupe',N'1'),
  (2, N'Martinique',N'2'),
  (3, N'Guyane',N'3')
)
AS Source (RegionAdministrativeId, NomRegion,CodeRegion)
ON Target.RegionAdministrativeId = Source.RegionAdministrativeId
-- update matched rows
WHEN MATCHED THEN
    UPDATE SET CodeRegion = Source.CodeRegion , 
               NomRegion = Source.NomRegion
-- insert new rows
WHEN NOT MATCHED BY TARGET THEN
    INSERT (RegionAdministrativeId,NomRegion, CodeRegion)
    VALUES (RegionAdministrativeId,NomRegion, CodeRegion);

SET IDENTITY_INSERT RegionAdministratives OFF
GO