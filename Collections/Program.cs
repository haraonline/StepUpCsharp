using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e = Enumerable.Range(1, 10);
            foreach (var i in e)
            {
                System.Console.WriteLine(i);
            }

        }
    }
}