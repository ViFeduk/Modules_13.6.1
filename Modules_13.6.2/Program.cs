using System.Diagnostics;

namespace Modules_13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Fed_w\Downloads\Text1.txt";
            LinkedList<string> list = new LinkedList<string>();
            var stopWatch = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(path))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    list.AddFirst(str);
            }
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
        }
    }
}
