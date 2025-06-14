"# crud_C#" 
# 🚗 Voiture Management System (CRUD - WinForms)

Un petit projet CRUD (Create, Read, Update, Delete) en C# avec Windows Forms et SQL Server pour gérer une liste de voitures.

## 📂 Structure du projet

- **crud.Models.Voiture.cs** : classe modèle représentant une voiture.
- **crud.Data.VoitureDb.cs** : classe de gestion des opérations SQL (GetAll, Add, Update, Delete).
- **Form1.cs** : interface utilisateur principale avec un `DataGridView`, des `TextBox`, et des boutons pour les opérations CRUD.

## 🧰 Technologies utilisées

- 👨‍💻 **Langage** : C# (.NET Framework)
- 🖼 **Interface** : Windows Forms
- 🗃 **Base de données** : SQL Server (LocalDB)
- 📦 **IDE recommandé** : Visual Studio

## 🛠 Configuration

1. **Base de données SQL Server**

   Crée la base de données `VoitureDB` et exécute cette requête pour la table :

   ```sql
   CREATE TABLE [dbo].[Voitures] (
       [Id] INT IDENTITY(1,1) PRIMARY KEY,
       [Numero] NCHAR(10) NOT NULL,
       [Marque] NCHAR(50) NOT NULL,
       [Modele] NCHAR(100) NULL
   );

