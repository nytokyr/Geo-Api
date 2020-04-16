SET IDENTITY_INSERT Risques ON
GO

MERGE INTO Risques AS Target
USING (VALUES
  (1, N'Séisme zone de sismicite 3|Transport de marchandises dangereuses')
)
AS Source (RisquesId, Libelle)
ON Target.RisquesId = Source.RisquesId
-- update matched rows
WHEN MATCHED THEN
    UPDATE SET Libelle = Source.Libelle
-- insert new rows
WHEN NOT MATCHED BY TARGET THEN
    INSERT (RisquesId, Libelle)
    VALUES (RisquesId, Libelle);

SET IDENTITY_INSERT Risques OFF
GO