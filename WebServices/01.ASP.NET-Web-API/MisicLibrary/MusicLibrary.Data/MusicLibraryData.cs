using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MusicLibrary.Models;
using MusicLibrary.Data.Repositories;

namespace MusicLibrary.Data
{
    public class MusicLibraryData : IMusicLibraryData
    {

        private IMusicLibraryDbContext context;
        private IDictionary<Type, object> repositories;

        public MusicLibraryData(IMusicLibraryDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public MusicLibraryData()
            : this(new MusicLibraryDbContext())
        {
        }

        public IGenericRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public IGenericRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }

        public IGenericRepository<Song> Songs
        {
            get
            {
                return this.GetRepository<Song>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}