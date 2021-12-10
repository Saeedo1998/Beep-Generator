using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Program
        {
                static void Main(string[] args)
                {
                        try
                        {
                                //Console.BackgroundColor = ConsoleColor.White;
                                //Console.ForegroundColor = ConsoleColor.Black;

                                //RunCustomProgram1();
                                //int num = 0;
                                //while (true)
                                //{
                                //        Array s = new Array[];
                                //        Console.Write("-");
                                //        num++;
                                //        Thread.Sleep(100);
                                //        if (num == 10 || num == 20)
                                //        {
                                //                Console.WriteLine();
                                //                Thread.Sleep(1000);

                                //        }
                                //}
                                //Console.ForegroundColor = ConsoleColor.Green;
                                //Console.BackgroundColor = "#073605";
                                Console.Title = "Beep Generator";
                                string Welcome = "";
                                Console.Clear();
                                Console.WriteLine("--------------- " + nameof(Welcome) + " --------------- \r\n");
                                WriteSequentially("Please browse from the currently available programs:- \r\n", 10);
                                WriteSequentially("(Program 1:- Basic) - (Program 2:- Advanced) - (Program 3:- Derp) \r\n", 10);
                                WriteSequentially("Enter the number for the desired Program: (1 - 3) \r\n", 10);

                                int programToLoad = 0;
                                int.TryParse(Console.ReadLine(), out programToLoad);

                                if (programToLoad == 1)
                                {
                                        Program1.Start();
                                        DisplayRestartMessage();
                                        Restart();
                                }
                                else if (programToLoad == 2)
                                {
                                        Program2.Start();
                                        while (true)
                                        {
                                                Console.WriteLine("Restart program? (Y / N)");
                                                ConsoleKeyInfo userInput = Console.ReadKey();
                                                if (userInput.Key == ConsoleKey.Y)
                                                {
                                                        Program2.Start();
                                                }
                                                else if (userInput.Key == ConsoleKey.N)
                                                {
                                                        break;
                                                }
                                        }
                                        //DisplayRestartMessage();
                                        Restart();
                                }
                                else if (programToLoad == 3)
                                {
                                        Program3.Start();
                                        DisplayRestartMessage();
                                        Restart();
                                }
                                else
                                {
                                        Console.Error.Write("Invalid input");
                                        Thread.Sleep(1750);
                                        Restart();
                                }

                                return;
                        }
                        catch (Exception e)
                        {
                                Console.Error.WriteLine("ERROR: " + e.Message);
                                throw;
                        }
                }
                public static void WriteSequentially(string text)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                WaitFor(90);

                        }
                }
                public static void WriteSequentially(string text, int speedInMilliseconds)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                WaitFor(speedInMilliseconds);

                        }
                }
                
                public static void WriteSequentially(string text, TimeSpan time)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                WaitFor(time);

                        }
                }
                
                public static void DisplayRestartMessage()
                {
                        Console.WriteLine("Thank you, " + Environment.UserName.ToString() + ". " +
                                        "Your cooperation is much appreciated");
                        WaitFor(1750);
                }
                public static void Restart()
                {
                        //Restart app
                        //Start process, friendly name is something like MyApp.exe (from current bin directory)
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                        //Close the current process
                        Environment.Exit(0);
                }
                public static void RunCustomProgram1()
                {
                        Console.WriteLine("------------------------- Welcome to TROYA Turkish Airlines -------------------------");
                        Console.ReadLine();
                }

                public static void WaitFor(int milliseconds)
                {
                        //Thread.Sleep(speed);
                        new System.Threading.ManualResetEvent(false).WaitOne(milliseconds);
                        //Task.Delay(speed).Wait(); // Wait 2 seconds with blocking
                        //await Task.Delay(2000); // Wait 2 seconds without blocking
                }

                public static void WaitFor(TimeSpan milliseconds)
                {
                        //Thread.Sleep(speed);
                        new System.Threading.ManualResetEvent(false).WaitOne(milliseconds);
                        //Task.Delay(speed).Wait(); // Wait 2 seconds with blocking
                        //await Task.Delay(2000); // Wait 2 seconds without blocking
                }
        }
}
