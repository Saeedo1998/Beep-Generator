using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Program2
        {
                public static void NotMain()
                {
                        Console.Clear();
                        Console.Title = "Program 2 - Advanced";

                        int freqMin, freqMax, durMin, durMax, numOfBeeps;
                        //Console.WriteLine("Hello World!");
                        Console.WriteLine("----------- Sound Frequency -----------");
                        Console.WriteLine("Frequency value must be between 37 and 32767");
                        Console.WriteLine("Enter frequency minimum range in Hz:");
                        freqMin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter frequency maximum range in Hz:");
                        freqMax = int.Parse(Console.ReadLine());
                        Console.WriteLine("------------ Beep Duration ------------");
                        Console.WriteLine("Enter duration min range in ms:");
                        durMin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter duration max range in ms:");
                        durMax = int.Parse(Console.ReadLine());
                        Console.WriteLine("--------- Frequency of Beeps -----------");
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
