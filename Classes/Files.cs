namespace AJ.Terminal.Classes;

internal class Files
{
    public void ShowFiles(string[] path)
    {
        foreach (string arq in path)
        {
            Console.WriteLine($">> {Path.GetFileNameWithoutExtension(arq)}");
        }
    }

    public void ReadFile()
    {
        //inicialmente, manter a leitura fixa nesse arquivo
        var arquivo = @"D:\repositoriosC#\FTerminal\Uses\ultima_verificacao.txt";
        using (var stream = new FileStream(arquivo, FileMode.Open))
        {
            var reader = new StreamReader(stream);

            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

        }
    }

    public void WriteFile()
    {
        Console.Write("Defina o nome da nova anotação: ");
        string? nameFile = Console.ReadLine();


        Console.WriteLine($"{nameFile}: ");
        string? bodyFile = Console.ReadLine();

        var arquivoEscrita = $@"D:\repositoriosC#\FTerminal\Uses\{nameFile}.txt";
        using (var stream = new FileStream(arquivoEscrita, FileMode.Create))
        {
            var writer = new StreamWriter(stream);

            writer.WriteLine(bodyFile);
            writer.Flush();
        }
    }


}