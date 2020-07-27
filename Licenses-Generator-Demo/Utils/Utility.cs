﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenses_Generator_Demo.Utils
{
    public static  class Utility
    {
        public static bool IsAnyProduct<T>(this IEnumerable<T> data)
        {
            return data != null && data.Any();
        }

        internal static bool IsAnyProduct(object products)
        {
            throw new NotImplementedException();
        }
    }
}
