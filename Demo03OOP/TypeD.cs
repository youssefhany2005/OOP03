using Demo03OOP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03OOP
{
    internal class TypeD : TypeA
    {
        public TypeD()
        {
            //A = 1; error
            //B = 2; error
             C = 3;
            //X = 4; error
            Y = 5;
            Z = 6;
        }
    }
}
