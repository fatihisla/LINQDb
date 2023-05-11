# LINQDb
~~Obbiettivo~~:leggere i nomi degli artisti in ordine decrescente
     
     
Passi necessari  a creare un programma LINQDb:

* Creare una cartella e nominarla.

* Aprire la cartella con Visual Studio Code,creare un nuovo terminare e trascrivere il comando:
     
       dotnet new console
     
* Adesso aggiungere il file di testo chinook.db tramite questo link:https://www.sqlitetutorial.net/sqlite-sample-database/
* Aggiungere il file nella cartella poi aggiungere se non si ha le estensioni SQLite e SQLite Viewer

![image](https://github.com/fatihisla/LINQDb/assets/116791165/2400eda9-e655-4748-8a28-a343843edc86)

* Poi divertirsi nella creazione del programma.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------
####  ** Programma C#:
Il progamma creato dovrebbe venire qualcosa del genere:
//connessione a db
####
    
    SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
    
    var tblArtist = cn1.Query<Artist>("select * from artists ");
    
    Console.WriteLine($"in questa tabella ci sono {tblArtist.Count} record!");
    var temporanea = tblArtists.OrderByDescending(x => x.Name).Max(y => y.ArtistId);
         
         foreach (var artista in tblArtists)
          {
               Console.WriteLine($"{artista.Name}");
          }

          Console.WriteLine($"{temporanea}");


          //fine main ed inizio dichiarazioni 

          public class Artist
          {
               public int ArtistId { get; set; }
               public string Name { get; set; }
          }
* In fine si utilizza il  terminale usando il comando :

          dotnet run 
          
 * il programma non funzionerà perchè non ingrado di leggere la nostra query,per risolvere il problema basterà aggiungere questo comando nel terminale:
  
           dotnet add package sqlite-net-pcl
           
* dopo l'aggiunta del comando comparirà :
 
          <ItemGroup>
               <PackageReference Include="sqlite-net-pcl" Version="1.8.116" />
          </ItemGroup>

* Dopo aver fatto tutto questo eseguiamo l'ultimo test per vedere se l'obbiettivo è stato raggiunto:

![image](https://github.com/fatihisla/LINQDb/assets/116791165/8a5f7594-2389-472e-bbaa-ca00dbb6b4f1)


Sono solo alcuni dei nomi di artisti tra i record trovati.

Tabella artisti nel file chinook :

![image](https://github.com/fatihisla/LINQDb/assets/116791165/bff9cacc-a87f-48e4-ac66-dd38eeb8305e)

(ci sono 275 record).



#####

_Lavoro svolto da Fatih Islamovski._

_Informazioni ricavate da lezione di M.Conti, M.Sartini e da sito microsoft._

#####







