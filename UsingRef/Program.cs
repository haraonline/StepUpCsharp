namespace UsingRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            int originalValue = 5;

            Console.WriteLine($"Original value before calling the method: {originalValue}");
            obj.ModifyValue(ref originalValue);
            Console.WriteLine($"Original value after calling the method: {originalValue}");
        }
    }


    public class MyClass
    {
        public void ModifyValue(ref int number)
        {
            number = number * 2;
            Console.WriteLine($"Modified value inside the method: {number}");
        }
    }
}