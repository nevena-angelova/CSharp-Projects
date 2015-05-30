namespace MusicLibrary.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using MusicLibrary.Services.Models;
    using MusicLibrary.Models;
    using MusicLibrary.Data;

    public class AlbumController : ApiController
    {
        private MusicLibraryData data = new MusicLibraryData();

        public AlbumController()
            : this(new MusicLibraryData())
        {
        }

        public AlbumController(MusicLibraryData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/album
        public IHttpActionResult All()
        {
            var albums = this.data
                .Albums
                .All()
                .Select(AlbumModel.FromAlbum);

            return Ok(albums);
        }

        [HttpPost]
        public IHttpActionResult Create(AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album newAlbum = new Album()
            {
                Title = album.Title,
                Producer = album.Producer,
                Year = album.Year
            };

            this.data.Albums.Add(newAlbum);
            this.data.SaveChanges();

            album.Id = newAlbum.Id;

            return Ok(album);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album selectedAlbum = this.data.Albums.All().FirstOrDefault(a => a.Id == id);

            if (selectedAlbum == null)
            {
                return BadRequest("Such album does not exist!");
            }

            selectedAlbum.Title = album.Title;
            selectedAlbum.Producer = album.Producer;
            selectedAlbum.Year = album.Year;

            this.data.SaveChanges();

            album.Id = id;

            return Ok(album);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id, AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album selectedAlbum = this.data.Albums.All().FirstOrDefault(a => a.Id == id);

            if (selectedAlbum == null)
            {
                return BadRequest("such album does not exist!");
            }

            this.data.Albums.Delete(selectedAlbum);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddSongs(int id, int songId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album selectedAlbum = this.data.Albums.All().FirstOrDefault(al => al.Id == songId);

            if (selectedAlbum == null)
            {
                return BadRequest("Such album does not exist!");
            }

            Song selectedSong = this.data.Songs.All().FirstOrDefault(s => s.Id == id);

            if (selectedSong == null)
            {
                return BadRequest("Such song does not exist!");
            }

            selectedAlbum.Songs.Add(selectedSong);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
