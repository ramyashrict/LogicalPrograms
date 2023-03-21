﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class StopWatch
    {
          public static void Display()
        {
            Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        // ... This takes 10 seconds to finish.
        for (int i = 0; i< 1000; i++)
        {
            System.Threading.Thread.Sleep(10);
        }

    // Stop.
    stopwatch.Stop();
        
        // Write hours, minutes and seconds.
        Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
    }
}

    }

