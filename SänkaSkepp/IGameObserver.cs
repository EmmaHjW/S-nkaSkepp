﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Observer pattern
    public interface IGameObserver
    {
        void Update(string message);
    }
}
