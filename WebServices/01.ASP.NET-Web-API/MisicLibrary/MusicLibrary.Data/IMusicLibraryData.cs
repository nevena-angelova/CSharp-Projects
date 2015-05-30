using System;
using System.Collections.Generic;
using System.Linq;
using MusicLibrary.Models;
using MusicLibrary.Data.Repositories;

namespace MusicLibrary.Data
{
    public interface IMusicLibraryData
    {
        IGenericRepository<Album> Albums { get; }

        IGenericRepository<Artist> Artists { get; }

        IGenericRepository<Song> Songs { get; }

        void SaveChanges();
    }
}
