## Les objectifs pédagogiques
#### Objectif pédagogique général :
 
L'émergence de la randonnée dans une période d'industrialisation repose sur les actions entreprises par l'Etat en matière de développement d'installations, d'aménagement et d'appropriation des territoires.
 
### Descriptions des objectifs pédagogiques 
 
Notre jeu permettra aux joueurs d'apprendre à développer la randonnée dans un pays le plus efficacement possible. Cette course à l'aménagement sera gagnée par la personne qui aura compris le plus rapidement comment exploiter chaque ressource au mieux. Chaque ressource aura un impact sur la venue des randonneurs et permettra de comprendre l'importance ou l'insignifiance de chaque action.

Notre jeu vise à sensibiliser sur trois points soulevés par notre tutrice :
1. l'émergence de la randonnée et l'industrialisation, qui plus est rapide, sont intrinsèquement liées (équipement, chemins de fer) ;
2. la randonnée a servi a des fins politiques ;
3. les conditions étaient réunies pour que ce soit le Reich allemand qui soit pionnier en matière de randonnée.
 
## Description du jeu 
 
**Type de jeu :**  Jeu de gestion multijoueur
 
**Incarnation du joueur :** Chaque joueur incarnera un ministre, ils devront aménager au mieux leur territoire pour gagner d'avantages de terre et amener de plus en plus de randonneurs dans sa province.
 
**Description d'une partie :**
Les joueurs devront choisir une case dans laquelle ils pourront réaliser une tâche à acheter (créer un club, construire un chemin...). Cette tâche va influencer le nombre de randonneurs qui viennent. Si ce nombre atteint 50,le joueur remporte la partie. 
 
**Paramétrage d'une partie :** <br>
Nombre de cases. <br>
Objectifs.

**Fonctionnalités permettant d'appréhender les objectifs pédagogiques :**
1. le joueur comprendra que construire des usines et des chemins de fer favoriseront grandement l'expansion de son influence dans les montagnes (construction plus rapide d'infrastructure, plus grande affluence de randonneurs)
2. à travers une "zone d'influence" dans les montagnes, et l'usage de propagande, le joueur, incarnant une nation (Allemagne, France, Suisse, Autriche, Italie), comprendra les enjeux politiques autour de la randonnée
3. via le mode multijoueur, les joueurs comprendront que l'Allemagne (très rapide industrialisation, très grande population, fort sentiment national) est de loin la nation la plus prédisposée à gagner la partie.
 
## Modèle conceptuel applicatif 
 
**Région :** Parcelle du jeu que les joueurs vont essayer d'améliorer
> nombre de randonneurs : _nombre de randonneurs se déplaçant dans la région._<br>
> case : _le territoire est divisé en cases qu'on améliore une par une._ 
 
**Action :** Action que les joueurs utilisent pour faire évoluer sa région <br>
 
Liste des actions : 
> _Construction de refuges_<br>
> _Création de clubs de randonneurs_<br>
> _Construction de chemins de fer_<br>
> _Création de chemins_<br>
> _Améliorer les usines_<br>
>_Choix de la case que l'on veut améliorer (en cliquant dessus)_
 
 
## Description des fonctionnalités
 
**ENTREES**  
 
**Au démarrage**

