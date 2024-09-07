namespace replace__2
{
    internal class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine("Enter the youe text: ");
            string input = Console.ReadLine();

            char[] textArray = input.ToArray();

            string result = "";

            for (int i = 0; i < textArray.Length; i++) 
            {
                switch ((i + 1) % 15)
                {
                    case 0:
                        textArray[i] = '?';
                            break;

                    case 5:
                    case 10:
                    case 15:
                        textArray[i] = '9';
                            break;

                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        textArray[i] = 'X';
                        break;
                }
            }
            string Result = new string(textArray);

            Console.WriteLine("Result: ");
            Console.WriteLine(Result);
        }
    }
}