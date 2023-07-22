using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    Random random = new Random();
    public IEnumerable<Artist> CreateArtist(Artist artist)
    {
    List<Artist> artistas = new List<Artist>();
        artist.Id= random.Next(1,100);
        artistas.Add(artist);
        return artistas;    
        }

    public Task<Artist> EditArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Artist> GetArtistAsync()
    {
        List<Artist> artistas = new List<Artist>(){
            new Artist(){Id=random.Next(1,100), Name="Joe arroyo", Label="Artista de salsa colombiano", IsOnTour=false},
            new Artist(){Id=random.Next(1,100), Name="Diomedez Diaz", Label="Cantante de vallenato colombiano", IsOnTour=false},
            new Artist(){Id=random.Next(1,100), Name="Juan Gabriel", Label="Cantante de musica ranchera mexicano", IsOnTour=true},
            new Artist(){Id=random.Next(1,100), Name="Imagine Dragos", Label="Banda de rock estado unidense", IsOnTour=true},
            new Artist(){Id=random.Next(1,100), Name="Taylor swift", Label="Artista de pop estado unidense", IsOnTour=true}
        };
        return artistas;
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }
}