using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Program2
        {
                public static void NotMain()
                {
                        Console.Title = "Program 2 - Advanced";

                        int freqMin, freqMax, durMin, durMax, numOfBeeps;
                        Console.WriteLine("Hello World!");

                        Console.WriteLine("Enter frequency min range in Hz:");
                        freqMin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter frequency max range in Hz:");
                        freqMax = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter duration min range in ms:");
                        durMin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter duration max range in ms:");
                        durMax = int.Parse(Console.ReadLine());
                        Console.WriteLine("Play how many beeps? (recommended 3 - 10)");
                        numOfBeeps = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numOfBeeps; i++)
                        {
                                Random r = new Random();
                                int duration, freq;
                                freq = r.Next(freqMin, freqMax);
                                duration = r.Next(durMin, durMax);
                                Console.WriteLine("Beep Frequency: " + freq + "Hz - Beep Duration: " + duration + "ms");
                                Console.Beep(freq, duration);

                        }

                }
        }
}
