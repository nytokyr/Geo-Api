SET IDENTITY_INSERT Pays ON
GO

MERGE INTO Pays AS Target
USING (VALUES
  (1, N'France'),
  (2, N'Belgique')
)
AS Source (PaysId, NomPays)
ON Target.PaysId = Source.PaysId
-- update matched rows
WHEN MATCHED THEN
    UPDATE SET NomPays = Source.NomPays
-- insert new rows
WHEN NOT MATCHED BY TARGET THEN
    INSERT (PaysId, NomPays)
    VALUES (PaysId, NomPays);

SET IDENTITY_INSERT Pays OFF
GO