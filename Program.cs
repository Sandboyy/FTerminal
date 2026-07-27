using System.Linq;
using System.Text;
string[] docs = Directory.GetFiles(@"D:\repositoriosC#\FTerminal\Uses", "*.txt").Select(f => Path.GetFileName(f)).ToArray();

foreach (string arq in docs)
{
    Console.WriteLine($">> {Path.GetFileNameWithoutExtension(arq)}");
}

//Adicionado rotina para leitura de arquivos, para ser utilizada no futuro
var arquivo = @"D:\repositoriosC#\FTerminal\Uses\ultima_verificacao.txt";

var stream = new FileStream(arquivo, FileMode.Open);

byte[] buffer = new byte[1024];
var bytesLidos = -1;
var encoder = new UTF8Encoding();

while (bytesLidos != 0)
{
    bytesLidos = stream.Read(buffer, 0, 1024);
    string texto = encoder.GetString(buffer);
    Console.Write(texto);
}
//Fim da rotina de Leitura de arquivos