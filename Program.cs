using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456", "XYZ", "0000001", 16);
Console.WriteLine($"O número do celular Nokia é {nokia.Numero}.");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tetris");

Iphone iphone = new Iphone("456789", "ABC", "1111110", 32);
Console.WriteLine($"O número do celular Iphone é {iphone.Numero}.");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Snake");