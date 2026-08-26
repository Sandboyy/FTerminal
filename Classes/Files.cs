namespace AJ.Terminal.Classes;

internal class Files
{
    public void ShowFiles(string[] path)
    {
        foreach (string arch in path)
        {
            Console.WriteLine($">> {Path.GetFileNameWithoutExtension(arch)}");
        }
    }

    public void ReadFile() //usando StreamReader para fazer a leitura em arquivos
    {
        //inicialmente, manter a leitura fixa nesse caminho
        var path = @"D:\repositoriosC#\FTerminal\Uses\ultima_verificacao.txt";
        using (var stream = new FileStream(path, FileMode.Open))
        {
            var reader = new StreamReader(stream);

            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

        }
    }

    public void WriteFile() //usando StreamWriter para fazer a escrita em arquivos
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