-- Exercise 1: Retrieve the name and year of all movies.
SELECT Name, ReleaseYear
FROM Movies;

-- Exercise 2: Retrieve the name and year of all movies, ordered by year in ascending order.
SELECT Name, ReleaseYear
FROM Movies
ORDER BY ReleaseYear ASC;

-- Exercise 3: Retrieve the name, year, and duration of the movie "Back to the Future."
SELECT Name, ReleaseYear, Duration
FROM Movies
WHERE Name = 'Back to the Future';

-- Exercise 4: Retrieve all movies released in 1997.
SELECT Name, ReleaseYear
FROM Movies
WHERE ReleaseYear = 1997;

-- Exercise 5: Retrieve all movies released after the year 2000.
SELECT Name, ReleaseYear
FROM Movies
WHERE ReleaseYear > 2000;

-- Exercise 6: Retrieve all movies with a duration greater than 100 and less than 150, ordered by duration in ascending order.
SELECT Name, Duration
FROM Movies
WHERE Duration > 100 AND Duration < 150
ORDER BY Duration ASC;

-- Exercise 7: Retrieve the number of movies released per year, grouped by year, ordered by year in descending order.
SELECT ReleaseYear, COUNT(*) AS MovieCount
FROM Movies
GROUP BY ReleaseYear
ORDER BY ReleaseYear DESC;

-- Exercise 8: Retrieve the first and last names of all male actors.
SELECT FirstName, LastName
FROM Actors
WHERE Gender = 'M';

-- Exercise 9: Retrieve the first and last names of all female actors, ordered by first name.
SELECT FirstName, LastName
FROM Actors
WHERE Gender = 'F'
ORDER BY FirstName ASC;

-- Exercise 10: Retrieve the name of the movie and its genre.
SELECT Movies.Name AS MovieName, Genres.Name AS GenreName
FROM Movies
JOIN MoviesGenres ON Movies.Id = MoviesGenres.MovieId
JOIN Genres ON Genres.Id = MoviesGenres.GenreId;

-- Exercise 11: Retrieve the name of the movie and its genre for the genre "Mystery."
SELECT Movies.Name AS MovieName, Genres.Name AS GenreName
FROM Movies
JOIN MoviesGenres ON Movies.Id = MoviesGenres.MovieId
JOIN Genres ON Genres.Id = MoviesGenres.GenreId
WHERE Genres.Name = 'Mystery';

-- Exercise 12: Retrieve the name of the movie and the actors, including their first name, last name, and role.
SELECT Movies.Name AS MovieName, Actors.FirstName, Actors.LastName, MovieCast.Role
FROM Movies
JOIN MovieCast ON Movies.Id = MovieCast.MovieId
JOIN Actors ON Actors.Id = MovieCast.ActorId;
