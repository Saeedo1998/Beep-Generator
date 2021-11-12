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
                        while (true)
                        {
                                freqMin = int.Parse(Console.ReadLine());
                                if (freqMin < 37)
                                {
                                        Console.WriteLine("Sound frequency must be at least 37");
                                }
                                else if (freqMin > 32767)
                                {
                                        Console.WriteLine("Sound frequency must not exceed 32767");
                                }
                                else
                                {
                                        break;
                                }
                        }
                        Console.WriteLine("Enter frequency maximum range in Hz:");
                        while (true)
                        {
                                freqMax = int.Parse(Console.ReadLine());
                                if (freqMax < freqMin)
                                {
                                        Console.WriteLine("Maximum frequency must be higher than minimum frequency");
                                }
                                else if (freqMax < 37)
                                {
                                        Console.WriteLine("Sound frequency must be at least 37");
                                }
                                else if (freqMax > 32767)
                                {
                                        Console.WriteLine("Sound frequency must not exceed 32767");
                                }
                                else
                                {
                                        break;
                                }
                        }
                        
                        Console.WriteLine("------------ Beep Duration ------------");
                        Console.WriteLine("Enter duration min range in ms:");
                        durMin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter duration max range in ms:");
                        while (true)
                        {
                                 durMax = int.Parse(Console.ReadLine());
                                if (durMax < durMin)
                                {
                                        Console.WriteLine("Duration maximum value must be higher than minimum value");

                                }
                                else
                                {
                                        break;
                                }

                        }
                        Console.WriteLine("--------- Frequency of Beeps -----------");
                        Console.WriteLine("Play how many beeps? (recommended 3 - 10)");
                        numOfBeeps = int.Parse(Console.ReadLine());

                        //begin generating beep/s
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
