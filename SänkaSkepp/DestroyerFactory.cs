using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Factory method pattern
    public class DestroyerFactory : IShipFactory
    {
        public IShipFactory CreateShip()
        {
            
            return new DestroyerFactory();
        }
    }
}
