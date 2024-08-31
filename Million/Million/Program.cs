namespace Million
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = {
                "Які кольори має прапор України?",
                "В якому місті знаходиться ДТЕУ?",
                "Який жанр має гра Path of Exile?",
                "Який з наступних лордів є головним антагоністом в акті 5 Path of Exile?",
                "Хто з персонажів є дочкою The Shaper і має здатність контролювати час і простір у священному домені?"
        };

            string[,] options = {
                { "Жовтий і блакитний", "Червоний і зелений", "Чорний і жовтий", "Зелений і фіолетовий" },
                { "Вінниця", "Київ", "Львів", "Одеса" },
                { "Action RPG", "Mmo RPG", "RPG", "Simulator" },
                { "Dominus", "Kitava", "Malachai", "Piety" },
                { "The Maven", "Zana", "Shavronne", "Piety" }
        };

            int[] correctAnswers = { 1, 2, 1, 2, 2 };
            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {

                Console.WriteLine("Current user score: {0}", score);
                Console.WriteLine("Question {0}, {1}", i + 1, questions[i]);


                for (int j = 0; j < options.GetLength(1); j++)
                {

                    Console.WriteLine("{0}, {1}", j + 1, options[i, j]);
                }

                Console.WriteLine("User writes: ");
                int userAnswer;
                if (int.TryParse(Console.ReadLine(), out userAnswer) & userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct answer");
                    score += 100;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    break;
                }
            }

            Console.WriteLine("The end , Your Final Score: {score}");

        }
    }
}
