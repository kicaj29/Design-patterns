﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public class BuyerRepository : IBuyerRepository
    {
        public Buyer GetById(int id)
        {
            return new Buyer();
        }
    }
}
