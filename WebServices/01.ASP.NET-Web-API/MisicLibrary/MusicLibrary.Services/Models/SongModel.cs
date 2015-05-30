namespace MusicLibrary.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MusicLibrary.Models;

    public class SongModel
    {
        public static Expression<Func<Song, SongModel>> FromSong
        {
            get
            {
                return s => new SongModel
                {
                    Title = s.Title,
                    Year = s.Year,
                    Genre = s.Genre
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }
    }
}