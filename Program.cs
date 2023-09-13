using Console_della_gestione_File_csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elaborazione_dati_CSV__ripasso_app_cosnole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            int fine = -1;
            while (fine != 0)
            {
                Console.Clear();
                Console.Write("Opzioni disponibili: ");
                Console.WriteLine("\n\t0 - Esci dal programma\n\t1 - Aggiungi un valore casuale alla fine di ogni record\n\t2 - Contare il numero di campi che compongono un record\n\t3 - Calcolare la lunghezza massima dei record\n\t4 - Calcola la lunghezza massima dei record \n\t5 - Inserire un numero di spazi per fissare e rendere uguale la lunghezza di tutti i record\n\t6 - Aggiungere un record\n\t7 - Mostrare dei dati scegliendo tre campi\n\t8 - Cercare un record attraverso l'inserimento di un campo chiave\n\t9 - Modificare un record\n\t10 - Cancellare logicamente un record");
                Console.Write("Scegli una opzione: ");
                fine = int.Parse(Console.ReadLine());
                switch(fine)
                {
                    case 1:
                        Class1.Istruzione1();
                        break;

                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(48, 12);
                        Console.WriteLine("Il numero di campi presenti nel file CSV sono " + Class1.Istruzione2());
                        Thread.Sleep(2000);
                        break;

                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(48, 12);
                        Console.WriteLine("Il campo più lungo ha " + Class1.Istruzione3() + " caratteri");
                        Thread.Sleep(2000);
                        break;

                    case 4:
                        Console.Clear(); // pulizia della console
                        int contatore = 9;
                        int[] MaxC = Class1.Istruzione3a();//pongo l'array uguale alla funzione Istruzione3A
                        for (int k = 0; k < contatore; k++)//ciclo for che mi permette di visualizzare i valori dell'array nella listview
                        {
                            Console.WriteLine(MaxC[k].ToString());//visualizzazione dei valori dell'array nella listview
                        }
                        break;
                  
                    case 5:
                        Class1.Istruzione4();
                        break;

                    case 6:
                        Console.Clear();
                        string[] New = new string[10];
                        Console.Write("Inserire la l'anno: ");
                        New[0] = Console.ReadLine();
                        Console.Write("inserire la nazione: ");
                        New[1] = Console.ReadLine();
                        Console.Write("Inserire i milioni di kw/ora : ");
                        New[2] = Console.ReadLine();
                        Console.Write("Inserire le note: ");
                        New[3] = Console.ReadLine();
                        Console.Write("Inserire un valore casuale tra 1 e 20: ");
                        New[4] = Console.ReadLine();
                        Console.Write("Inserire true o false: ");
                        New[5] = Console.ReadLine();
                        Class1.Istruzione5(New[0], New[1], New[2], New[3], New[4], New[5]);
                        break;

                    case 7:
                        Console.Clear();
                        int i = 0;//dichiaro la variabile i
                        StreamReader reader = new StreamReader("masserini1.csv");//dichiaro lo streamreader
                        string n = reader.ReadLine();//pongo la variabile n uguale alla lettura della prima riga del file
                        while (n != null)//ciclo while che mi permette di leggere tutte le righe del file
                        {
                            String[] split2 = n.Split(';');//dichiaro un array di stringhe
                            String[] split3 = split2[5].Split(' ');//dichiaro un array di stringhe
                            if (split3[0] == "false")//se split1 è uguale a false
                            {
                                Console.WriteLine(split2[0] + ';' + split2[1] + ';' + split2[2]);//aggiungo alla console i 3 campi
                            }
                            i++;//incremento i
                            n = reader.ReadLine();//leggo la riga successiva
                        }
                        reader.Close();//chiudo lo streamreader
                        break;

                    case 8:
                        Console.Clear();
                        Console.Write("Inserisci una nazione da ricercare: ");
                        string t = Console.ReadLine();
                        int j = Class1.Istruzione7(t);
                        if (j != -1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(30, 12);
                            Console.WriteLine("Elemento trovato alla riga" + j);
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(30, 12);
                            Console.WriteLine("Elemento non trovato");
                            Thread.Sleep(2000);
                        }
                        break;

                    case 9:
                        Console.Clear();
                        Console.Write("Inserisci la linea da modificare(utilizzare funzione 7 per trovare la linea): ");
                        int l = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Clear();
                        string[] mod = new string[10];
                        Console.Write("Inserire l'anno: ");
                        mod[0] = Console.ReadLine();
                        Console.Write("Inserire la nazione: ");
                        mod[1] = Console.ReadLine();
                        Console.Write("Inserire i milioni di kw/ora: ");
                        mod[2] = Console.ReadLine();
                        Console.Write("Inserire le note: ");
                        mod[3] = Console.ReadLine();
                        Console.Write("Inserire il numero randomico da 1 a 20 : ");
                        mod[4] = Console.ReadLine();
                        Console.Write("Inserire true o false: ");
                        mod[5] = Console.ReadLine();
                        Class1.Istruzione8(mod[0], mod[1], mod[2], mod[3], mod[4], mod[5],l);
                        break;

                    case 10:
                        Console.Clear();
                        Console.Write("Inserisci la linea da cancellare(utilizzare funzione 7 per trovare la linea): ");
                        string ricerca = Console.ReadLine();
                        Class1.Istruzione9(ricerca);
                        break;
                }
            }
            Console.Clear();
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("Fine del programma");
            Thread.Sleep(10000);
        }
    }
}
