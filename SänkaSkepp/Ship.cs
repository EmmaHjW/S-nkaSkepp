using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Factory method pattern
    public abstract class Ship
    {
        public abstract string Name { get; }
        public abstract int Size { get; }
    }
}
