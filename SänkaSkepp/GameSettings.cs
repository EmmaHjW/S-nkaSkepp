using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Singleton pattern
    public class GameSettings
    {
        private static GameSettings _instance;
        public static GameSettings Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GameSettings();
                }
                return _instance;
            }
        }
        private GameSettings()
        {

        }
        public int BoardSize { get; set; } = 10;
        public int MaxAttempts { get; set; } = 50;
    }

}
