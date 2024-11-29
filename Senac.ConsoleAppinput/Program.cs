// See https://aka.ms/new-console-template for more information
Console.Write("B");
Console.Write("o");
Console.Write("a");

Console.WriteLine("noite");

Console.WriteLine();
for ( int I = 0; I < 10; I++ )
{ 
  for (int i = 0; i < 100; i++)
  {
    Console.Write("x");
    Console.Write("-");
    Thread.Sleep(10);
  }
  Console.WriteLine();
}
Console.Write("Ola digite seu nome: ");
string[] Linhas = Console.ReadLine().Split(" ");
for (int i = 0; i < Linhas.Length; i++)

{
    Console.WriteLine(Linhas[i]);
}


