# kata-wemanity
kata Wemanity

La refactorisation a été faite avec .NET 5.

C'est toujours un application (CsharpCoreRefactor) console, l'ouvrir dans visual studio 2019 (community est gratuit) et lancer l'appli avec la touche "F5".

Pour lancer les test (NUnitCsharpCoreRefactor) : click droit sur le test -> Ctrl+R,T ou ("Executer un ou plusieurs tests").

Je n'ai pas utilisé de base de données pour persister articles pour pouvoir afficher un historique, la propriété "RunDate" aurait tout son sens dans ce cas
,j'aurais créé une table "ExtendedItems" avec les colonnes (Id,Name,Quality,SellIn,Type,RunDate) pour pouvoir gérer une seule mise à jour quotidienne.
