# Bureau de change de devises international

Application Windows Forms en C# qui permet de convertir un montant d'une devise étrangère vers le dollar canadien (CAD), et inversement. Les informations sur les pays sont gérées dans un fichier texte.

## Fonctionnalités

- Sélection d'un pays dans une liste pour afficher sa monnaie et sa valeur par rapport au dollar canadien
- Choix du sens de conversion : devise vers dollar canadien, ou dollar canadien vers devise
- Saisie d'un montant et calcul de la conversion
- Gestion des pays : ajouter, supprimer, éditer, enregistrer et annuler
- Lecture et écriture des données dans un fichier texte

## Les formulaires

| Formulaire | Rôle |
|---|---|
| `frmPrincipal` | Formulaire MDI avec la barre de menu : Programmes, Projets (Bureau de change, Gestion des pays), Bonus et Quitter. Il contient tous les autres formulaires. |
| `frmChange` | Programme principal de conversion. Une liste déroulante affiche les pays, puis les informations de la devise choisie et le montant converti. |
| `frmAdmin` | Administration des pays (nom, devise, valeur). Une liste est remplie au démarrage avec les pays du fichier. Les informations du pays sélectionné s'affichent dans des zones de texte, avec les boutons Ajouter, Supprimer, Éditer, Enregistrer et Annuler. |

## Structure du code

Le projet utilise la programmation orientée objet avec trois classes.

### `clsBureau`
- Propriétés : `Numero`, `Nom`, `Adresse`, `Pays` (collection `List<clsPays>`), `Statut`
- Méthodes : `Creer`, `TrouverPays`, `Afficher`, `Fermer`
- `TrouverPays` cherche un pays dans la collection et renvoie `null` s'il n'est pas trouvé.

### `clsPays`
- Propriétés : `Nom`, `Monnaie`, `Valeur`
- Méthodes : `Creer`, `GetValeurCanada`, `Afficher`
- `GetValeurCanada` calcule la valeur de la monnaie par rapport au dollar canadien.

### `clsSourceDeDonnees`
- `GetTousLesPays` : ouvre le fichier texte, lit son contenu et renvoie la collection de pays.
- `SaveTousLesPays` : écrit le contenu de la collection dans le fichier texte.

## Technologies

- C#
- Windows Forms (WinForms), formulaires MDI
- Programmation orientée objet
- Collections génériques (`List<T>`)
- Lecture et écriture de fichiers texte

## Lancer le projet

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/AymaneNa/NOM_DU_DEPOT.git
   ```
2. Ouvrir le fichier `.sln` avec Visual Studio.
3. Compiler et exécuter le projet (touche `F5`).

> Remplacez `NOM_DU_DEPOT` par le nom de votre dépôt.

## Auteur

**Aymane** (GitHub : [AymaneNa](https://github.com/AymaneNa))
DEC en programmation, Collège LaSalle

## Contexte

Projet de fin de session réalisé dans un cadre académique.
