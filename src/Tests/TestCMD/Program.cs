using System;
using Geom.MainLibrary;
using static System.Console;

namespace TestCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 3);
            p.Draw();
            ReadKey();
        }
    }
}
