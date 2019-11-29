using System;
using System.Collections.Generic;

namespace MatrjoshkaProject
{
    class Program
    {
        class Matrjoshka
        {
            public static int Count = 0;
            string name;
            string color;
            int size;
            string image;

            public Matrjoshka(string _name, string _color, int _size, string _image)
            {
                name = _name;
                color = _color;
                Size = _size;
                image = _image;
                Count++;
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public int Size
            {
                get { return size; }
                set
                {
                    if(value > 0 && value <= 10)
                    {
                        size = value;
                    } else
                    {
                        size = 1;
                    }
                }
            }
            public string Image
            {
                get { return image; }
            }

            public Matrjoshka OpenMatrjoshka(string name, string color, string image)
            {
                Matrjoshka newMatrjoshka = new Matrjoshka(name, color, size-2, image);
                return newMatrjoshka;
            }
        }
        static void Main(string[] args)
        {
            List<Matrjoshka> boxOfMatrjoshkas = new List<Matrjoshka>();

            Matrjoshka matrjoshka1 = new Matrjoshka("Matrjoshka1", "green", 10, "image1");
            boxOfMatrjoshkas.Add(matrjoshka1);
            //Open Matrjoshkas
            Matrjoshka matrjoshka2 = matrjoshka1.OpenMatrjoshka("Matrjoshka2", "orange", "image2");
            boxOfMatrjoshkas.Add(matrjoshka2);
            Matrjoshka matrjoshka3 = matrjoshka2.OpenMatrjoshka("Matrjohka3", "pink", "image3");
            boxOfMatrjoshkas.Add(matrjoshka3);
            Matrjoshka matrjoshka4 = matrjoshka3.OpenMatrjoshka("Matrjohka4", "yellow", "image4");
            boxOfMatrjoshkas.Add(matrjoshka4);
            Matrjoshka matrjoshka5 = matrjoshka4.OpenMatrjoshka("Matrjohka5", "blue", "image5");
            boxOfMatrjoshkas.Add(matrjoshka5);

            foreach(Matrjoshka matrjoshka in boxOfMatrjoshkas)
            {
                Console.WriteLine($"A {matrjoshka.Color} {matrjoshka.Name} size {matrjoshka.Size} is in the box.");
            }

            Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas in the box.");

            //Take a matrjoshka from the box
            Console.WriteLine("What color matrjoshka would you take from the box?");
            string userInput = Console.ReadLine();

            for(int i = 0; i < boxOfMatrjoshkas.Count; i++)
            {
                if(boxOfMatrjoshkas[i].Color == userInput)
                {
                    Console.WriteLine($"You have taken {boxOfMatrjoshkas[i].Name} from the box.");
                    boxOfMatrjoshkas.Remove(boxOfMatrjoshkas[i]);
                    Matrjoshka.Count--;
                    break;
                }                
            }

            Console.WriteLine();

            foreach(Matrjoshka matrjoshka in boxOfMatrjoshkas)
            {
                Console.WriteLine($"Name:{matrjoshka.Name}, color: {matrjoshka.Color} is in the box");
            }

            Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas in the box.");






            Console.ReadLine();
        }
    }
}
