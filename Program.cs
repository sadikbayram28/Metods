using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Products product = new Products(); //Products Class'ından Nesne oluşturduk.
            product.Adi = "Elma";                 
            product.Fiyati = 15;            
            product.Aciklama = "Amasya Elması";

            Products product2 = new Products(); //Products Class'ından Nesne oluşturduk.
            product2.Adi = "Karpuz";
            product2.Fiyati = 90;
            product2.Aciklama = "Diyarbakır Karpuzu";

           
            Products[] products = new Products[] { product, product2 }; // Referans Tipi Products olan bir Array oluşturduk.
            foreach (var item in products)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("-------------Metods-----------"+'\n');

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Add(product2);


            Console.ReadKey();
        }
    }
}
