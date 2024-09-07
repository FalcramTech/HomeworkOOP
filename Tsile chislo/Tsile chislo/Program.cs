namespace Tsile_chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;

            int sign = Number < 0 ? -1 : 1;

            Number = Math.Abs(Number);

            while (Number > 0)
            {
                int ostacha = Number % 10;
                Reverse = (Reverse * 10) + ostacha;
                Number = Number / 10;
            }

            Reverse *= sign;

            Console.WriteLine("Reserved number is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
