using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Processando...");
Console.WriteLine("\n");
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("21", "997654872", "Modelo 1", 32);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("21", "997654872", "Modelo 2", 16);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();