using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Move
    {
        void Peredvijenie();
        string scorost { get; set; }

    }
    
    interface Fly
    {
        void Letat();
        string scorost { get; set; }

    }


    class MoveNaCheturioh : Move
    {
        public string scorost { get; set; }

        public void Peredvijenie()
        {
            Console.WriteLine(scorost + " : Топ Шлёп шмяк БУМ");
            
        }

        public MoveNaCheturioh()
        {
            scorost = "шумно и медленно";
        }
    }

    class MoveNaDvyh : Move
    {
        public string scorost { get; set; }

        public void Peredvijenie()
        {
            Console.WriteLine(scorost + " : вших вших");
        }

        public MoveNaDvyh()
        {
            scorost = "Быстро и тихо";
        }
    }

    class MoveNaTreh : Move
    {
        public string scorost { get; set; }

        public void Peredvijenie()
        {
            Console.WriteLine(scorost + " : вших вших цок");
        }

        public MoveNaTreh()
        {
            scorost = "Тихо и медленно";
        }
    }






    class Chelovek
    {
        public Move move { get; set; }
        public string name { get; set; }

        public Chelovek(string fio)
        {
            name = fio;
            move = new MoveNaCheturioh();
        }

        public void Peredvijenie()
        {
            move.Peredvijenie();
        }
    }

    class Ptica : Move, Fly
    {
        public string name { get; set; }

        string Move.scorost { get; set; }
        string Fly.scorost { get; set; }

        public Ptica(string ptica)
        {
            name = ptica;
        }

        public void Peredvijenie()
        {
            Console.WriteLine("шляп шляп");
        }

        public void Letat()
        {
            Console.WriteLine("фщщщщщщщщщ фух");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Chelovek chelovek = new Chelovek("Человек Борис");
            chelovek.Peredvijenie();

            Console.WriteLine("\n11 месяцев");
            chelovek.move = new MoveNaDvyh();
            chelovek.Peredvijenie();

            Console.WriteLine("\n840 месяцев");
            chelovek.move = new MoveNaTreh();
            chelovek.Peredvijenie();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Ptica oriol = new Ptica("Орёл");
            oriol.Letat();
            oriol.Peredvijenie();

            Console.ReadKey();
        }
    }
}
