API_CaseV1


Gebruik gemaakt van:

Web API .net 6 versie,
Sqlite DB browser (https://sqlitebrowser.org/),
Github,
Visual studio 2022,
Packages:
- microsoft.entityframeworkcore 6.0.5
- microsoft.entityframeworkcore.Design 6.0.5
- microsoft.entityframeworkcore.Sqlite 6.0.5
- microsoft.entityframeworkcore.SqlServer 6.0.5
- microsoft.entityframeworkcore.Tools 6.0.5
- microsoft.visualstudio.web.codegeneration.design 6.0.5
- swashbuckle.aspnetcore 6.3.0


Instructie:
Start Visual studio 2022
- Onder Get Started selecteer Clone a repository aan
- In Repository location veld plaats je de https link van  github (https://github.com/achrafkajdouh/API_CaseV1.git)
- Selecteer API_CaseV1.sln aan om het project in te laden
- ctrl + F5 om applicatie te starten

Deel 1: API algemeen

Bij het genereren van een algemene web api is gebruik gemaakt van sqlite en entityframework core en swagger, daarbij zijn de ondersteunende packages gebruikt om de interacties mogelijk te maken.

De reden voor entityframework core is om gemakkelijk een model en context bestand te kunnen vertalen naar een database.

In het context bestand (DBinteractor.cs)is de koppeling gemaakt met sqlite om een sqlite database bestand te kunnen genereren, ook staat in het bestand seed data om de table mee op te vullen.

Door middel van Package Manager Console is er een migratie bestand aangemaakt om de database waardes te kunnen genereren, hierop volgend heb ik een database update command gebruikt om de gegenereerde data te kunnen gebruiken en die terug te zien op swagger bij het opstarten van de applicatie, ook wordt er een sqlite.db bestand aangemaakt als de database update is uitgevoerd.

Vervolgens is er door middel van Scaffold een API Controller gegenereerd met als invoer adressen.cs (model) en DBInteractor.cs (context).


Ervaring

Positief:
- Het leren en gebruik maken van sqlite wat ik nog niet eerder heb gedaan.
- Web api in elkaar zetten in combinatie met entity framework core en sqlite.
- Het navigeren van swagger wat ik nog niet eerder heb gedaan.
- Web api maken in het algemeen (Niet vaak gedaan)

Negatief:
- Geschatte tijd dat ik hiervoor zou nodig hebben heb ik onderschat, had verwacht dat dit korter zou zijn.
- Enige complicaties met het exporteren van de api gegevens naar github, oorzaak bleek doordat het email op prive stond en kon ik via visual studio niet me data committen en pushen,oplossing was email publiekelijk open stellen waardoor de verbinding gemaakt kon worden.


Deel 2: Filters

*Niet werkend gekregen*

Gedachte gang

1. Controller aanmaken.
2. Lijst met properties om te sorteren.
3. Switch/case met default asc (Orderby) en anders desc(OrderByDescending)
4. Filter (liep vast op implementeren)

Ervaring

Positief:
- Inzicht in web API filter en sorteer functionaliteit

Negatief:
- Niet werkend gekregen
- Onvoldoende kennis in filter/sorteer functies 


Deel 3: Afstanden

Gebruik gemaakt van:

Database 
- (https://dev.maxmind.com/geoip/geolite2-free-geolocation-data?lang=en)
- package maxmind.geoip2\5.1.0

*Niet werkend gekregen*


Voor Geolocatie API was ik bezig met het volgende.
1. Voeg een nieuwe controller toe gemaakt Geo Controller.cs.
2. In de controller wordt er een functie toegevoegd
	- Haalt de database op
	- Leest het ip adres
	- stuurt een ip adres return terug

Gedachte gang
3. Model aanmaken met gewenste properties.
4. In Geo Controller -> Getcountry functie 
   een nieuwe var aanmaken/class met daarbij de properties van
   de model.
5. GetDistance functie aanmaken onder Geo Controller:
	- Haal locatie A op
	- Haal locatie B op
	- Maak var c met locatie A - B = C


Ervaring

Positief:
- Het doornemen en testen van database properties van geolocatie.
- Inzicht in het maken van eindpunt waardes.
- Werken aan een ander Web API onderdeel.

Negatief:
- Niet werkend gekregen.
- Lastig om de correcte geolocatie data te vinden om dit toe te passen in de API.
- Geschatte tijdsduur.
