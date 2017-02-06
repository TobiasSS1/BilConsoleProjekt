using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt
{
    class BenzingBil : Bil
    {
        public BenzingBil(int pris) : base(pris)
        {
        }

        public override int Afgift()
        {
            throw new NotImplementedException();
        }
    }
}
