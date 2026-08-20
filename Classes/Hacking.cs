namespace AJ.Terminal.Classes;

internal class Hacking
{
    public int GetWords()
    {
        Random rnd = new Random();
        //selecionando a palavra correta
        int rightOption = rnd.Next(Words.wordSort.Count);

        return rightOption;
    }

    public void GenerateHackingEnvironment()
    {
        //Implementação consistirá em definir uma quantidade específica de caracteres(pode variar dependendo da dificuldade do hackeamento, por ora trabalhar com valor fixo)
        //Necessário ser possível visualizar todas as opções "Embaralhadas"
        Random rnd = new Random();
        int caracterType;
        int qttWordsWritten = 10;
        var options = Enumerable.Range(0, Words.wordSort.Count).OrderBy(x => rnd.Next()).Take(9).ToList().AsReadOnly();
        int i = 0;



        while (i < 384)//i = define a quantidade de caracteres eu já escrevi na tela
        {
            caracterType = rnd.Next(30);
            if (caracterType != 0)
            {
                Console.Write(Caracters.caracterSort[rnd.Next(Caracters.caracterSort.Count)]);
                i++;
            }
            else
            {
                if (qttWordsWritten > 0)
                {
                    int word = options[rnd.Next(options.Count)];
                    string wordToWrite = Words.wordSort[word];
                    foreach (var chars in wordToWrite)
                    {
                        Console.Write(chars);
                        i++;
                    }
                    qttWordsWritten--;
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
            string entry = Console.ReadLine()!;
            string adjustEntry = entry.ToUpper();

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