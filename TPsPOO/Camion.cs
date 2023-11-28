using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Camion : Vehicule
    {
        public override double TempsReperationEstime(uint skillGaragiste)
        {
            return 2 * base.TempsReperationEstime(skillGaragiste);
        }

        public override string? ToString()
        {
            return "Camion : \n" + base.ToString();
        }
    }
}
