namespace UsingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            int number = 5;
            int square, cube;

            obj.CalculateSquares(number, out square, out cube);

            Console.WriteLine($"Square of {number}: {square}");
            Console.WriteLine($"Cube of {number}: {cube}");
        }
    }

    public class MyClass
    {
        public void CalculateSquares(int number, out int square, out int cube)
        {
            square = number * number;
            cube = number * number * number;
        }
    }
}