![Menu](https://cdn.discordapp.com/attachments/707554098492342274/826705403546566667/unknown.png)


- Jouer : _commencer une partie_
- Aide : _explication du principe du jeu et des composants de l'écran de la partie._
- Quitter : _ferme la fenêtre de jeu_


 
**Pendant la partie**

![FormJeu](https://cdn.discordapp.com/attachments/707554098492342274/826703451014299678/unknown.png)


 - Construction de refuges
 - Création de clubs de randonneurs
 - Construction de chemins de fer
 - Création de chemins
 - Améliorer les usines
 - Choix de la case que l'on veut améliorer (en cliquant dessus)
 
**SORTIE**  
 
**Pendant la partie**
 - Liste des entrées
 - Nombre de randonneurs sur le territoire
 - Superficie aménagée du territoire
 - Argent
 - Positionnement des éléments sur les cases 
 
 **Dans le menu aide**
 - Contexte historique : _explication de contexte_
 - Construction : _explication de chaque bouton proposé sur la fenêtre de jeu_
 - Comment gagner : _explication des règles et aide_
 
  **Dans le menu fin**
  - Joueur gagnant
  - Quitter
 
 
**Moteur interne :** <br>
Chaque action de la liste d'entrée sera accessible par un bouton dans un menu en bas de la fenêtre. <br>
Le nombre de randonneurs de chaque joueur sera affiché en bleu ou en rouge en haut de la fenêtre.<br>
Les joueurs doivent cliquer sur la case où ils veulent faire leur action puis sur l'action choisie.
 
 
 **GESTION DE L'ARGENT :** 
 - Une usine rapporte 10 Marks par tour
 - Un refuge rapporte 5 Marks par tour
 - A la fin de chaque tour, les joueurs reçoivent 10 Marks
 - La construction d'un refuge coûte 30 Marks, puis 35 au bout de 10 tours
 - La création d'un club coûte 35 Marks, puis 40 au bout de 10 tours
 - La construction d'une usine coûte 100 Marks
 - La création d'un chemin coûte 10 Marks
 - La construction d'un chemin de fer coûte 15 Marks
 - Le joueur commence sa partie avec 50 Marks
 
 
 
## Scénarios 
 
- Paramètres : 
DÉPART : 50 Marks
tous les 5 chemins :  +1 marcheurs
tous les 5 clubs :  +2 marcheurs

 
>**Déroulement avec un joueur gagnant et un perdant : 
 
TOUR 1 <br>
Création d’un train <br>
0 randonneurs <br>
50 - 15 + 10 Marks reste : 45 <br>


Création d’un train <br>
0 randonneurs <br>
50 - 15 + 10 Marks reste : 45 <br>

TOUR 2 <br>
Création d’un refuge <br>
3 randonneurs <br>
45 - 30 +10 +5 Marks reste 30 <br>


Création d’un chemin <br>
2 randonneurs <br>
45 - 10 + 10  Marks reste : 45 <br>

TOUR 3
Création d’un chemin <br>
5 randonneurs <br>
30 - 10 + 10 + 5 Marks reste 35 <br>


Création d’un club <br>
8 randonneurs <br>
45 - 35 +10 Marks reste 20 <br>

TOUR 4
Création d’un refuge <br>
8 randonneurs <br>
35 - 30 + 10 + 5 + 5 Marks reste 25 <br>


Création d’un chemin <br>
10 randonneurs <br>
20 - 10 + 10 Marks reste 20 <br>


TOUR 5
Création d’un chemin <br>
10 randonneurs <br>
25 - 10 + 10 + 5 + 5 Marks reste 35 <br>


Création d’un chemin <br>
12 randonneurs <br>
20 - 10 + 10 Marks reste 20 <br>

TOUR 6
Création d’un club <br>
16 randonneurs <br>
35 - 35 + 10 + 5 + 5 Marks reste 20 <br>


Création d’un chemin <br>
14 randonneurs <br>
20 - 10 + 10 Marks reste 20 <br>

TOUR 7
Création d’un chemin <br>
18 randonneurs <br>
20 - 10 + 10 + 5 + 5 Marks reste 30 <br>


Création d’un chemin <br>
17 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 8
Création d’un refuge<br>
21 randonneurs <br>
30 - 30 + 10 + 5 + 5 + 5 reste 25<br>


Création d’un chemin<br>
20 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>


TOUR 9
Création d’un chemin<br>
23 randonneurs<br>
25 - 10 + 10 + 5 +5 + 5 Marks reste 40<br>


Création d’un chemin <br>
23 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 10
Création d’un refuge<br>
26 randonneurs<br>
40 - 35 + 10 + 5 + 5 + 5 + 5 Marks reste 35<br>


Création d’un chemin <br>
26 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 11
Création d’un chemin<br>
29 randonneurs<br>
35 - 10 + 10 + 5 + 5 + 5 + 5 Marks reste 55<br>


Création d’un chemin <br>
29 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>


TOUR 12
Création d’un club<br>
35 randonneurs<br>
55 - 40 + 10 + 5 + 5 + 5 + 5 Marks reste 45<br>


Création d’un chemin <br>
33 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 13
Création d’un refuge<br>
38 randonneurs<br>
45 - 35 + 10 + 5 + 5 + 5 + 5 + 5 M reste 45<br>


Création d’un chemin<br>
37 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 14
Création d’un chemin<br>
41 randonneurs<br>
45 - 10 + 10 + 5 + 5 + 5 + 5 + 5 M reste 70<br>


Création d’un chemin<br>
41 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 15
Création d’un chemin<br>
43 randonneurs<br>
45 - 10 + 10 + 5 + 5 + 5 + 5 + 5 M reste 70<br>


Création d’un chemin<br>
45 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 16
Création d’un chemin<br>
49 randonneurs<br>
45 - 10 + 10 + 5 + 5 + 5 + 5 + 5 M reste 70<br>


Création d’un chemin<br>
49 randonneurs<br>
20 - 10 + 10 Marks reste 20<br>

TOUR 17
Création d’un chemin<br>
52 randonneurs → Victoire<br>
45 - 10 + 10 + 5 + 5 + 5 + 5 + 5 M reste 70<br>


 ##Fonctionnalités additionnelles 

 Le jeu pourrait être amélioré en terme de difficulté avec niveaux possibles, en permettant au joueur de choisir le nombre de case, l'objectif à atteindre, ala possibilité de jouer à plus de deux joueurs. En matière de code, nous pourrions faire un drag and drop pour déposer l'action dans la case directement. 
 
 
 
 
 
 

