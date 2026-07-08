using System.Linq;
string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray();

foreach (string arq in docs)
{
    Console.WriteLine(Path.GetFileNameWithoutExtension(arq));
}