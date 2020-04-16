MERGE INTO Departements AS Target
USING (VALUES
  (1, N'Ain'),
  (2, N'Aisne'),
  (3, N'Allier')
)
AS Source (DepartementId,NomDepartement)
ON Target.DepartementId = Source.DepartementId
-- update matched rows
WHEN MATCHED THEN
    UPDATE SET NomDepartement = Source.NomDepartement
-- insert new rows
WHEN NOT MATCHED BY TARGET THEN
    INSERT (DepartementId, NomDepartement)
    VALUES (DepartementId, NomDepartement);
