using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            DieselBil Minbil = new DieselBil(20000, 2016, "Volvo", "AJ 5094", 130);
            DieselBil Minbil2 = new DieselBil(22000, 2013, "Toyota", "KF 2194", 120);
            DieselBil Minbil3 = new DieselBil(19000, 2015, "VolksWagen", "DB 5964", 150);
            DieselBil Minbil4 = new DieselBil(22000, 2013, "Opel", "VC 8894", 90);
            DieselBil Minbil5 = new DieselBil(26000, 2017, "Citroen", "KF 2194", 100);
            //Bil AltBil = new Bil(29919, 2222, "test","Kf 39384", 300); /* test */

            //List<Bil> BIILListe = new List<Bil>(); /* test*/

            List<DieselBil> BilListe = new List<DieselBil>();

            //BIILListe.Add(AltBil); /* test */

            BilListe.Add(Minbil);
            BilListe.Add(Minbil2);
            BilListe.Add(Minbil3);
            BilListe.Add(Minbil4);
            BilListe.Add(Minbil5);

            foreach (var L in BilListe)
            {
                Console.WriteLine(L);

                
            }

            //foreach (DieselBil k in BilListe)
            //{
            //    if (AltBil is DieselBil)
            //    {
            //        DieselBil nybil = Bil as DieselBil;

            //        Console.WriteLine(AltBil.PartikelFilter);
            //    }

            //    else if (Bil is BenzingBil)
            //    {
            //        BenzingBil benzingbil1 = Bil as BenzingBil;
            //    }
            //}
        }
    }
}
