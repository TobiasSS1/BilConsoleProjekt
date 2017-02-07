using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    public class DieselBil : Bil
    {

        public bool PartikelFilter { get; private set; }
        public DieselBil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int KmPrLiter, bool pf) : base( BilPrisExAfgift, KøbsÅr, Mærke, RegistreringsNr, KmPrLiter)
        {
            this.Mærke = Mærke;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
            this.PartikelFilter = pf;
        }

        public DieselBil(int BilPrisExAfgift, int KøbsÅr, string Mærke, string RegistreringsNr, int KmPrLiter) : this(BilPrisExAfgift, KøbsÅr, Mærke, RegistreringsNr, KmPrLiter, true)
        {
            this.Mærke = Mærke;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
        }

        public override int HalvÅrligEjerAfgift()
        {
            if(PartikelFilter != true)
            {
                return HalvÅrligEjerAfgift() + 500; 
            }
            return HalvÅrligEjerAfgift();
        }
    }
}
