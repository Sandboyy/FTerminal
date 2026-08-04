using System.Linq;
using System.Text;
using AJ.Terminal.Classes;

string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray();

foreach (string arq in docs)
{
    Console.WriteLine($">> {Path.GetFileNameWithoutExtension(arq)}");
}

//Adicionado rotina para leitura de arquivos, para ser utilizada no futuro
var arquivo = @"D:\repositoriosC#\FTerminal\Uses\ultima_verificacao.txt";
using (var stream = new FileStream(arquivo, FileMode.Open))
{
    var reader = new StreamReader(stream);

    while (!reader.EndOfStream)
    {
        Console.WriteLine(reader.ReadLine());
    }
}
//Fim da rotina de Leitura de arquivos

//Teste da lista de palavras
Hacking h = new Hacking();
int opcaoCorreta = h.GenerateHackingEnviroment();
Console.WriteLine(Words.wordSort[opcaoCorreta]);
Console.WriteLine("Insira a senha: ");
string senha = Console.ReadLine()!;
h.CheckWord(opcaoCorreta, senha);