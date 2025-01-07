/* Créer un utilisateur */
CREATE USER 'toto'@'localhost' IDENTIFIED BY 'azer';

/* Accorder TOUS les privilèges à toto sur la base de données rezo_social */
GRANT ALL PRIVILEGES ON rezo_social.* TO 'toto'@'localhost';

/* Recharger les privilèges au niveau du serveur */
FLUSH PRIVILEGES;