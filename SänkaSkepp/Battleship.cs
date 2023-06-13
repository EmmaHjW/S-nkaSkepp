using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //factory method pattern
    public class Battleship : Ship
    {
        public override string Name => "Battleship";
        public override int Size => 4;
    }
}
