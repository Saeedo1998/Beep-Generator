using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Program
        {
                static void Main(string[] args)
                {
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
                        Console.Clear();
                        WriteSequentially("Welcome \r\n", 20);
                        WriteSequentially("Please browse from the currently available programs:- \r\n", 10);
                        WriteSequentially("(Program 1:- Basic) - (Program 2:- Advanced) - (Program 3:- Derp) \r\n", 10);
                        WriteSequentially("Enter the number for the desired Program: (1 - 3) \r\n", 10);
                        
                        int programToLoad = int.Parse(Console.ReadLine());
                        if (programToLoad == 1)
                        {
                                Program1();
                                DisplayRestartMessage();
                                Restart();
                        }
                        else if (programToLoad == 2)
                        {
                                Program2.NotMain();
                                DisplayRestartMessage();
                                Restart();
                        }
                        else if (programToLoad == 3)
                        {
                                Program3.NotMain();
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
                public static void WriteSequentially(string text, int speed)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                //Thread.Sleep(speed);
                                new System.Threading.ManualResetEvent(false).WaitOne(speed);
                                //Task.Delay(speed).Wait(); // Wait 2 seconds with blocking
                                //await Task.Delay(2000); // Wait 2 seconds without blocking

                        }
                }
                public static void WriteSequentially(string text, TimeSpan time)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                //Thread.Sleep(time);
                                new System.Threading.ManualResetEvent(false).WaitOne(time);

                        }
                }
                public static void WriteSequentially(string text)
                {
                        foreach (var var in text)
                        {
                                Console.Write(var);
                                //Thread.Sleep(90);
                                new System.Threading.ManualResetEvent(false).WaitOne(90);

                        }
                }
                public static void Program1()
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

                public static void DisplayRestartMessage()
                {
                        Console.WriteLine("Thank you, " + Environment.UserName.ToString() + ". " +
                                        "Your cooperation is much appreciated");
                        Thread.Sleep(1750);
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
        }
}
