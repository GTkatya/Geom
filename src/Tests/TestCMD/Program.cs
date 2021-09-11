using System;
using Geom.MainLibrary;
using Geom.MainLibrary.Shapes.Lines;
using static System.Console;

namespace TestCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Line p = new VerticalLine(3, 4, 4);
            p.Draw();
            ReadKey();
        }
    }
}
