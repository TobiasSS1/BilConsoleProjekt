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
            DieselBil Minbil = new DieselBil(20000, 2016, "Volvo", "AJ 5094", 10);
            DieselBil Minbil2 = new DieselBil(22000, 2013, "Toyota", "KF 2194", 12);
            DieselBil Minbil3 = new DieselBil(19000, 2015, "VolksWagen", "DB 5964", 15);
            DieselBil Minbil4 = new DieselBil(22000, 2013, "Opel", "VC 8894", 9);
            DieselBil Minbil5 = new DieselBil(26000, 2017, "Citroen", "KF 2194", 17);

            BenzingBil BenzinBil = new BenzingBil(19992, 2015, "Volvo", "OP 2134", 12);
            BenzingBil BenzinBil2 = new BenzingBil(21992, 2016, "Toyota", "EJ 2934", 11);
            BenzingBil BenzinBil3 = new BenzingBil(23022, 2017, "VolksWagen", "UI 2621", 9);
            BenzingBil BenzinBil4 = new BenzingBil(22222, 2011, "Opel", "LC 1111", 8);
            BenzingBil BenzinBil5 = new BenzingBil(98475, 2018, "Citroen", "EK 1243", 13);

            List<BenzingBil> BenzinBilListe = new List<BenzingBil>();

            BenzinBilListe.Add(BenzinBil);
            BenzinBilListe.Add(BenzinBil2);
            BenzinBilListe.Add(BenzinBil3);
            BenzinBilListe.Add(BenzinBil4);
            BenzinBilListe.Add(BenzinBil5);

            List<DieselBil> DiezelBilListe = new List<DieselBil>();

            DiezelBilListe.Add(Minbil);
            DiezelBilListe.Add(Minbil2);
            DiezelBilListe.Add(Minbil3);
            DiezelBilListe.Add(Minbil4);
            DiezelBilListe.Add(Minbil5);

            foreach (var B in BenzinBilListe)
            {
                Console.WriteLine(B);
            }
            
            foreach (var L in DiezelBilListe)
            {
                Console.WriteLine(L);

                
            }

            //BIILListe.Add(AltBil); /* test */

            //Bil AltBil = new Bil(29919, 2222, "test","Kf 39384", 300); /* test */

            //List<Bil> BIILListe = new List<Bil>(); /* test*/

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
