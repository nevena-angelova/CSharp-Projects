using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MusicLibrary.Services.Models;
using MusicLibrary.Models;
using MusicLibrary.Data;

namespace MusicLibrary.Services.Controllers
{
    public class ArtistController : ApiController
    {
        private MusicLibraryData data = new MusicLibraryData();

        public ArtistController()
            : this(new MusicLibraryData())
        {
        }

        public ArtistController(MusicLibraryData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/artist
        public IHttpActionResult All()
        {
            var artists = this.data
                .Artists
                .All()
                .Select(ArtistModel.FromArtist);

            return Ok(artists);
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist newArtist = new Artist()
            {
                Name = artist.Name,
                DayOfBirth = artist.DayOfBirth,
                Country = artist.Country
            };

            this.data.Artists.Add(newArtist);
            this.data.SaveChanges();

            artist.Id = newArtist.Id;

            return Ok(artist);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist selectedArtist = this.data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (selectedArtist == null)
            {
                return BadRequest("such artist does not exist!");
            }

            selectedArtist.Name = artist.Name;
            selectedArtist.DayOfBirth = artist.DayOfBirth;
            selectedArtist.Country = artist.Country;

            this.data.SaveChanges();

            artist.Id = id;

            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id, ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist selectedArtist = this.data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (selectedArtist == null)
            {
                return BadRequest("such artist does not exist!");
            }

            this.data.Artists.Delete(selectedArtist);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddAlbums(int id, int albumId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album selectedAlbum = this.data.Albums.All().FirstOrDefault(al => al.Id == albumId);

            if (selectedAlbum == null)
            {
                return BadRequest("Such album does not exist!");
            }

            Artist selectedArtist = this.data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (selectedArtist == null)
            {
                return BadRequest("Such artist does not exist!");
            }

            selectedArtist.Albums.Add(selectedAlbum);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
