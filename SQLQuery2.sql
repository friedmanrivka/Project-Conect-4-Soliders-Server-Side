-- Update the CityId column with random city IDs for each volunteer
UPDATE Volunteers
SET CityId = (
    SELECT TOP 1 Id 
    FROM City 
    ORDER BY NEWID()
);


-- Update the CityId column with random city IDs for each volunteer
UPDATE Volunteers
SET CityId = (
    SELECT TOP 1 Id 
    FROM City 
    ORDER BY NEWID()
);

-- Update the CityId column with random city IDs for each volunteer
UPDATE Volunteers
SET CityId = (
    SELECT TOP 1 Id 
    FROM City 
    WHERE CityId NOT IN (SELECT DISTINCT CityId FROM Volunteers WHERE CityId IS NOT NULL) -- Ensure uniqueness
    ORDER BY NEWID()
);