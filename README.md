# Défi GPS
Avec mon addiction sévère aux événements C#,, voici mon implémentation des différentes parties d'un GPSosoid
mon implémentation permet de facilement ajouter et de connecter des modules/systèmes externes au système GPS. J'ai décidé de prendre l'approche du contrôleur, qui relie les différentes composantes d'un système et agit en tant que porte d'entrée d'un système.
1 Émétteur -> Controlleur -> N receveurs 

[Utilisation du système GPS] (Defi_GPS/Programme. c)

#### Avantages
- Facilité d'implémentation
- Séparation complète entre les modules
- Utilisation d'un type de données Typé (struct GPSData)
- Composante contrôleur qui connecte les différentes parties du système
  - Peu importe le nombre de modules attachés au GPS, il agit en tant que chef d'orchestre
- Basé à 100 % sur les événements et threadsafe graçe à nos amis les " ?" :)
- Décomposition solide des fonctionnalités des modules

#### Désavantages
- GPSData doit contenir les informations du système le plus complexe 
  - Les champs non utilisés par un émetteur plus primitif seront nuls, donc doivent être gérés par des récepteurs avancés
  - Un récepteur plus primitif recevra des données inutiles (meh)
