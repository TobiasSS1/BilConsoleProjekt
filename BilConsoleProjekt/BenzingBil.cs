using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    public sealed class BenzingBil : Bil
    {
        public int Tank { get; private set; }
        public int KmPrLiter { get; private set; }

        public BenzingBil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int KmPrLiter, int Tank) : base(BilPrisExAfgift, KøbsÅr, Mærke, RegistreringsNr)
        {
            this.Tank = Tank;
            this.KmPrLiter = KmPrLiter;
        }

        public override int HalvÅrligEjerAfgift()
        {
            int afgiftialt = HalvÅrligEjerAfgift();
            if (KmPrLiter < 20)
                afgiftialt = afgiftialt + 1200;

            else if (KmPrLiter > 19 && KmPrLiter < 29)
                afgiftialt = afgiftialt + 600;

            else if (KmPrLiter > 28)
                afgiftialt = afgiftialt + 320;

            return afgiftialt;
        }

        public override int RækkeVidde()
        {
            return Tank * KmPrLiter;
        }
    }
}
