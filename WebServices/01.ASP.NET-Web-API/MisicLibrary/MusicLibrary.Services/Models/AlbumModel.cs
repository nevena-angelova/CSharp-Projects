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

    public class AlbumModel
    {
        public static Expression<Func<Album, AlbumModel>> FromAlbum
        {
            get
            {
                return a => new AlbumModel
                {
                    Title = a.Title,
                    Year = a.Year,
                    Producer = a.Producer
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        //public virtual ICollection<Song> Songs { get; set; }
    }
}