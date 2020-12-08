IF OBJECT_ID('Yritykset', 'U') IS NOT NULL
DROP TABLE Yritykset
GO
CREATE TABLE Yritykset (
	Yritykset_tunnus INT NOT NULL PRIMARY KEY IDENTITY,
	Nimi [VARCHAR](50) NOT NULL
);

IF OBJECT_ID('Testit', 'U') IS NOT NULL
DROP TABLE Testit
GO
CREATE TABLE Testit (
	Testit_tunnus INT NOT NULL PRIMARY KEY,
	Kysymys1 [VARCHAR](128) NOT NULL,
	Kysymys2 [VARCHAR](128) NOT NULL
);

IF OBJECT_ID('Yritykset_testit', 'U') IS NOT NULL
DROP TABLE Yritykset_testit
GO
CREATE TABLE Yritykset_testit (
	Yritykset_testit_tunnus INT NOT NULL PRIMARY KEY IDENTITY,
	Yritykset_tunnus INT NOT NULL FOREIGN KEY REFERENCES Yritykset(Yritykset_tunnus),
	Testit_tunnus INT NOT NULL FOREIGN KEY REFERENCES Testit(Testit_tunnus)
);

IF OBJECT_ID('Vastaukset', 'U') IS NOT NULL
DROP TABLE Vastaukset
GO
CREATE TABLE Vastaukset (
	Yritykset_testit_tunnus INT NOT NULL FOREIGN KEY REFERENCES Yritykset_testit(Yritykset_testit_tunnus),
	Vastaus1 INT NOT NULL,
	Vastaus2 INT NOT NULL
);
