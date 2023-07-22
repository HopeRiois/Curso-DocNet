using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface IArtistService{
    IEnumerable<Artist> GetArtistAsync();
    Task<Artist> GetById(int id);
    IEnumerable<Artist> CreateArtist(Artist artist);
    Task<Artist> EditArtist(Artist artist);
}