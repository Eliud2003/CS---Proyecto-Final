using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___CS.Service.Interfaces
{
    public interface IManagement<T> where T : class
    {
        bool Create(T entity);
        T Read(int id);
        bool Update(int id,T entity);
        bool Delete(int id);
        List<T> GetList();
    }
}
