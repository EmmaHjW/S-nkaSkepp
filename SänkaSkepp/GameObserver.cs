using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Observer pattern
    public class GameObserver : IGameObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Observer] {message}");
        }
    }
}
