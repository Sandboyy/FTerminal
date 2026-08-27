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

    public List<char> GenerateHackingEnvironment(List<int> options)
    {
        int caracterType;
        int qttWordsWritten = 10; //Impede que mais de 10 palavras sejam escritas
        int i = 0;

        List<char> finalList = new List<char>();

        while (i < 384)//iniciando geração da lista de caracteres usados no hacking
        {
            caracterType = rnd.Next(30);
            if (caracterType != 0)
            {
                finalList.Add(Caracters.caracterSort[rnd.Next(Caracters.caracterSort.Count)]);
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
                        finalList.Add(chars);
                        i++;
                    }
                    qttWordsWritten--;
                    options.Remove(word);
                }
                else
                {
                    finalList.Add(Caracters.caracterSort[rnd.Next(Caracters.caracterSort.Count)]);
                    i++;
                }

            }

        }
        return finalList; //retorna a lista montada
    }

    public IEnumerable<char[]> GenerateListChunkLines(List<char> finaList)//método criado para gerar a lista separada por linhas
    {
        IEnumerable<char[]> chunks = finaList.Chunk(12);
        return chunks;
    }

    public void CheckWord(int correctPosition)
    {
        int attempts = 4; // Quantidade de tentativas
        int compare = 0; // Variável que vai comparar os acertos
        int correctChars = 0; //Variável que vai contar os caracteres corretos
        bool success = false; // Define se foi finalizado com sucesso ou não

        while (attempts > 0)
        {
            Console.WriteLine("Insira a senha: ");
            string entry = Console.ReadLine()!.ToUpper();//SERA SUBSTITUIDO PELO FRONTEND

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
                Console.WriteLine("Entry Accepted!!!");//SERA SUBSTITUIDO PELO FRONTEND
                success = true;
                break;
            }
            else
            {
                Console.WriteLine("Entry Denied");//SERA SUBSTITUIDO PELO FRONTEND
                Console.WriteLine($"Likeness {compare}/{Words.wordSort[correctPosition].Count()}");//SERA SUBSTITUIDO PELO FRONTEND
                attempts--;
                compare = 0;
                correctChars = 0;
            }
        }
        if (success != true)
        {
            Console.WriteLine("TERMINAL LOCKED");//SERA SUBSTITUIDO PELO FRONTEND
            Console.WriteLine("PLEASE CONTACT AN ADMINISTRATOR");//SERA SUBSTITUIDO PELO FRONTEND
        }



    }

    public void CheckBracket()
    {
        //preencher com o método responsável por validar o brackets de caracteres especiais
    }
}