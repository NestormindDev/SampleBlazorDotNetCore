﻿using OrderManagement.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Interface
{
    public interface ISupplierRepository : IGenericRepository<Supplier>
    { }
}
