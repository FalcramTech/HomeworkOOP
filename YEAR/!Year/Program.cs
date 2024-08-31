namespace _Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("year is Leap!");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("year is not Leap");
            }
            else if (year % 4 == 0) 
            {
                Console.WriteLine("year is Leap");
            }
            else 
            {
                Console.WriteLine("year is not Leap");
            }
        }
    }
}
