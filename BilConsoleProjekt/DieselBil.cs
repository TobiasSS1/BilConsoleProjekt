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
        public DieselBil(int pris, bool pf) : base(pris, true)
        {
            this.Mærke = Mærke;
            this.PrisExAfgift = PrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
            this.PartikelFilter = pf;
        }

        public DieselBil(int pris) : this(pris, true)
        {
            this.Mærke = Mærke;
            this.PrisExAfgift = PrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
        }

        public override int HalvÅrligEjerAfgift()
        {
            if(PartikelFilter != true)
            {
                return base.HalvÅrligEjerAfgift() + 500; 
            }
            return base.HalvÅrligEjerAfgift();
        }
    }
}
