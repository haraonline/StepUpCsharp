namespace ExceptionsAndValidations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                //Exceptions friends and good
                //Debug Assertions ?
                //Console.WriteLine("you must provide atleast one argument. exiting the program ...");
                //return;
                //throw new ArgumentException("You must provide atleast one argument. Exiting the program ...", "args");

                if (args.Any(a => string.IsNullOrEmpty(a))) //LINQ Library. This is a loop so, could be overhead ...
                    throw new ArgumentException("All args must be at least 1 character long, exiting the program ...", "args");
            }

            Console.WriteLine("START");
            Console.WriteLine("=============");

            for (int i = 0; i < args.Length; i++)
            {
                //check for null first
                if (string.IsNullOrEmpty(args[i]))
                {
                    Console.WriteLine("Argument {0} is null. Index:", +i,  i);
                    continue;
                }

                Console.WriteLine("Argument {0} is {1}", i, args[i]);
            }

            Console.WriteLine("=============");
            Console.WriteLine("END");           
        }
    }
}