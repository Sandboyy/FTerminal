namespace AJ.Terminal.Classes;

internal class Hacking
{
    public int GetWords()
    {
        Random rnd = new Random();

        //gerando uma lista e as povoando com os valores que serão disponibilizados para o hackeamento
        var options = Enumerable.Range(0, Words.wordSort.Count).OrderBy(x => rnd.Next()).Take(10).ToList().AsReadOnly();

        //selecionando a palavra correta
        int rightOption = options[rnd.Next(0, options.Count)];

        return rightOption;
    }

    public void GenerateHackingEnvironment()
    {
        //Aqui dentro vai a geração do que será visualizado pelo usuário, a listagem dos caracteres e das palavras geradas no GetWord()
        //Implementação consistirá em definir uma quantidade específica de caracteres(pode variar dependendo da dificuldade do hackeamento, por ora trabalhar com valor fixo)
        //Necessário ser possível visualizar todas as opções "Embaralhadas"
    }

    public void CheckWord(int correctPosition, string entry)
    {
        string adjustEntry = entry.ToUpper();
        int countBet = 0;
        int correctChars = 0;
        foreach (char pos in Words.wordSort[correctPosition])
        {
            if (pos == entry[countBet])
            {
                correctChars++;
                countBet++;
            }
        }
        if (countBet == Words.wordSort[correctPosition].Count())
        {
            Console.WriteLine("Entry Accepted!!!");
        }
        else
        {
            Console.WriteLine("Entry Denied");
            Console.WriteLine($"Likeness {countBet}/{Words.wordSort[correctPosition].Count()}");
        }

    }
}