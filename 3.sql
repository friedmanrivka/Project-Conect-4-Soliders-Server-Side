DROP TABLE Street;
ALTER TABLE Street DROP CONSTRAINT FK_StreetCity;
DROP TABLE Street;
ALTER TABLE Address DROP CONSTRAINT FK__Address__Apartme__6383C8BA;
DROP TABLE Street;

DROP TABLE Address;


SELECT 
    fk.name AS ForeignKeyName,
    tp.name AS ParentTableName
FROM 
    sys.foreign_keys AS fk
INNER JOIN 
    sys.tables AS tp ON fk.parent_object_id = tp.object_id
INNER JOIN 
    sys.tables AS tr ON fk.referenced_object_id = tr.object_id
WHERE 
    tr.name = 'Address';

    ALTER TABLE IDFBases DROP CONSTRAINT FK_IDFBasesAddress;
    DROP TABLE Address;