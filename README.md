## Table des matières
1. [Fonctionnaités](#fonctionnalités)
2. [Table SQL](#table)
3. [Select](#select)
4. [Insert](#insert)
4. [Delete](#delete)
4. [Update](#update)
## Fonctionnalités

Voici une application WinForm, permettant de gerer une bibliothèque de jeux.

#### Elle répond aux fonctionnalités suivantes :

1. Implémenter une DataGridView affichant les informations suivantes :
- Titre du jeu
- Genre (Action, RPG, Sport, etc.)
- Année de sortie
- Prix
- Statut (Disponible, Prêté, Vendu)
2. Créer un formulaire d'ajout de nouveau jeu
3. Permettre la modification d'un jeu en cliquant sur une colonne dédiée
4. Permettre la suppression d'un jeu avec confirmation
5. Sauvegarder les données dans une base de données locale (fichier .mdf)

## Table
La table "Jeu" permet de stocker les données des jeux envoyé dans la table grace à un formulaire qui soumet des requetes d'insertion dans la table.
```
CREATE TABLE Jeux
(
id INT PRIMARY KEY IDENTITY, 
titre NVARCHAR(200),
genre NVARCHAR(200),
anneeSortie NVARCHAR(4),
prix NVARCHAR(200),
statut NVARCHAR(200)
)
```
#### SELECT
Cette requete est utilisée afin de récupererles données présente dans la table Jeu, par exemple pour pouvoir ensuite les afficher dans une DataGridView. 
```
SELECT * FROM Jeux
```
#### INSERT
Cette requete est utilisée pour insérer des données dans la table Jeu, dans les colonnes précisées, cela se fait grace à l'envoie d'un formulaire dans lequel les infos du jeu sont renseignée
```
INSERT INTO Jeux (titre, genre, anneeSortie, prix, statut) VALUES(@titre, @genre, @anneeSortie, @prix, @statut);
```
#### DELETE
Cette requete est utilisée pour supprimer des données dans la table Jeu, grace à un bouton "supprimer", qui, lorsqu'il est cliqué, cible l'id de la ligne correspondant, et la supprime.
```
DELETE FROM Jeux WHERE ID=@id;
```
#### UPDATE
Cette requete est utilisée pour mettre à jour la table "Jeu", qui, grace à un bouton ouvre un nouveau formulaire qui contient des nouveaux champs et grace à un boutton soumet le nouveau formulaire et met à jour la ligne sélectionnée.
```
UPDATE Jeux SET titre = @titre, genre = @genre, anneeSortie = @anneeSortie, prix = @prix, statut = @statut WHERE ID=@id;
```
