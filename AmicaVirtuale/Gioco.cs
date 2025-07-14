using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicaVirtuale
{
    class Gioco
    {
        public string nome { get; set; }
        private int punteggioApp = 0;
        private int punteggioUtente = 0;
        public Gioco(string nomeGiocatore)
        {
            // Inizializza il gioco
            nome = nomeGiocatore;
            Console.WriteLine($"Iniziamo a giocare {nome}!");
        }

        public void IndovinaNumero()
        {
            string input="si";
            Random random = new Random();

            while (input.ToLower() == "si")
            {
                Console.WriteLine("Ottimo! Pensa a un numero tra 1 e 10, e io proverò a indovinarlo. Scrivilo e io non guardo ;)");
                int numeroInserito;
                int.TryParse(Console.ReadLine(), out numeroInserito);

                if (numeroInserito < 1 || numeroInserito > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Il numero deve essere tra 1 e 10, riprova!");
                    // Sequenza di suoni per input errato
                    Console.Beep(800, 200);
                    Console.Beep(600, 200);
                    Console.Beep(400, 300);
                    Console.Beep(300, 500);

                    Console.ResetColor();
                    continue;
                }

                int numeroPensato = random.Next(1, 10);
                Console.WriteLine($"Io ho pensato al numero: {numeroPensato}");

                if (numeroPensato == numeroInserito)
                {
                    Console.WriteLine("Ho indovinato il tuo numero! Vuoi giocare ancora?");
                    punteggioApp++;
                }
                else
                {
                    Console.WriteLine($"Non ho indovinato {nome}, il tuo numero era {numeroInserito}. Vuoi giocare ancora?");
                    punteggioUtente++;
                }
                input = Console.ReadLine();
            }
            if (punteggioApp != 0 && punteggioUtente != 0)
            {
                Console.WriteLine($"Hai vinto {punteggioUtente} volte e io {punteggioApp} volte. È stato divertente giocare con te, {nome}!");
            }

            Console.WriteLine("Va bene, magari un'altra volta!");
        }

    }
}
