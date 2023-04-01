namespace StepUpCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new MyClass instance with name, age, and country
            MyClass person = new MyClass(25, "John", "USA");

            // Add interests to the person's list
            person.AddInterest("Reading");
            person.AddInterest("Hiking");
            person.AddInterest("Traveling");

            // Display the person's name, age, and country
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Country: {person.Country}");

            // Display the person's list of interests
            person.DisplayInterests();

        }
    }
    

    // MyClass inherits from List<string>
    public class MyClass : List<string>
    {
        // Properties for MyClass
        public int Age { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        // Constructor for MyClass
        public MyClass(int age, string name, string country)
        {
            Age = age;
            Name = name;
            Country = country;
        }

        // Method to add a new interest to the inherited List<string>
        public void AddInterest(string interest)
        {
            this.Add(interest);
        }

        // Method to display the interests stored in the inherited List<string>
        public void DisplayInterests()
        {
            Console.WriteLine($"{Name}'s interests:");
            foreach (var interest in this)
            {
                Console.WriteLine(interest);
            }
        }
    }
}