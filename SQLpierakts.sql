CREATE TABLE Users -- šitā izveido tabulu
( -- iekavās definē kolonnas
id INT, -- tabulas nosaukums un tad datu tips
Username NVARCHAR(50), -- N nozīmē to, ka mums ir arī spec. simboli, 50 - 
--maksimālais zīmju skaits, VAR - lai saglabā tikai tik
-- vietu cik vajag, CHAR ir tas pats, kas C# string
CreatedOn DATE,
Balance DECIMAL(8, 2 ), -- pirmais skaitlis- cik ciparu kopā, otrais skaitlis- cik aiz komata
)
CREATE TABLE Pasutijumi(
Pasutijuma_id INT,
Pasutijuma_summa DECIMAL(8, 2),
Pasutijuma_datums DATE

)
INSERT INTO Pasutijumi(Pasutijuma_id, Pasutijuma_summa, Pasutijuma_datums)

VALUES (15001, 150.5, '2018-10-05')
INSERT INTO Pasutijumi(Pasutijuma_id, Pasutijuma_summa, Pasutijuma_datums)
VALUES (15002, 270.65, '2018-09-10')
INSERT INTO Pasutijumi(Pasutijuma_id, Pasutijuma_summa, Pasutijuma_datums)
VALUES (16000, 65.26, '2018-10-05')
INSERT INTO Pasutijumi(Pasutijuma_id, Pasutijuma_summa, Pasutijuma_datums)
VALUES (16005, 110.5, '2018-08-17')
INSERT INTO Pasutijumi(Pasutijuma_id, Pasutijuma_summa, Pasutijuma_datums)
VALUES (17000, 948.5, '2018-09-10')


SELECT * FROM Pasutijumi
ORDER BY Pasutijuma_summa DESC

SELECT * FROM Pasutijumi
WHERE Pasutijuma_summa > 150

SELECT * FROM Pasutijumi
WHERE Pasutijuma_datums LIKE '2018-10%'

INSERT INTO Pasutijumi(Pasutijuma_id)
VALUES(18000)

UPDATE Pasutijumi
SET Pasutijuma_summa = 1000
WHERE Pasutijuma_id = 17000

DELETE FROM Pasutijumi
WHERE Pasutijuma_id = 18000
DROP TABLE Klienti
CREATE TABLE Klienti(
Klienta_id INT,
Klienta_vards NVARCHAR(50),
Klienta_uzvards NVARCHAR(50)
)
INSERT INTO Klienti(Klienta_id, Klienta_vards, Klienta_uzvards)
VALUES(10000, 'John', 'Smith')
INSERT INTO Klienti(Klienta_id, Klienta_vards, Klienta_uzvards)
VALUES(11000, 'Kate', 'Miller')


ALTER TABLE Pasutijumi
ADD  Pasutijuma_klienta_id INT


UPDATE Pasutijumi
SET Pasutijuma_klienta_id = 10000
WHERE Pasutijuma_id = 15002

UPDATE Pasutijumi
SET Pasutijuma_klienta_id = 10000
WHERE Pasutijuma_id = 15001

UPDATE Pasutijumi
SET Pasutijuma_klienta_id = 11000
WHERE Pasutijuma_id = 16000

UPDATE Pasutijumi
SET Pasutijuma_klienta_id = 10000
WHERE Pasutijuma_id = 16005

UPDATE Pasutijumi
SET Pasutijuma_klienta_id = 11000
WHERE Pasutijuma_id = 17000

SELECT * FROM Pasutijumi
SELECT * FROM Klienti

SELECT o.* From Pasutijumi o, Klienti u
where o.Pasutijuma_klienta_id = u.Klienta_id

SELECT o.* From Pasutijumi o, Klienti u
where o.Pasutijuma_klienta_id = u.Klienta_id
AND Klienta_vards = 'John'
AND Klienta_uzvards = 'Smith'

SELECT SUM(Pasutijuma_summa) From Pasutijumi o, Klienti u
where o.Pasutijuma_klienta_id = u.Klienta_id
AND Klienta_vards = 'Kate'
AND Klienta_uzvards = 'Miller'


SELECT TOP 2  o.* From Pasutijumi o, Klienti u 

where o.Pasutijuma_klienta_id = u.Klienta_id

AND Klienta_vards = 'John'
ORDER BY Pasutijuma_datums DESC  








