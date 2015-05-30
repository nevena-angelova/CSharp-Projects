namespace MusicLibrary.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        [ForeignKey("Artist")]
        public int artistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}