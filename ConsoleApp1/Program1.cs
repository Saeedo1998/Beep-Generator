using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        class Program1
        {
                public static void Start()
                {
                        try
                        {
                                //start program1
                                Console.Clear();
                                Console.Title = "Program 1 - Basic";

                                int num1, num2, total;
                                //Console.WriteLine("Hello World!");

                                Console.WriteLine("Enter number1:");
                                num1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter number2:");
                                num2 = int.Parse(Console.ReadLine());
                                total = num1 + num2;
                                Console.WriteLine("Total is: " + total);
                                for (int i = 0; i < total; i++)
                                {
                                        Random r = new Random();
                                        int duration, freq;
                                        freq = r.Next(500, 1000);
                                        duration = r.Next(800, 1000);
                                        Console.WriteLine("Beep Frequency: " + freq + "Hz - Beep Duration: " + duration + "ms");
                                        Console.Beep(freq, duration);

                                }
                        }
                        catch (Exception)
                        {

                                throw;
                        }
                }
        }
}
