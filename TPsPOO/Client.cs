using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Client : Personne
    {
        public override string? ToString()
        {
            return "Client : \n" + base.ToString();
        }
    }
}
