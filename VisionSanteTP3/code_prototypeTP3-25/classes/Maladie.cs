using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_prototypeTP3_25.classes
{
    internal class Maladie : Probleme
    {
        public string Stade { get; set; }

        public Maladie(string nas, string nom, string debut, string guerison, string description, string stade)
            : base(nas, nom, debut, guerison, description)
        {
            Stade = stade;
        }

        public override void Ecrire(StreamReader SR)
        {
        }
    }
}
