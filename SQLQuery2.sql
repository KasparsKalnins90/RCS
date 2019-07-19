SELECT * FROM Users

INSERT INTO Users(id, Username, CreatedOn, Balance)
VALUES(3,'admin', '2019-06-10', 850.75 )

UPDATE Users 
SET Balance = 1000, Username = 'admin2' -- ja izpilda tikai šo rindiņu, tad visā tabulā izmaina 
WHERE Id = 3 -- ja lieto filtru, tad tikai tur, kur norādam

DELETE FROM Users -- ja izpilda tikai šo rindiņu, tad dzēš visu
WHERE Id = 1; -- tam atkal lieto filtru  (semikolu liek tad, ja ir vairāki kritēriji

SELECT * FROM Users
WHERE Username = 'admin' -- var meklēt tiešu sakritību

SELECT * FROM Users
WHERE Username like 'admin%' -- ja var tikai daļēji sakrist % norāda uz sadaļu, kas var atšķirties

SELECT * FROM Users
WHERE Balance > 900 -- var arī salīdzināšanu <,  >,  >=,  <= 
AND Balance < 1000
AND Username = 'admin2'  -- var atlasīt pēc vairākiem kritērijiem

SELECT * FROM Users
WHERE CreatedOn > '2019-06-01'

SELECT count(*) FROM Users -- dod mums kopējo ierakstu skaitu
WHERE Id  = 3; -- var arī šim likt filtru


CREATE TABLE Orders
(
Id INT,
UserId INT,
ItemTitle NVARCHAR(100)
)

INSERT INTO Orders(Id, UserId, ItemTitle) -- ja jāievada visur, tad var nenorādīt visas kolonnas iekavās
VALUES(1, 3, 'Prece 1')

SELECT o.* From Orders o, Users u
where o.UserId = u.Id
AND u.Username = 'admin2';

