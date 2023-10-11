INSERT INTO `utilisateur` (`util_id`, `util_identifiant`, `util_mdp`, `util_question`, `util_reponse`) VALUES
(1, 'master', 'secret', 0, 'louis'),
(2, 'Agathe', 'B6KNgmUnu0AVa', 3, 'favier'),
(3, 'Delphine', 'Rousseau', 1, 'grave'),
(4, 'Charlotte', 'Rousseau', 1, 'C\'est mon dernier mot');

INSERT INTO `categorie` (`cate_id`, `cate_nom`) VALUES
(1, 'Administratif'),
(2, 'Réseaux sociaux'),
(3, 'Scolarité'),
(4, 'Wifi'),
(5, 'Jeux_ordinateur'),
(6, 'streaming');

INSERT INTO `appartenance` (`appartenance_id`, `util_id`, `cate_id`) VALUES
(2, 1, 2),
(3, 1, 3),
(4, 2, 1),
(5, 2, 2),
(6, 2, 3),
(7, 2, 4),
(8, 2, 5),
(9, 4, 6),
(10, 4, 1),
(11, 4, 2),
(12, 4, 3),
(13, 4, 4);

INSERT INTO `compte` (`compte_id`, `compte_titre`, `compte_mdp`, `compte_identifiant`, `compte_force`, `compte_date`, `compte_site`, `cate_id`, `util_id`) VALUES
(1, 'CAS', 'ceciEsts2cur!se', 'glog', 3, '2017-11-20', 'ade.bordeaux-inp.fr', NULL, 1),
(2, 'FB', 'non', 'progav', 1, '2017-11-21', 'facebook.com', 2, 1),
(3, 'Twitter', 'Niveau2*-*', 'pro', 2, '2015-11-22', 'twitter.com', 2, 1),
(4, 'Bdx inp', 'superMot_de_Passe', 'arousseau009@ensc.fr', 3, '2017-12-21', 'ensc.fr', 1, 2),
(5, 'Lol', 'warrior1996!', 'Athena', 2, '2017-12-21', 'lol.fr', 5, 2),
(6, 'Halo', 'warrior1996!', 'Spartan', 2, '2017-12-21', 'halo.com', 5, 2),
(7, 'Facebook', 'pietre1996', 'Agathe', 1, '2017-12-21', 'facebook.com', 2, 2),
(8, 'Unity', '2\\2x{aoqE#_', 'Rousse', 2, '2017-12-21', '', 3, 2),
(9, 'SFR_Phone', 'J9[R8s`u<Pq%O', '54352885', 3, '2017-12-21', '', 4, 2),
(10, 'Mincraft', 'faible', 'bloc', 1, '2017-12-21', 'Craft.fr', 5, 2),
(11, 'Film', 'Bete', 'Belle', 1, '2017-12-21', 'bellebete.com', 6, 3);