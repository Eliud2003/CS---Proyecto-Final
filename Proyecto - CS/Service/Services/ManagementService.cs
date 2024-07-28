using Microsoft.EntityFrameworkCore;
using Proyecto___CS.Repository;
using Proyecto___CS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Service.Services
{
    public class ManagementService<T> : IManagement<T> where T : class
    {
        private readonly AppDbContext appDbContext;

        public ManagementService(AppDbContext context)
        {
            this.appDbContext = context;
        }   

        public bool Create(T entity)
        {
            appDbContext.Set<T>().Add(entity);
            return appDbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var entity = appDbContext.Set<T>().Find(id);
            if (entity != null)
            {
                appDbContext.Set<T>().Remove(entity);
                return appDbContext.SaveChanges() > 0;
            }
            return false;
        }

        public List<T> GetList()
        {
            return appDbContext.Set<T>().ToList();
        }

        public T Read(int id)
        {
            return appDbContext.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            appDbContext.Set<T>().Update(entity);
            return appDbContext.SaveChanges() > 0;
        }
    }
}
