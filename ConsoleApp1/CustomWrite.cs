using System;
using System.Collections.Generic;
using System.Text;

namespace BeepGenerator
{
    class CustomWrite
    {
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
