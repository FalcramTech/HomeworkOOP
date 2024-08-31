namespace Callc
{
    internal class Program
    {
        const char plus = '+';
        const char minus = '-';
        const char divide = '/';
        const char multiply = '*';

        static readonly char[] operations = { plus, minus, divide, multiply };

        static void Main(string[] args)
        {
            Console.WriteLine("User please enter expression (brackets and negative values not supported, exceptions not handled):!");
            string userInput = Console.ReadLine();

            userInput = userInput.Replace(" ", "");

            bool hasMultiply = userInput.Contains(multiply);
            bool hasDivide = userInput.Contains(divide);
            bool hasPlus = userInput.Contains(plus);
            bool hasMinus = userInput.Contains(minus);

            bool needRepeat = hasDivide || hasMultiply || hasMinus || hasPlus;

            while (needRepeat)
            {

                if (hasMultiply && hasDivide)
                {

                    int multiplyPosition = userInput.IndexOf(multiply);
                    int dividePosition = userInput.IndexOf(divide);

                    if (multiplyPosition < dividePosition)
                    {
                        userInput = calculate(multiplyPosition, multiply, userInput);
                    }
                    else
                    {
                        userInput = calculate(dividePosition, divide, userInput);
                    }
                }
                else if (hasMultiply)
                {

                    int multiplyPosition = userInput.IndexOf(multiply);
                    userInput = calculate(multiplyPosition, multiply, userInput);
                }
                else if (hasDivide)
                {
                    int dividePosition = userInput.IndexOf(divide);
                    userInput = calculate(dividePosition, divide, userInput);
                }
                else if (hasPlus && hasMinus)
                {
                    int plusPosition = userInput.IndexOf(plus);
                    int minusPosition = userInput.IndexOf(minus);

                    if (plusPosition < minusPosition)
                    {
                        userInput = calculate(plusPosition, plus, userInput);
                    }
                    else
                    {
                        userInput = calculate(minusPosition, minus, userInput);
                    }
                }
                else if (hasPlus)
                {
                    int plusPosition = userInput.IndexOf(plus);
                    userInput = calculate(plusPosition, plus, userInput);
                }
                else if (hasMinus)
                {
                    int minusPosition = userInput.IndexOf(minus);
                    userInput = calculate(minusPosition, minus, userInput);
                }

                hasMultiply = userInput.Contains(multiply);
                hasDivide = userInput.Contains(divide);
                hasPlus = userInput.Contains(plus);
                hasMinus = userInput.Contains(minus);

                needRepeat = hasDivide || hasMultiply || hasMinus || hasPlus;
            }

            Console.WriteLine("Result: {0}", userInput);
        }

        static string calculate(int position, char operandType, string userString)
        {
            int leftNumber = findNumber(position - 1, -1, userString);
            int rightNumber = findNumber(position + 1, 1, userString);

            string needReplace = "";
            int result = 0;

            switch (operandType)
            {
                case plus:
                    result = leftNumber + rightNumber;
                    needReplace = leftNumber + "+" + rightNumber;
                    break;
                case minus:
                    result = leftNumber - rightNumber;
                    needReplace = leftNumber + "-" + rightNumber;
                    break;
                case multiply:
                    result = leftNumber * rightNumber;
                    needReplace = leftNumber + "*" + rightNumber;
                    break;
                case divide:
                    result = leftNumber / rightNumber;
                    needReplace = leftNumber + "/" + rightNumber;
                    break;
                default:
                    Console.WriteLine("UNKNOWN OPERATION");
                    return userString;
            }

            return userString.Replace(needReplace, result.ToString());
        }

        static int findNumber(int startPosition, int direction, string userString)
        {
            int index = startPosition;
            string result = "";

            switch (direction)
            {
                case 1:
                    for (int i = startPosition; i < userString.Length - 1; i++)
                    {
                        if (operations.Contains(userString[i]))
                        {
                            break;
                        }

                        index = i;
                    }

                    result = userString.Substring(startPosition, index + 1 - startPosition);
                    break;
                case -1:
                    for (int i = startPosition; i >= 0; i--)
                    {
                        if (operations.Contains(userString[i]))
                        {
                            break;
                        }

                        index = i;
                    }

                    result = userString.Substring(index, startPosition + 1 - index);
                    break;
                default:
                    Console.WriteLine("Wrong direction");
                    break;
            }

            return Int32.Parse(result);
        }
    }
}
