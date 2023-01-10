﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Save();
    }
}
