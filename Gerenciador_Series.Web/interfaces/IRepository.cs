using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.interfaces
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> Get();
        T Get(int id);

        void Add(T entity);
        void Edit(T entity);
        void Remove(T entity);

        void Save();
    }
}
