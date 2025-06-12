using DesafioPOO.Models;

// Nokia
Console.WriteLine("SMARTPHONE NOKIA");
Nokia nokia = new(numero:"123456", modelo:"Nokia N10", imei:"99999999998", memoria:256);
Console.WriteLine($"Número: {nokia.Numero}");
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();
nokia.ReceberLigacao();

// Iphone
Console.WriteLine("\nSMARTPHONE IPHONE");
Iphone iphone = new(numero: "654321", modelo:"Iphone i30 PLUS", imei:"99999999999", memoria:512);
Console.WriteLine($"Número: {iphone.Numero}");
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();