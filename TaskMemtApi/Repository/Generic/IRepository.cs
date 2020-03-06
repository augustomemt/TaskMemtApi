﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskMemtApi.Models.Base;

namespace TaskMemtApi.Repository.Generic
{
    public interface IRepository<T> where T: BaseEntity
    {


        T Create(T item);
        T FindById(int id);

        List<T> FindAll();

        T Update(T item);

        void Delete(int id);

        bool Exists(int? id);
    }
}
