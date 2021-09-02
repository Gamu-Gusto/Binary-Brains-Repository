﻿using BinaryBrainsAPI.Data;
using BinaryBrainsAPI.Entities.Exhibitions;
using BinaryBrainsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryBrainsAPI.Repository.ExhibitionsRepositories
{
    public class ExhibitionApplicationRepository : IAppRepository<ExhibitionApplication>
    {
        readonly ArtechDbContext _artechDb;


        public ExhibitionApplicationRepository(ArtechDbContext artechDb)
        {
            _artechDb = artechDb;
        }

        public void Add(ExhibitionApplication exhibitionApplication)
        {
            _artechDb.ExhibitionApplication.Add(exhibitionApplication);
            _artechDb.SaveChanges();
        }

        public void Delete(ExhibitionApplication exhibitionApplication)
        {
            _artechDb.ExhibitionApplication.Remove(exhibitionApplication);
            _artechDb.SaveChanges();
        }

        public ExhibitionApplication Get(long id)
        {
            return _artechDb.ExhibitionApplication.FirstOrDefault(s => s.ExhibitionApplicationID == id);
        }

        public IEnumerable<ExhibitionApplication> GetAll()
        {
            return _artechDb.ExhibitionApplication.ToList();
        }

        public ExhibitionApplication GetByString(string str)
        {
            throw new NotImplementedException();
        }

        public void Update(ExhibitionApplication exhibitionApplication, ExhibitionApplication entity)
        {
            exhibitionApplication.ApplicationDescription = entity.ApplicationDescription;
            _artechDb.SaveChanges();
        }
    }
}
