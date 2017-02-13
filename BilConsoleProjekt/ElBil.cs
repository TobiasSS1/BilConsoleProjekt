using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    public class ElBil : Bil, IElBil
    {
        public int BatteriKapacitet { get; private set; }
        public int KmPrKW { get; private set; }

        public ElBil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int BatteriKapacitet, int KmPrKW)
            : base(BilPrisExAfgift, KøbsÅr, Mærke, RegistreringsNr)
        {
            this.BatteriKapacitet = BatteriKapacitet;
            this.KmPrKW = KmPrKW;
        }

        public override int HalvÅrligEjerAfgift()
        {
            return 0;
        }

        public override int RækkeVidde()
        {
            int dur = BatteriKapacitet * KmPrKW;
            return dur;
        }

        public override int RegistreringsAfgift()
        {
            int Bilpris = BilPrisExAfgift * 120 / 100;
            return Bilpris;
        }
    }
}
