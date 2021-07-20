using System;

namespace Esercizio1
{
            //    Distributore di snack(opzionale: uso del Dictionary) :

            //Lo snack ha:
            //- Nome
            //- Prezzo
            //- Codice

            //Mostrare un menu all’utente per far scegliere lo snack desiderata
            //Esempio:
            //Scegli:
            //1 -> per Buondì: prezzo 1 €
            //2 -> per Patatine: prezzo 0.5 €
            //3 -> per Taralli: prezzo 1.2 €
            //4 -> ...
            //ecc.

            //Una volta scelta lo snack, chiedere all’utente di inserire il denaro necessario
            //Se la quota inserita non è sufficiente richiedere nuovamente l’aggiunta di denaro e sommarla a quella già
            //inserita.Rieffettuare il controllo fino al raggiiungimento o superamento del prezzo dello snack
            //scelta.

            //Se il totale inserito è uguale al prezzo dello snack allora mostrare a video “Erogazione dello snack”.
            //Se il totale supera il prezzo dello snack, mostrare a video “Erogazione dello snack” ed anche il messaggio
            //con il resto “Resto erogato : X.XX €”
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Start();
        }
    }
}
