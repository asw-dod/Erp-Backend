using System;
using System.Collections.Generic;
using System.Linq;
using ErpBackend.Models;
using ErpBackend.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class RaspberryRepository : IRepository<RaspberryModel, int>, IDisposable
    {
        private ErpContext context;
        private bool disposed = false;


        public RaspberryRepository(ErpContext context)
        {
            this.context = context;
        }

        public RaspberryModel Add(RaspberryModel data)
        {
            var result = context.Raspberry.Add(data);
            result.Reload();
            return result.Entity;
        }

        public bool Delete(RaspberryModel data)
        {
            var result = context.Raspberry.Remove(data);
            return result.State == EntityState.Deleted;
        }
        public bool Delete(int id)
        {
            return Delete(context.Raspberry.Find(id));
        }

        public IQueryable<RaspberryModel> Get()
        {
            return context.Raspberry;
        }

        public RaspberryModel Update(RaspberryModel value)
        {
            context.Raspberry.Attach(value);
            context.Entry(value).State = EntityState.Modified;

            return value;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.SaveChanges();
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
