namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>{
    public string Name {get; set;} = "";
    public int year {get; set;}
    public Genres Genre {get; set;} = Genres.Unkown;
    //public Artist? artist {get; set;}

}

public enum Genres{
    Rock, 
    Vallenato,
    Metal,
    Pop,
    Salsa,
    Merengue,
    Urbano, 
    Country,
    Indie,
    Electronic,
    Unkown

}