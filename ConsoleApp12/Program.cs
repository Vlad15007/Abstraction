using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
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
        string name;
        public Size toySize {get;}

        public void Play()
        {
            Console.WriteLine("Играемся с " + name);
        }

        public Toy(string name, Size toySize)
        {
            this.name = name;
            this.toySize = toySize;
        }
    }

    class PlushevaiaIgrushka : Toy
    {
        public string nabivka { get; }

        public PlushevaiaIgrushka(string name, Size toySize, string nabivka) 
            : base(name, toySize)
        {
            this.nabivka = nabivka;
        }
    }

    class VzroslaiaIgrushka : Toy
    {
        public string material { get; }

        public VzroslaiaIgrushka(string name, Size toySize, string material)
            : base(name, toySize)
        {
            this.material = material;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Toy lisichka = new PlushevaiaIgrushka("Лисичка", new Size("Маленькая", 24, 17, 17), "Холлофайбер");
            Toy dino = new PlushevaiaIgrushka("Динозавр", new Size("Очень маленький", 24, 17, 17), "Синтипух");
            Toy laila = new VzroslaiaIgrushka("Неоправдвнно дорого", new Size("Стандарт", 20, 14, 14), "Силикон");


            Toy[] myToys = {
                lisichka,
                dino,
                laila
            };
            

            foreach(Toy toy in myToys)
            {
                toy.Play();
            }
            
            Console.ReadKey();
        }
    }
}
