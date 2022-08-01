using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Size
    {
        public string opisanie { get; }
        public double dlina { get; }
        public double shurina { get; }
        public double vusota { get; }

        public Size(string about, double x, double y, double z)
        {
            opisanie = about;
            dlina = x;
            shurina = y;
            vusota = z;
        }
    }

    abstract class Toy
    {
        abstract public string name { get; }
        abstract public Size toySize { get; }
        abstract public void Play();
    }

    class PlushevaiaIgrushka : Toy
    {
        public override Size toySize { get; }
        public override string name { get; }
        public string nabivka { get; }

        public override void Play()
        {
            Console.WriteLine("Жмякаем");
        }
    }

    class PlastikovaiaIgrushka : Toy
    {
        public override Size toySize { get; }
        public override string name { get; }

        public override void Play()
        {
            Console.WriteLine("Щик чик");
        }
    }

    class MetalicheskiaIgrushka : Toy
    {
        public override Size toySize { get; }
        public override string name { get; }
        public string forma { get; }

        public override void Play()
        {
            Console.WriteLine("Звон метала");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            

            Toy[] myToys = {
                new PlushevaiaIgrushka(),
                new PlastikovaiaIgrushka(),
                new MetalicheskiaIgrushka()
            };


            foreach (Toy toy in myToys)
            {
                toy.Play();
            }

            Console.ReadKey();
        }
    }
}
