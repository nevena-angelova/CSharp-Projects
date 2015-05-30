namespace MusicLibrary.Data
{
    using System;
    using System.Data.Entity;
    using MusicLibrary.Data.Migrations;
    using MusicLibrary.Models;

    public class MusicLibraryDbContext : DbContext, IMusicLibraryDbContext
    {
        public MusicLibraryDbContext()
            : base("MusicLibrary")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicLibraryDbContext, Configuration>());
        }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}