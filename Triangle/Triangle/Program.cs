namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangle = 5;

            for (int i = 0; i <= triangle; i++)
            {

                for (int k = 0; k < triangle - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();



            }
        }
    }
}
