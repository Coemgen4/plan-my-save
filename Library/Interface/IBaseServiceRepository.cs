﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Library.Interface
{
    public interface IBaseServiceRepository<M> where M : class, IEntity
    {
        IEnumerable<M> GetAll();

        M GetByID(int id);

        M Create(M obj);

        M Update(M obj);

        void Delete(int id);

        void Save();
    }
}
