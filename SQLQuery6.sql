ALTER TABLE IDFBases DROP CONSTRAINT FK_IDFBasesAddress;
ALTER TABLE IDFBases DROP COLUMN AddressId;

ALTER TABLE IDFBases
ADD CityId INT NULL;




UPDATE IDFBases
SET CityId = (SELECT TOP 1 Id FROM (SELECT Id FROM City ORDER BY NEWID()) AS RandomCity ORDER BY NEWID());

UPDATE IDFBases
SET CityId = (
    SELECT TOP 1 Id 
    FROM City AS C
    CROSS APPLY (
        SELECT C.Id
        ORDER BY NEWID()
    ) AS RandomCity
);

DECLARE @CityCounter INT = 1;

UPDATE IDFBases
SET CityId = @CityCounter,
    @CityCounter = CASE WHEN @CityCounter = 20 THEN 1 ELSE @CityCounter + 1 END;


    ALTER TABLE IDFBases
ADD CONSTRAINT FK_IDFBases_CityId FOREIGN KEY (CityId) REFERENCES City(Id);