
Console.WriteLine("Programa Tradutor Baleês");
Console.WriteLine();

Console.WriteLine("Digite um texto a ser traduzido para Baleês:");
Console.WriteLine();

String textobalees = Console.ReadLine()!;

Console.WriteLine("\nTraduzindo para baleês...\n");

Console.WriteLine(textobalees
.Replace("a" , "aaa")
.Replace("e" , "eee")
.Replace("i" , "iii")
.Replace("o" , "ooo")
.Replace("u" , "uuu")
);