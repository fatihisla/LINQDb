# LINQDb
Passi necessari  a creare un programma LINQDb:

* Creare una cartella e nominarla.

* Aprire la cartella con Visual Studio Code,creare un nuovo terminare e trascrivere il comando:
     
       dotnet new console
     
* Adesso aggiungere il file di testo chinook.db tramite questo link:https://www.sqlitetutorial.net/sqlite-sample-database/
* Aggiungere il file nella cartella poi aggiungere se non si ha le estensioni SQLite e SQLite Viewer
![image](https://github.com/fatihisla/LINQDb/assets/116791165/2400eda9-e655-4748-8a28-a343843edc86)
*Poi divertirsi nella creazione del programma.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------
####      Programma C#:

//connessione a db
####
    
    SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
    
    var tblArtist = cn1.Query<Artist>("select * from artists ");
    
    Console.WriteLine($"in questa tabella ci sono {tblArtist.Count} record!");
    
    
####




