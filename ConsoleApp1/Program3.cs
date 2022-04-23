using System;
using System.Collections.Generic;
using System.Text;

namespace BeepGenerator
{
    class Program3
    {
        public static void Start()
        {
            Console.Clear();
            Console.Title = "Program 3 - Random";

            Random r = new Random();
            Console.Beep(r.Next(100, 1000), r.Next(200, 2000));


        }
    }
}
