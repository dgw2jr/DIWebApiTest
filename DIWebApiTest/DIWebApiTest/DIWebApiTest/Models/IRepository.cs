using System.Collections.Generic;

namespace DIWebApiTest.Models
{

    public interface IRepository<T>
    {
        T GetById(string id);
        IEnumerable<T> Get();
        void Update(T item);
        void Insert(T item);
        void Delete(string id);
    }

}