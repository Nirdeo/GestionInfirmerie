-- Indique la BDD à utiliser et dans laquelle on exécute les requêtes
USE BD_Infirmerie;
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Utilisateur
    (Login_utilisateur, Mdp_utilisateur)
VALUES
    ('Mana', 'gfdfgh852'),
    ('Belo', 'dfvbgf512pkj'),
    ('Era', 'df55lkjbkj8'),
    ('Eger', 'a865fgfd'),
    ('Ledr', 'gfd852rd'),
    ('Merco', 'fe47fdfg'),
    ('Perge', 'fd85fredf'),
    ('Kergi', 'gfdcrf74'),
    ('Drivo', '86redgd'),
    ('Nami', '95eserty');
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Medicament
    (Libelle_medicament)
VALUES
    ('Doliprane'),
    ('Toplexil'),
    ('Advil'),
    ('Efferalgan'),
    ('Gaviscon'),
    ('Spasfon'),
    ('Spedifen'),
    ('Kardegic'),
    ('Dafalgan'),
    ('Maxilase');
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Classe
    (Libelle_classe)
VALUES
    ('Seconde 1'),
    ('Seconde 2'),
    ('Seconde 3'),
    ('Première 1'),
    ('Première 2'),
    ('Première 3'),
    ('Terminale 1'),
    ('Terminale 2'),
    ('Terminale 3'),
    ('BTS 1');
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Eleve
    (Nom_eleve, Prenom_eleve, Date_de_naissance_eleve, Telephone_eleve, Telephone_parent_eleve, Tiers_temps_eleve, Commentaire_sante_eleve, Id_classe_eleve)
VALUES
    ('Dama', 'Thomas', '2005-11-20', 0784251498, 0687951236, 1, 'Allergie', 10),
    ('Charles', 'Jean', '2008-04-23', 0778536915, 0674862536, 0, 'RAS', 1),
    ('Malo', 'Kevin', '2005-12-15', 0754693214, 0678514787, 0, 'RAS', 9),
    ('Imane', 'Louise', '2006-01-05', 0758147845, 0674683245, 0, 'RAS', 8),
    ('Urule', 'Sebastien', '2007-08-15', 0745989278, 0678215324, 0, 'RAS', 3),
    ('Ali', 'Georges', '2005-10-09', 0747568958, 0678423687, 0, 'RAS', 7),
    ('Jeanne', 'Marie', '2006-11-14', 0747853658, 0678542694, 0, 'RAS', 6),
    ('David', 'Louis', '2007-06-12', 0778146978, 0684741538, 0, 'RAS', 4),
    ('Bernier', 'Marc', '2008-07-14', 0736157854, 0689574536, 0, 'RAS', 2),
    ('Landi', 'Claude', '2006-07-12', 0775146598, 0678654852, 1, 'Allergie', 5);
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Visite
    (Date_visite, Heure_debut_visite, Heure_fin_visite, Motif_visite, Commentaire_visite, Suite_visite, Parents_prevenus_visite, Id_eleve_visite)
VALUES
    ('2021-09-08', '08:30:00', '08:50:00', 'Mal de tête', 'Température élevée', 'Hôpital', 1, 1),
    ('2021-09-12', '09:25:00', '09:30:00', 'Mal de dos', 'RAS', 'Rentre chez lui', 0, 2),
    ('2021-09-14', '10:20:00', '10:40:00', 'Rhume', 'RAS', 'Rentre chez lui', 1, 3),
    ('2021-09-26', '11:30:00', '11:35:00', 'Mal de dos', 'RAS', 'Rentre chez lui', 0, 4),
    ('2021-10-02', '12:25:00', '12:27:00', 'Mal de dos', 'RAS', 'Rentre chez lui', 0, 5),
    ('2021-10-04', '13:45:00', '13:48:00', 'Chute', 'RAS', 'Hôpital', 1, 6),
    ('2021-10-16', '14:40:00', '14:55:00', 'Mal de ventre', 'RAS', 'Rentre chez lui', 0, 7),
    ('2021-10-28', '15:35:00', '15:50:00', 'Mal de ventre', 'Gastro', 'Hôpital', 1, 8),
    ('2021-11-05', '16:30:00', '16:40:00', 'Mal de ventre', 'Gastro', 'Hôpital', 1, 9),
    ('2021-11-10', '17:25:00', '17:30:00', 'Mal de gorge', 'Toux', 'Rentre chez lui', 0, 10);
GO
-- Insertion de données dans la table comme jeu d'essai
INSERT INTO T_Quantite_Medic
    (Id_visite_quantite_medic, Id_medicament_quantite_medic, Quantite_medic)
VALUES
    (1, 1, 15),
    (2, 4, 05),
    (3, 1, 05),
    (4, 4, 05),
    (5, 4, 05),
    (6, 4, 15),
    (7, 6, 05),
    (8, 5, 20),
    (9, 5, 20),
    (10, 10, 10);
GO