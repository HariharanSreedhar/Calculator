namespace Calculator_Demo
{
    public class Program
    {
        // Main method to call calculator functions
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Creating new calculator object
            Calculator calci= new Calculator();
            Console.WriteLine(calci.Addition(5, 5));
            Console.WriteLine(calci.Subtraction(5, 5));
            Console.WriteLine(calci.Multiplication(5, 5));
            Console.WriteLine(calci.Division(5, 5));
        }
    }
}