API_CaseV1


Gebruik gemaakt van:

Web API .net 6 versie
Sqlite DB brower (https://sqlitebrowser.org/)
Github
Visual studio 2022

Instructie:
Start Visual studio 2022
- Onder Get Started selecteer Clone a repository aan
- In Repository location veld plaats je de https link van  github (https://github.com/achrafkajdouh/API_CaseV1.git)
- Selecteer API_CaseV1.sln aan om het project in te laden
- ctrl + F5 om applicatie te starten

Deel 1

Bij het genereren van een algemene web api is gebruik gemaakt van sqlite en entityframework core en swagger, daarbij zijn de ondersteunende packages gebruikt om de interacties mogelijk te maken.

De reden voor entityframework core is om gemakkelijk een model en context bestand te kunnen vertalen naar een database.

In de context bestand (DBinteractor.cs)is de koppeling gemaakt met sqlite om een sqlite database bestand te kunnen genereren, ook staat in het bestand seed data om de table mee op te vullen.

Doormiddel van Package Manager Console heb ik de migration bestand aangemaakt om de database waardes te kunnen genereren, hierop volgend heb ik een database update command gebruikt om de gegenereerde data te kunnen gebruiken en die terug te zien op swagger bij het opstarten van de applicatie, ook word er een sqlite.db bestand aangemaakt als de database update is uitgevoerd.

Vervolgens heb ik doormiddel van Scaffold een API Controller gegenereerd met als invoer adressen.cs (model) en DBInteractor.cs (context).


Ervaring

Positief:
- Het leren en gebruik maken van sqlite wat ik nog niet eerder heb gedaan.
- Web api in elkaar zetten in combinatie met entity framework core en sqlite
- Het navigeren van swagger wat ik nog niet eerder heb gedaan.
- Web api maken in het algemeen (Niet vaak gedaan).

Negatief:
- Geschatte tijd dat ik hiervoor zou nodig hebben heb ik onderschat, had verwacht dat dit korter zou zijn.
- Enige complicaties met het exporteren van de api gegevens naar github, oorzaak bleek doordat het email op prive stond en kon ik via visual studio niet me data committen en pushen,oplossing was email publiekelijk open stellen waardoor de verbinding gemaakt kon worden.




Deel 2





