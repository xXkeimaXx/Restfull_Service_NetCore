﻿using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IRepository<T> where T:class
    {
        bool Delete(T entity);
        bool Update(T entity);
        int insert(T entity);
        IEnumerable<T> GetList();
        T GetById(int id);
    }
}
