﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics_store.Infrastracture.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Begin();
        void Commit();
        void RoleBack();
    }
}
