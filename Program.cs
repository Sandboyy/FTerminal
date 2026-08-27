using System.Linq;
using System.Text;
using AJ.Terminal.Classes;

string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray(); //Setando caminho para leitura dos arquivos, parâmetro do método GetFiles;
Files files = new();

/*files.ShowFiles(docs);
files.ReadFile();
files.WriteFile();*/



//Teste da lista de palavras
Hacking h = new Hacking();
var (listOptions, correctAnwser) = h.GetWords();
Console.WriteLine($"Opcao correta: {Words.wordSort[correctAnwser]}\n\n");//Exibindo a palavra correta para fins de testes

List<char> listaFinalTeste = h.GenerateHackingEnvironment(listOptions);

foreach (char caracter in listaFinalTeste)
{
    Console.Write(caracter);
}
Console.WriteLine("\n");

h.GenerateListChunkLines(listaFinalTeste);




//h.GenerateHackingEnvironment();
//h.CheckWord(opcaoCorreta);
