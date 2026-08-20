using System.Linq;
using System.Text;
using AJ.Terminal.Classes;

string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray();
Files files = new();

/*files.ShowFiles(docs);
files.ReadFile();
files.WriteFile();*/



//Teste da lista de palavras
Hacking h = new Hacking();
var (listOptions, correctAnwser) = h.GetWords();
Console.WriteLine($"Opcao correta: {Words.wordSort[correctAnwser]}\n\n");
h.GenerateHackingEnvironment(listOptions);




//h.GenerateHackingEnvironment();
//h.CheckWord(opcaoCorreta);
