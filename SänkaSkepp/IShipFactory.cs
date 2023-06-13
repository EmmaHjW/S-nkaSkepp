using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Factory method pattern
    public interface IShipFactory
    {
        IShipFactory CreateShip();
    }
}
