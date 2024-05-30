ALTER TABLE Volunteers
DROP COLUMN AddressId;

ALTER TABLE Volunteers
ADD CityId INT NULL,
CONSTRAINT FK_CityId FOREIGN KEY (CityId) REFERENCES City(Id);

-- Update the CityId column with random city IDs for each volunteer
UPDATE Volunteers
SET CityId = (SELECT TOP 1 Id FROM City ORDER BY NEWID()) -- Select a random city ID from the City table

-- Update the CityId column with random city IDs for each volunteer
UPDATE Volunteers
SET CityId = (SELECT TOP 1 Id FROM (SELECT Id FROM City ORDER BY NEWID()) AS RandomCity ORDER BY NEWID());

