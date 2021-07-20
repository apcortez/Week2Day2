using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class SnackManager
    {
        static List<Snack> snacks = new List<Snack>()
        {
            new Snack(1, "Buondì", 1.00m),
            new Snack(2, "Patatine", 0.50m),
            new Snack(3, "Taralli", 1.20m)
        };
        

        internal static Snack GetByCodice(int codice)
        {
            foreach (Snack snack in snacks)
            {
                if (snack.Codice == codice)
                {
                    return snack;
                }
            }
            return null;
        }

        internal static void addSnack(int codice, string nome, decimal prezzo)
        {
            Snack snack = new Snack(codice, nome, prezzo);
            snacks.Add(snack);
            Console.WriteLine($"Lo snack con codice: {codice} nome: {nome} prezzo: {prezzo}€ è stato aggiunto con successo! \n");
        }

        internal static void View()
        {
            Console.WriteLine("****Snack Machine****");
            Console.WriteLine("CODICE\t\tNOME\t\tPREZZO");
            foreach (Snack snack in snacks)
            {
                Console.WriteLine(snack.Codice + "\t\t" + snack.Nome + "\t\t" + snack.Prezzo);
            }
            
        }
    }
}
