using System.Drawing;

namespace figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the figure you need: ");
            Console.WriteLine("1.Qadrat: ");
            Console.WriteLine("2.Rectangle: ");
            Console.WriteLine("3.Triangle: ");
            Console.WriteLine("4.Circle: ");

            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise) 
            {
                case 1:
                    Console.WriteLine("Enter the length qadrat: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double squareArea = side * side;
                    Console.WriteLine($"Square qadrat: {squareArea}");
                    break;

                case 2:
                    Console.WriteLine("Enter the length rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the width rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double rectangleArea = width * length;
                    Console.WriteLine($"Square rectangle: {rectangleArea}");
                    break;

                case 3:
                    Console.Write("Enter the length triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = 0.5 * baseLength * height;
                    Console.WriteLine($"Square triangle: {triangleArea}");
                    break;

                case 4:
                    Console.WriteLine("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Circle Area: {circleArea}"); 
                    break;

                default:
                    Console.WriteLine("Error, choise: ");
                    break;
            }
        }
    }
}
