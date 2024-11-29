Console.ForegroundColor = ConsoleColor.Green;

string[] MenssagensInicias =
{
    "Inicializado sistema...",
    "Carregango dados",
    "Transmitindo arquivos...",
    "Conectando ao servidor remoto..."
};


foreach (var msg in MenssagensInicias)
{
    ImprimirMenssagem(msg, 100);
    Console.WriteLine();
    Thread.Sleep(100);
}
Console.ForegroundColor = ConsoleColor.Red;
ImprimirMenssagem("Todos os seus arquivos foram criptografados.", 50);
Console.WriteLine();
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Yellow;
ImprimirMenssagem("Para recuperar seus dados envie 10 BTC PARA O endereco", 30);
Console.WriteLine();
Thread.Sleep(1000);


Console.ForegroundColor= ConsoleColor.Green;
ImprimirMenssagem("\n BTC address: 1AzifFAfdfSSFRE-001", 30);
Console.WriteLine();
Thread.Sleep(1000);


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Pressione uma tecla para continuar...");
Console.ReadKey();


void ImprimirMenssagem(string texto, int tempo)

{
    foreach ( char c in texto)
    {
        Console.Write(c);
        Thread.Sleep(tempo);        
    }

}