﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Extensions
    {
        public static string PriceWithCurrency(this double x, string s)
        {
            return x + s;
        }


    }
}
