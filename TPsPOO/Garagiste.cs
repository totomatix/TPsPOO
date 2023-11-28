using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Garagiste : Personne
    {
        private uint _Skill;

        /// <summary>
        /// Talent du garagiste entre 0 et 100
        /// </summary>
        public uint Skill
        {
            get => _Skill; set
            {
                if (value > 100)
                {
                    _Skill = 100;
                }
                else
                {
                    _Skill = value;
                }
            }
        }

        public override string? ToString()
        {
            return "Garagiste : \n" + base.ToString();
        }
    }


}
