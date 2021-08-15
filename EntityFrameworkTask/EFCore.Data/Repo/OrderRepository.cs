﻿using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class OrderRepository: BaseRepository<Order>
    {
        public OrderRepository(DataContext context) : base(context)
        {
        }
    }
}
