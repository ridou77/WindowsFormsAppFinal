CREATE TABLE Jeux
(
id INT PRIMARY KEY IDENTITY, 
titre NVARCHAR(200),
genre NVARCHAR(200),
anneeSortie NVARCHAR(4),
prix NVARCHAR(200),
statut NVARCHAR(200)
)

SELECT * FROM Jeux

DELETE FROM Jeux WHERE ID=@id;

INSERT INTO Jeux (titre, genre, anneeSortie, prix, statut) VALUES(@titre, @genre, @anneeSortie, @prix, @statut);

UPDATE Jeux SET titre = @titre, genre = @genre, anneeSortie = @anneeSortie, prix = @prix, statut = @statut WHERE ID=@id;