using System.ComponentModel;

namespace AJ.Terminal.Classes;

internal class Hacking
{
    Random rnd = new Random();

    public (List<int>, int) GetWords()
    {
        var options = Enumerable.Range(0, Words.wordSort.Count).OrderBy(x => rnd.Next()).Take(10).ToList();
        //selecionando a palavra correta
        int rightOption = options[rnd.Next(options.Count)];

        return (options, rightOption);
    }

    public void GenerateHackingEnvironment(List<int> options)
    {
        int caracterType;
        int qttWordsWritten = 10;
        int i = 0;



        while (i < 384)
        {
            caracterType = rnd.Next(30);
            if (caracterType != 0)
            {
                Console.Write(Caracters.caracterSort[rnd.Next(Caracters.caracterSort.Count)]);
                i++;
            }
            else
            {
                if (qttWordsWritten > 0 && i <= 376)
                {
                    int word = options[rnd.Next(options.Count)];
                    string wordToWrite = Words.wordSort[word];
                    foreach (var chars in wordToWrite)
                    {
                        Console.Write(chars);
                        i++;
                    }
                    qttWordsWritten--;
                    options.Remove(word);
                }
                else
                {
                    Console.Write(Caracters.caracterSort[rnd.Next(Caracters.caracterSort.Count)]);
                    i++;
                }

            }

        }
    }

    public void CheckWord(int correctPosition)
    {
        int attempts = 4;
        int compare = 0;
        int correctChars = 0;
        bool success = false;

        while (attempts > 0)
        {
            Console.WriteLine("Insira a senha: ");
            string entry = Console.ReadLine()!.ToUpper();

            foreach (char pos in Words.wordSort[correctPosition])
            {
                if (pos == entry[compare])
                {
                    correctChars++;
                    compare++;
                }
            }
            if (compare == Words.wordSort[correctPosition].Count())
            {
                Console.WriteLine("Entry Accepted!!!");
                success = true;
                break;
            }
            else
            {
                Console.WriteLine("Entry Denied");
                Console.WriteLine($"Likeness {compare}/{Words.wordSort[correctPosition].Count()}");
                attempts--;
                compare = 0;
                correctChars = 0;
            }
        }
        if (success != true)
        {
            Console.WriteLine("TERMINAL LOCKED");
            Console.WriteLine("PLEASE CONTACT AN ADMINISTRATOR");
        }



    }
}