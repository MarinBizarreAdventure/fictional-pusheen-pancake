﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepository<T> where T : Entity
    {
        //U GetById<U>(int id);
        T GetById(int id);
        IList<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
