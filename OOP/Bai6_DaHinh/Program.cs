using System;

namespace Bai6_DaHinh
{
    //- virtual: từ khóa dùng để khai báo 1 phương thức ảo (phương thức có thể ghi đè lên được)
    //- override: từ khóa dùng để đánh dấu phương thức ghi đè lên phương thức của lớp cha
    
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking");
        }
    }

    class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }

    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking");
        }
    }

    //abstract

    abstract class Kind
    {
        public abstract void Speak();
    }

    class Human: Kind
    {
        //Phải cài đặt lại phương thức abstract được thừa kế từ lớp abstract
        public override void Speak()
        {
            Console.WriteLine("Human is speaking");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            Animal animal = new Animal();
            Human human = new Human();  

            cat.Speak();
            dog.Speak();
            animal.Speak();
            human.Speak();

            Console.ReadKey();
        }
    }
}
