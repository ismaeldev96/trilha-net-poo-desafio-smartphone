using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("79 99999-9999", "Nokia100", "00012546387451", 128);
Console.WriteLine(@$"
Nokia....
Meu Numero: {nokia.Numero}

");
BarraCarregamento("Nokia ligar para 79 98888-8888", 300);
nokia.Ligar();
BarraCarregamento("Ligação Finalizada", 200);

Console.Write("Nokia ");
nokia.ReceberLigacao();
BarraCarregamento(".", 300);

Iphone iphone = new Iphone("79 99999-9999", "Iphone14", "00012546387451", 128);
Console.WriteLine(@$"
Iphone....
Meu Numero: {iphone.Numero}

");
BarraCarregamento("Iphone ligar para 79 98888-8888", 300);
iphone.Ligar();
BarraCarregamento("Ligação Finalizada", 200);

Console.Write("Iphone ");
iphone.ReceberLigacao();
BarraCarregamento(".", 300);

static void BarraCarregamento(string texto, int tempo)
{
    //Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(" .");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();

}
