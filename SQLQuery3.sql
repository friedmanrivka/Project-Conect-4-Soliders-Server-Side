UPDATE Volunteers
SET CityId = ABS(CHECKSUM(NEWID()) % 20) + 1;

select FirstName
from volunteers


UPDATE Volunteers
SET MaleOrFemale = CASE
    WHEN FirstName IN ( 'Avi', 'Ido',  'Yosef', 'Moses', 'Yoni', 'Jonathan', 'Avraham', 'Ari', 'David', 'Yaron', 'Dov', 'Erez', 'Amit', 'Itai', 'Joseph', 'Yehuda', 'Natan', 'Yoav', 'Noam', 'Eitan', 'Jacob', 'Abraham', 'Yonatan', 'Yair') THEN 'male'
    WHEN FirstName IN ('Noah','Yael',  'Maya', 'Noga', 'Abigail', 'Chava', 'Adele', 'Ruth', 'Neta', 'Avital', 'Tamar', 'Rachel', 'Adi', 'Orly', 'Nina', 'Shira', 'Miriam', 'Chana', 'Mia', 'Sarah', 'Hadar', 'Adina', 'Tali') THEN 'female'
     WHEN FirstName IN('Yossi', 'Oren', 'Amir','Gaia', 'Eliana', 'Leah') THEN 'don''t want to say'
    ELSE 'don''t want to say'
END;