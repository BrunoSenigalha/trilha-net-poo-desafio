using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia");
Nokia nokia = new Nokia(numero: "16 98785887", modelo: "Modelo Generico", imei: "22544444454", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "11 9855587", modelo: "Iphone X", imei: "1111111111", memoria: 228);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsAPP");

Console.WriteLine("\n");