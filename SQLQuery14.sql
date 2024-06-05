CREATE TABLE [dbo].[BaseRequests] (
    [RequestId]            INT IDENTITY (1, 1) NOT NULL,
    [IDFBaseId]            INT NOT NULL,
    [KindOfVolunteeringId] INT NOT NULL,
    [RequestDate]          DATETIME NOT NULL DEFAULT GETDATE(),
    [Status]               NVARCHAR(50) NOT NULL DEFAULT 'Active', 
    PRIMARY KEY CLUSTERED ([RequestId] ASC),
    CONSTRAINT [FK_VolunteerRequests_IDFBases] FOREIGN KEY ([IDFBaseId]) REFERENCES [dbo].[IDFBases] ([Id]),
    CONSTRAINT [FK_VolunteerRequests_KindOfVolunteering] FOREIGN KEY ([KindOfVolunteeringId]) REFERENCES [dbo].[KindOfVolunteering] ([Id])
);

select *
from KindOfVolunteering;

INSERT INTO [dbo].[BaseRequests] (IDFBaseId, KindOfVolunteeringId)
VALUES 
(1, 1), -- Comforting the bereaved families at base 1
(2, 2), -- Visiting wounded soldiers at base 2
(3, 3), -- Singing dancing and joy together at base 3
(4, 4); -- Help and support for the soldiers families at base 4

SELECT BR.RequestId, B.Name AS BaseName, K.Description AS VolunteeringType, BR.RequestDate
FROM BaseRequests BR
JOIN IDFBases B ON BR.IDFBaseId = B.Id
JOIN KindOfVolunteering K ON BR.KindOfVolunteeringId = K.Id
WHERE BR.Status = 'Active';