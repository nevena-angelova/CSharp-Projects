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

    public class SongController : ApiController
    {
        private MusicLibraryData data = new MusicLibraryData();

        public SongController()
            : this(new MusicLibraryData())
        {
        }

        public SongController(MusicLibraryData data)
        {
            this.data = data;
        }

        [HttpGet]
        // GET api/song
        public IHttpActionResult All()
        {
            var songs = this.data
                .Songs
                .All()
                .Select(SongModel.FromSong);

            return Ok(songs);
        }

        [HttpPost]
        public IHttpActionResult Create(SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Song newSong = new Song()
            {
                Title = song.Title,
                Genre = song.Genre,
                Year = song.Year,
            };

            this.data.Songs.Add(newSong);
            this.data.SaveChanges();

            song.Id = newSong.Id;

            return Ok(song);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Song selectedSong = this.data.Songs.All().FirstOrDefault(s => s.Id == id);

            if (selectedSong == null)
            {
                return BadRequest("Such album does not exist!");
            }

            selectedSong.Title = song.Title;
            selectedSong.Genre = song.Genre;
            selectedSong.Year = song.Year;

            this.data.SaveChanges();

            song.Id = id;

            return Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id, SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Song selectedSong = this.data.Songs.All().FirstOrDefault(s => s.Id == id);

            if (selectedSong == null)
            {
                return BadRequest("such album does not exist!");
            }

            this.data.Songs.Delete(selectedSong);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
