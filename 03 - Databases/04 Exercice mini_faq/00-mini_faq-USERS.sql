/* CREER UN UTILISATEUR */
CREATE USER 'toto'@'localhost' IDENTIFIED BY 'azer';

/* Accorder TOUS les PRIVILEGES à Toto 
sur la base de données rezo_social */
GRANT ALL PRIVILEGES ON mini_faq.* TO 'toto'@'localhost';

/* RECHARGER LES PRIVILEGES au niveau du serveur */
FLUSH PRIVILEGES;
