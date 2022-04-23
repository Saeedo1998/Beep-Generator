using System;
using System.Threading;
using System.Threading.Tasks;

namespace BeepGenerator
{
    class Program
    {

        public static bool isFirstTimeRunningApp;
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
                isFirstTimeRunningApp = true;

                Console.Title = "Beep Generator";
                string Welcome = "";
                Console.Clear();
                Console.WriteLine("--------------- " + nameof(Welcome) + " --------------- \r\n");
                string[] lines = {
                    "Please browse from the currently available programs:- \r\n",
                    "(Program 1:- Basic) - (Program 2:- Advanced) - (Program 3:- Random) \r\n",
                    "Enter the number for the desired Program: (1 - 3) \r\n"};

                foreach (var line in lines)
                {
                    if (isFirstTimeRunningApp)
                    {
                        //show text slowly
                        CustomWrite.WriteSequentially(line, 10);
                    }
                    else
                    {
                        //show text normally
                        Console.Write(line);
                    }
                }

                int programToLoad = 1;

                do
                {
                    //To-Do: validate user input properly and check if number is number or not
                    int.TryParse(Console.ReadLine(), out programToLoad);
                    if (programToLoad > 3)
                    {
                        Console.Error.Write("Invalid input");
                        Console.WriteLine("");
                        //Thread.Sleep(1750);
                        //Restart();
                    }
                    else
                    {
                        break;
                    }
                } while (true);


                if (programToLoad == 1)
                {
                    Program1.Start();
                    //after program finishes running restart main thread
                    //DisplayRestartMessage();
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
                    //after program finishes running restart main thread
                    //DisplayRestartMessage();
                    Restart();
                }
                else if (programToLoad == 3)
                {
                    Program3.Start();
                    //after program finishes running restart main thread
                    //DisplayRestartMessage();
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

        public static void DisplayRestartMessage()
        {
            Console.WriteLine("Thank you, " + Environment.UserName.ToString() + ". " +
                            "Your cooperation is much appreciated");
            CustomWrite.WaitFor(1750);
        }

        public static void Restart()
        {
            //Restart app
            //Start process, friendly name is something like MyApp.exe (from current bin directory)
            isFirstTimeRunningApp = false;

            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

            //Close the current process
            //Environment.Exit(0);

        }
        public static void RunCustomProgram1()
        {
            Console.WriteLine("------------------------- Welcome to TROYA Turkish Airlines -------------------------");
            Console.ReadLine();
        }

    }
}
