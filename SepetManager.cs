using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class SepetManager
    {
        public void Add(Products product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
        }
    }
}
