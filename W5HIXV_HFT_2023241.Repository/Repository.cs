﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5HIXV_HFT_2023241.Repository
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        FleetDbContext ctx;
        protected Repository(FleetDbContext ctx)
        {
            this.ctx = ctx;
        }
        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Read(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
