using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Intergers for math operations
            int a = 17;
            int b = 4;

            // Math Operators
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            // String interpolation for operations
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // Asking user input
            Console.WriteLine("What is the radius of your circle?");

            // Radius & Area calculation
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);

            // String interpolation for circle
            Console.WriteLine($"The area of the circle with radius {radius} is {area}");
        }

        //
        public static double AreaOfCircle(double radius)
        {
            // Calculate with return of area of circle
            return Math.PI * radius * radius;
        }




    }

}
