using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Discoteque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;
        
        public ArtistsController(IArtistService artistService)
        {
            _artistService=artistService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var artists = _artistService.GetArtistAsync();
            return Ok(artists);
        }

        [HttpPost, Route("CreateArtists")]
        public IActionResult CreateArtists(Artist artist)
        {
            var result = _artistService.CreateArtist(artist);
            return Ok(result);
        }
    }
}
