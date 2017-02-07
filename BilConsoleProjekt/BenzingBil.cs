using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    public sealed class BenzingBil : Bil
    {
        public BenzingBil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int KmPrLiter) : base(BilPrisExAfgift, KøbsÅr, Mærke, RegistreringsNr, KmPrLiter)
        {
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
    }
}
