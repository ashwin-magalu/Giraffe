﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef can make Pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Chicken parm");
        }
    }
}
