using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Voiture : Vehicule
    {
        public override double TempsReperationEstime(uint skillGaragiste)
        {
            return 1.5 * base.TempsReperationEstime(skillGaragiste);
        }
    }
}
