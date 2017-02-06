﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    public class Bil
    {
        private int BilPrisExAfgift {get; set;}
        public int KøbsÅr { get; set; }
        public string Mærke { get; set; }
        private string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }

        public Bil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int KmPrLiter)
        {
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.Mærke = Mærke;
            this.RegistreringsNr = RegistreringsNr;
            this.KmPrLiter = KmPrLiter;
        }

        public virtual int RegistreringsAfgift()
        {
            int Bilpris = BilPrisExAfgift * 105 / 100;
            if (KøbsÅr <= 2014)
            {
                
                if (Bilpris > 80500)
                {
                    int Imentebilpris = Bilpris - 80500;
                    Bilpris = Bilpris - Imentebilpris;
                    Imentebilpris = Imentebilpris * 180 / 100;
                    Bilpris = Imentebilpris + Bilpris;
                    return Bilpris;
                }
            }
            else if (KøbsÅr >= 2015)
            {
                
                if (Bilpris > 81700)
                {
                    int Imentebilpris = Bilpris - 81700;
                    Bilpris = Bilpris - Imentebilpris;
                    Imentebilpris = Imentebilpris * 180 / 100;
                    Bilpris = Imentebilpris + Bilpris;
                    return Bilpris;
                }
            }
            return Bilpris;

        }

        public int TotalPris()
        {
            return BilPrisExAfgift;
        }

        public virtual int HalvÅrligEjerAfgift()
        {
            return 1000;
        }






    }

    
}
