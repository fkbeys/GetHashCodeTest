using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.SpeedTests
{
    public class StringBuilderSpeedTest
    {
        public StringBuilderSpeedTest()
        {
            int iterations = 50000;

            Stopwatch stopwatch = new Stopwatch();

            // "string" ile dize birleştirme performans testi
            stopwatch.Start();
            string yazi = "";
            for (int i = 0; i < iterations; i++)
            {
                yazi = yazi + i.ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("String Concatenation Time: " + stopwatch.Elapsed);

            // "StringBuilder" ile dize birleştirme performans testi
            stopwatch.Reset();
            stopwatch.Start();
            StringBuilder sbyazi = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sbyazi.Append(i.ToString());
            }
            stopwatch.Stop();
            Console.WriteLine("StringBuilder Time: " + stopwatch.Elapsed);
        }
    }
}

