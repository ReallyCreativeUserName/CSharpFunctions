using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFunctions
{
    
    internal class Program
    {
        //Definieren der Funktionen
        public static void SortArray(int[] array)
        {
            List<int> list = array.Where(x => x % 2 == 1).OrderBy(x => x).ToList();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    array[i] = list.First();
                    list.Remove(list.First());
                }
            }
            foreach (int item in array)
            {
                if(item == array.Last())
                {
                    Console.Write(item + "\n");
                }
                else
                {
                    Console.Write(item + ", ");
                }
            }
        }
        public static void GetReadableTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = seconds % 3600 / 60;
            int second = seconds % 60;

            Console.WriteLine(string.Format("{0:d2}:{1:d2}:{2:d2}", hours, minutes, second));
        }
        static void Main(string[] args)
        {
            //Aufruf der Funktionen

            //Sortieren von ungeraden Zahlen
            Console.WriteLine("Sortieren von ungeraden Zahlen");
            int[] arraysort1 = { 5, 8, 6, 3, 4 };
            int[] arraysort2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.Write("Eingabe: 5, 8, 6, 3, 4 | Loesung: ");
            SortArray(arraysort1);
            Console.Write("Eingabe: 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 | Loesung: ");
            SortArray(arraysort2);
            Console.WriteLine();

            //Sekunden in Stunden, Minuten und Sekunden umwandeln
            Console.WriteLine("Sekunden in Stunden, Minuten und Sekunden umwandeln");
            int seconds1 = 359999;
            int seconds2 = 86399;
            Console.Write("Eingabe: 359999 | Loesung: ");
            GetReadableTime(seconds1);
            Console.Write("Eingabe: 86399 | Loesung: ");
            GetReadableTime(seconds2);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
