using System.Linq;
using System.Text;
using AJ.Terminal.Classes;

string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray();
Files files = new();

files.ShowFiles(docs);
files.ReadFile();
files.WriteFile();



//Teste da lista de palavras
Hacking h = new Hacking();
int opcaoCorreta = h.GetWords();

Console.WriteLine(Words.wordSort[opcaoCorreta]);
Console.WriteLine("Insira a senha: ");
string senha = Console.ReadLine()!;
h.CheckWord(opcaoCorreta, senha);
