using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Factory method pattern
    public class Destroyer : Ship
    {
        public override string Name => "Destroyer";
        public override int Size => 3;
    }
}
