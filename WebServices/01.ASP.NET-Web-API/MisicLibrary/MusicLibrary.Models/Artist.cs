namespace MusicLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.albums = new HashSet<Album>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string Country { get; set; }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}