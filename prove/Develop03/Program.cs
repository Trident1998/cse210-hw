using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean isContinue = true;
        Random random = new Random();
        Scripture scripture = new ScriptureHolder().GiveScripture();
        WordHandler wordHandler = new WordHandler();
        int amountOfHiding = 3;

        Console.Clear();
        Console.Write($"Profide your amount of hiding words in single iteration (by defoult it is 3): ");
        String userAmount = Console.ReadLine();
        amountOfHiding = int.Parse(userAmount);

        while (isContinue) {
            Console.Clear();

            Console.WriteLine(scripture.GetStringScripture());
            Console.Write($"\nPress rnter or type 'quite' to finish: ");

            String answer = Console.ReadLine();
            int hidenWordsCount = scripture.Words.Where(it => !it.IsHidden).Count();

            if (answer == "quite" || hidenWordsCount == 0)
            {
                isContinue = false;
            } else
            {
                wordHandler.HideWords(scripture.Words, amountOfHiding);
            }
        }
    }
}
