using System.Runtime.InteropServices;

namespace Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the your text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("Enter the entire number: ");
            int x = int.Parse(Console.ReadLine());

            string[] words = inputText.Split(' ');
            if (x >= words.Length) 
            {
                Console.WriteLine("Result: ");
            }
            else
            {

                string result = string.Join(" ", words, x, words.Length - x);    
                Console.WriteLine("Result: " +result);
            }
        }
    }
}
