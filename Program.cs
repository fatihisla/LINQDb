// See https://aka.ms/new-console-template for more information
using SQLite;


// 27/05/23
//connessione a db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from artists ");
Console.WriteLine($"in questa tabella ci sono {tblArtists.Count} record!");


//Language Integrate Query
//LINQ

/*
// 4/05/23 idea di procedimento iniziale (non funziona)
int x = 0;
string[] vect = new string[tblArtist.Count];
while(x < tblArtist.Count)
{
    vect[x] = tblArtist[x].Name;
    x++;
}
*/

// 5/05/23

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
