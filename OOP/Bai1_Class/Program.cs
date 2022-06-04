using System;

namespace Bai1_Class
{
    class Animal
    {
        private double Weight;
        private double Height;
        public double weight { 
            get { return Weight;  }
            set { if (value > 0) Weight = value; } 
        }
        public double height { 
            get { return Height; } 
            set { if (value > 0) Height = value; }
        }

        
        public void Info ()
        {
            Console.WriteLine("Height: " + Height );
            Console.WriteLine("Weight: " + Weight );
        }

        public Animal ()
        {
            this.Weight = 0;
            this.Height = 0;    
        }
        public Animal (double w, double h)
        {
            this.Weight = w;
            this.Height = h;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.weight = 20;
            animal.height = 50;

            animal.Info();
            Console.WriteLine();

            Animal animal1 = new Animal(30, 57);
            animal1.Info();
            Console.WriteLine();

            Animal animal2 = new Animal();
            animal2.Info();
            Console.WriteLine();

            animal2.weight = 50;
            animal2.height = 100;

            Console.WriteLine("Weight: " + animal2.weight);
            Console.WriteLine("Height: " + animal2.height);

            Console.ReadKey();
        }
    }
}
