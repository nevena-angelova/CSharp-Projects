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

    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromArtist
        {
            get
            {
                return a => new ArtistModel
                {
                    Name = a.Name,
                    DayOfBirth = a.DayOfBirth,
                    Country = a.Country
                };
            }
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string Country { get; set; }
    }
}