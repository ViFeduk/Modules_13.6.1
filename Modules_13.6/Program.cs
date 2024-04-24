using System.Diagnostics;

namespace Modules_13._6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Fed_w\Downloads\Text1.txt";
            List<string> list = new List<string>();
            var stopWatch = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(path))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    list.Add(str);
            }
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
