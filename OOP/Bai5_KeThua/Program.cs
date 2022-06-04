using System;

namespace Bai5_KeThua
{
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;

        public void Info()
        {
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Height: " + Height);
        }
        public Animal () {
            Weight = 0;
            Height = 0;
            Legs = 0;
        }
        public Animal(double w, double h, int l)
        {
            Weight = w;
            Height = h;
            Legs = l;
        }
    }

    //Ke Thua
    class Cat : Animal
    {
        public Cat ()
        {
            Weight = 500;
            Height = 20;
            Legs = 2;
        }
        
        //base: từ khóa để gọi đến constructor của lớp cha với danh sách tham số tương ứng
        public Cat(double w, double h, int l) : base(w, h, l)
        {

        }

        //Từ khóa new chỉ định đây là một hàm Info mới của lớp con Cat
        public new void Info()
        {
            Console.WriteLine("Info of Cat: ");
            base.Info();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat ();
            BlackCat.Info ();

            //Một đối tượng của lớp cha có thể tham chiếu đến vùng nhớ của lớp con
            Animal WhiteCat = new Cat();
            WhiteCat.Info ();

            Console.ReadKey();
        }
    }
}
