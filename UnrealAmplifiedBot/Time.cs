﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealAmplified
{
    public static class TimeConstants
    {
        //The number of loop iterations performed in a second assuming no slowdown
        public const int TicksPerSecond = 10;

        //Number of loop iterations per function. Used to synchronize functions that must be called on the same iteration.
        public const int StandardDelay = 5;
    }
}
