using System;
using System.Threading;

namespace ConsoleApp1
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Clear();
                        Console.WriteLine("Welcome, please proceed to choose a program to run");
                        Console.WriteLine("Program 1: Basic - Program 2: Advanced");
                        Console.WriteLine("Select program to load: 1 - 2");
                        int programToLoad = int.Parse(Console.ReadLine());
                        if (programToLoad == 1)
                        {
                                //do nothing
                        }
                        else if (programToLoad == 2)
                        {
                                Program2.NotMain();
                        }
                        else
                        {
                                Console.Error.Write("Invalid input");
                                Thread.Sleep(1000);
                                //Start process, friendly name is something like MyApp.exe (from current bin directory)
                                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                                //Close the current process
                                Environment.Exit(0);
                        }

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
        }
}
