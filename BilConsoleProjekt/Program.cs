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
            DieselBil DieselBil = new DieselBil(2122, 2016, "Volvo", "AJ 5094", 10, 3);
            DieselBil DieselBil2 = new DieselBil(22000, 2013, "Toyota", "KF 2194", 12, 6);
            DieselBil DieselBil3 = new DieselBil(19000, 2015, "VolksWagen", "DB 5964", 15, 8);
            DieselBil DieselBil4 = new DieselBil(22000, 2013, "Opel", "VC 8894", 9, 8);
            DieselBil DieselBil5 = new DieselBil(26000, 2017, "Citroen", "KF 2194", 17, 3);

            BenzingBil BenzinBil = new BenzingBil(19992, 2015, "Volvo", "OP 2134", 12, 1);
            BenzingBil BenzinBil2 = new BenzingBil(21992, 2016, "Toyota", "EJ 2934", 11, 5);
            BenzingBil BenzinBil3 = new BenzingBil(23022, 2017, "VolksWagen", "UI 2621", 9, 4);
            BenzingBil BenzinBil4 = new BenzingBil(22222, 2011, "Opel", "LC 1111", 8, 8);
            BenzingBil BenzinBil5 = new BenzingBil(28475, 2018, "Citroen", "EK 1243", 13, 2);

            ElBil ElBil = new ElBil(29910, 2017, "Volvo", "JV 8319", 11, 3);
            ElBil ElBil1 = new ElBil(30192, 2016, "Toyota", "KL 1738", 10, 1);
            ElBil ElBil2 = new ElBil(29910, 2017, "VolksWagen", "ER 0261", 9, 4);
            ElBil ElBil3 = new ElBil(2701, 2018, "Opel", "MC 2123", 7, 13);
            ElBil ElBil4 = new ElBil(3291, 2011, "Citroen", "YV 2139", 7, 1);

            List<IBil> BilListe = new List<IBil>();

            BilListe.Add(BenzinBil);
            BilListe.Add(BenzinBil2);
            BilListe.Add(BenzinBil3);
            BilListe.Add(BenzinBil4);
            BilListe.Add(BenzinBil5);

            BilListe.Add(DieselBil);
            BilListe.Add(DieselBil2);
            BilListe.Add(DieselBil3);
            BilListe.Add(DieselBil4);
            BilListe.Add(DieselBil5);

            BilListe.Add(ElBil);
            BilListe.Add(ElBil1);
            BilListe.Add(ElBil2);
            BilListe.Add(ElBil3);
            BilListe.Add(ElBil4);


            foreach (var K in BilListe)
            {
                Console.WriteLine(K);             
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
