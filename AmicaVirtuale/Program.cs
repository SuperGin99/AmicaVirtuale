
using AmicaVirtuale;
using System;

string input;
string nome;
int punteggioApp = 0;
int punteggioUtente = 0;


Console.WriteLine("Ciao io sono la tua nuova amica virtuale! mi chiamo SuperG r/n E tu come ti chiami?");
nome = Console.ReadLine();
Console.WriteLine($"Ciao {nome}, come stai?");
input = Console.ReadLine();

switch (input.ToLower())
{
    case "bene":
        Console.WriteLine($"Mi fa piacere {nome} che tu stia bene!");
        break;
    case "male":
        Console.WriteLine($"Mi dispiace {nome}, spero che tu ti senta meglio presto.");
        break;
    case "cosi e cosi":
        Console.WriteLine($"Capisco {nome}, mi dispiace, ci sono giorni così.");
        break;
    default:
        Console.WriteLine("Grazie per aver condiviso come ti senti.");
        break;
}


Console.WriteLine($"A cosa ti va di giocare oggi, {nome}?");
Console.WriteLine("1. Indovina il numero");
Console.WriteLine("2. indovinelli");
Console.WriteLine("3. il gioco dell'eco");

input = Console.ReadLine();

switch (input.ToLower())
{
    case "1":
        Gioco gioco = new Gioco(nome);
        gioco.IndovinaNumero();
        break;
    case "2":
        
        break;
    case "3":
        
        break;
    default:
        Console.WriteLine("Devi inserire un numero.");
        break;
}






