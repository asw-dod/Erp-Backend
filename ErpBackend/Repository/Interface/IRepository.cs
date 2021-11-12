using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ErpBackend.Repository.Interface
{
    public interface IRepository<T, ID>
    {
        T Update(T value);
        T Add(T data);

        bool Delete(T data);
        bool Delete(ID id);

        IQueryable<T> Get();
    }
}
