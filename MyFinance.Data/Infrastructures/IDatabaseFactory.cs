﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructures
{
   public interface IDatabaseFactory
    {
        MyFinalsContext Mycontext { get; }
       
    }
}
