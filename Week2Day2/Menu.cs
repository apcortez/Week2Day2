using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Menu
    {
        internal static void Start()
        {

            int operazione;
            do
            {
                Console.WriteLine("Benvenuto! Scegli l'operazione da fare:");
                Console.WriteLine("1 - Compra Snack");
                Console.WriteLine("2 - Aggiungi Snack");
                Console.WriteLine("0 - Per uscire");
                while(!int.TryParse(Console.ReadLine(), out operazione) || operazione<0 || operazione > 2)
                {
                    Console.WriteLine("Inserisci un'operazone valida. Riprova: ");
                }
                switch(operazione)
                {
                    case 1:
                        BuySnack();
                        break;
                    case 2:
                        AddSnack();
                        break;
                    case 0:
                        break;
                }
                Console.WriteLine("\n");
            } while (operazione != 0);
        }

        private static void BuySnack()
        {
            SnackManager.View();
            int codice;
            decimal monete;
            Console.WriteLine("Inserisci il codice dello snack: ");
            while(!int.TryParse(Console.ReadLine(), out codice))
            {
                Console.WriteLine("Codice non valido. Inserisci il numero codice: ");
            }
            Snack snackToFind = SnackManager.GetByCodice(codice);
            if(snackToFind != null)
            {
                Console.WriteLine($"Inserisci {snackToFind.Prezzo}E per comprare la merendina: ");
                decimal price = snackToFind.Prezzo;
                while(!decimal.TryParse(Console.ReadLine(), out monete))
                {
                    Console.WriteLine("Input non valido. Riprova:");
                }

                while (monete < snackToFind.Prezzo)
                {
                    monete = addCoins(monete, snackToFind.Prezzo);

                }
                if (monete > snackToFind.Prezzo)
                {
                    decimal resto = monete - snackToFind.Prezzo;
                    Console.WriteLine($"Erogazione dello snack {snackToFind.Nome}");
                    Console.WriteLine($"Resto erogato: {resto}E");
                }
                else
                {
                    Console.WriteLine($"Erogazione dello snack {snackToFind.Nome}");
                }

            }
        }

        private static decimal addCoins(decimal monete, decimal prezzo)
        {
            Console.WriteLine($"Inserisci {prezzo - monete} Euro");
            monete = monete + decimal.Parse(Console.ReadLine());
            return monete;
        }

        private static void AddSnack()
        {
            int codice;
            string nome;
            decimal prezzo;

                Console.WriteLine("Inserisci il codice numerico intero per aggiungere lo Snack: ");
                bool isValid = int.TryParse(Console.ReadLine(), out codice);
                if (isValid)
                {
                    Snack snackToFind = SnackManager.GetByCodice(codice);
                    if(snackToFind == null)
                    {
                        do
                        {
                            Console.WriteLine("Inserisci il nome dello snack: ");
                            nome = Console.ReadLine();
                        } while (nome.Length == 0);

                        Console.WriteLine("Inserire il prezzo dello snack: ");
                        while(!decimal.TryParse(Console.ReadLine(), out prezzo) || prezzo < 0)
                        {
                            Console.WriteLine("Devi inserire un prezzo valido. Riprova: ");
                        }

                        SnackManager.addSnack(codice, nome, prezzo);
                    }
                else
                {
                    Console.WriteLine("Codice già in uso.");
                }
            }
            else
            {
                Console.WriteLine("Codice inserito non valido.");
            }
            }
        }

    }

