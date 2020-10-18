using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    public class dev
    {
        int x = 5;
        int y = x / 0;

        Console.WriteLine("{y}");
    }
    class Program

    {
        static void Main(string[] args)
        {
            dev d = new dev();
            d.GetType();
        }
    }
}
