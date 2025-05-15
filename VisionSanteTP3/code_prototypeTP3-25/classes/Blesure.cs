using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_prototypeTP3_25.classes
{
    internal class Blesure : Probleme
    {
        public Blesure(string nas, string nom, string debut, string guerison, string description) 
            : base(nas, nom, debut, guerison, description)
        { 
            
        }
        public override void Ecrire(StreamReader SR)
        {
        }
    }
}
