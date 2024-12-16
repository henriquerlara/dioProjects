CREATE DATABASE MoviesDB;
\c MoviesDB;

CREATE TABLE Actors (
    Id SERIAL PRIMARY KEY,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Gender VARCHAR(1) NOT NULL
);

CREATE TABLE Movies (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    ReleaseYear INT,
    Duration INT
);

CREATE TABLE Genres (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(20) NOT NULL
);

CREATE TABLE MovieCast (
    Id SERIAL PRIMARY KEY,
    ActorId INT NOT NULL,
    MovieId INT NOT NULL,
    Role VARCHAR(30)
);

CREATE TABLE MoviesGenres (
    Id SERIAL PRIMARY KEY,
    GenreId INT NOT NULL,
    MovieId INT NOT NULL
);

INSERT INTO Actors (FirstName, LastName, Gender) VALUES
('James', 'Stewart', 'M'),
('Deborah', 'Kerr', 'F'),
('Peter', 'OToole', 'M'),
('Robert', 'DeNiro', 'M'),
('Harrison', 'Ford', 'M'),
('Stephen', 'Baldwin', 'M'),
('Jack', 'Nicholson', 'M'),
('Mark', 'Wahlberg', 'M'),
('Woody', 'Allen', 'M'),
('Claire', 'Danes', 'F'),
('Tim', 'Robbins', 'M'),
('Kevin', 'Spacey', 'M'),
('Kate', 'Winslet', 'F'),
('Robin', 'Williams', 'M'),
('Jon', 'Voight', 'M'),
('Ewan', 'McGregor', 'M'),
('Christian', 'Bale', 'M'),
('Maggie', 'Gyllenhaal', 'F'),
('Dev', 'Patel', 'M'),
('Sigourney', 'Weaver', 'F'),
('David', 'Aston', 'M'),
('Ali', 'Astin', 'F');

INSERT INTO Movies (Name, ReleaseYear, Duration) VALUES
('Vertigo', 1958, 128),
('The Innocents', 1961, 100),
('Lawrence of Arabia', 1962, 216),
('The Deer Hunter', 1978, 183),
('Amadeus', 1984, 160),
('Blade Runner', 1982, 117),
('Eyes Wide Shut', 1999, 159),
('The Usual Suspects', 1995, 106),
('Chinatown', 1974, 130),
('Boogie Nights', 1997, 155),
('Annie Hall', 1977, 93),
('Princess Mononoke', 1997, 134),
('The Shawshank Redemption', 1994, 142),
('American Beauty', 1999, 122),
('Titanic', 1997, 194),
('Good Will Hunting', 1997, 126),
('Deliverance', 1972, 109),
('Trainspotting', 1996, 94),
('The Prestige', 2006, 130),
('Donnie Darko', 2001, 113),
('Slumdog Millionaire', 2008, 120),
('Aliens', 1986, 137),
('Beyond the Sea', 2004, 118),
('Avatar', 2009, 162),
('Braveheart', 1995, 178),
('Seven Samurai', 1954, 207),
('Spirited Away', 2001, 125),
('Back to the Future', 1985, 116);

INSERT INTO Genres (Name) VALUES
('Action'),
('Adventure'),
('Animation'),
('Biography'),
('Comedy'),
('Crime'),
('Drama'),
('Horror'),
('Musical'),
('Mystery'),
('Romance'),
('Thriller'),
('War');

INSERT INTO MovieCast (ActorId, MovieId, Role) VALUES
(1, 1, 'John Scottie Ferguson'),
(2, 2, 'Miss Giddens'),
(3, 3, 'T.E. Lawrence'),
(4, 4, 'Michael'),
(5, 6, 'Rick Deckard'),
(6, 8, 'McManus'),
(7, 10, 'Eddie Adams'),
(8, 11, 'Alvy Singer'),
(9, 12, 'San'),
(10, 13, 'Andy Dufresne'),
(11, 14, 'Lester Burnham'),
(12, 15, 'Rose DeWitt Bukater'),
(13, 16, 'Sean Maguire'),
(14, 17, 'Ed'),
(15, 18, 'Renton'),
(16, 20, 'Elizabeth Darko'),
(17, 21, 'Older Jamal'),
(18, 22, 'Ripley'),
(19, 23, 'Bobby Darin'),
(20, 9, 'J.J. Gittes'),
(21, 19, 'Alfred Borden');

INSERT INTO MoviesGenres (GenreId, MovieId) VALUES
(1, 22),
(2, 17),
(2, 3),
(3, 12),
(5, 11),
(6, 8),
(6, 13),
(7, 26),
(7, 28),
(7, 18),
(7, 21),
(8, 2),
(9, 23),
(10, 7),
(10, 27),
(10, 1),
(11, 14),
(12, 6),
(13, 4);

ALTER TABLE MovieCast
ADD CONSTRAINT FK_MovieCast_Actor FOREIGN KEY (ActorId) REFERENCES Actors(Id) ON DELETE CASCADE;

ALTER TABLE MovieCast
ADD CONSTRAINT FK_MovieCast_Movie FOREIGN KEY (MovieId) REFERENCES Movies(Id) ON DELETE CASCADE;

ALTER TABLE MoviesGenres
ADD CONSTRAINT FK_MoviesGenres_Genre FOREIGN KEY (GenreId) REFERENCES Genres(Id) ON DELETE CASCADE;

ALTER TABLE MoviesGenres
ADD CONSTRAINT FK_MoviesGenres_Movie FOREIGN KEY (MovieId) REFERENCES Movies(Id) ON DELETE CASCADE;
