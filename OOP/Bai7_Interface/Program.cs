using System;

namespace Bai7_Interface
{
    interface ISpeak
    {
        /*
            Khai báo phương thức nhưng không định nghĩa nội dung
         */
        void Speak();
    }

    class Animal : ISpeak // lớp Animal thực thi interface ISpeak
    {
        /*
            Định nghĩa nội dung cho phương thức trong interface
	Phương thức Speak() phải có phạm vi là public vì phương thức Speak() trong interface mặc định là public rồi.
         */
        public void Speak()
        {
            Console.WriteLine("Animal is speaking. . .");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Speak();
        }
    }
}