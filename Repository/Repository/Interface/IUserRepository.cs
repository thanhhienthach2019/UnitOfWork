﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface IUserRepository
    {
        user GetByPredicate(Expression<Func<user, bool>> condition);
    }
}
