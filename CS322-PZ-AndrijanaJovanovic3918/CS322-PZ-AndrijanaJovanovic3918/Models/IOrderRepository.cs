﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS322_PZ_AndrijanaJovanovic3918.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
