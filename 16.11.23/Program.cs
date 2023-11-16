using System;

namespace _16._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10.1.a. Работа класса ACipher:");
            Console.WriteLine("Введите текст, который хотите зашифровать:");
            string text1 = Console.ReadLine();
            ICipher cipher = new ACipher();
            Console.WriteLine("Вызов метода Encode:");
            cipher.Encode(text1);
            Console.WriteLine("Введите текст, который хотите декодировать:");
            string text2 = Console.ReadLine();
            Console.WriteLine("Вызов метода Decode");
            cipher.Decode(text2);

            Console.WriteLine("10.1.b. Работа класса BCipher:");
            Console.WriteLine("Введите текст, который хотите зашифровать:");
            string text3 = Console.ReadLine();
            ICipher cipher2 = new BCipher();
            Console.WriteLine("Вызов метода Encode:");
            cipher2.Encode(text3);
            Console.WriteLine("Введите текст, который хотите декодировать:");
            string text4 = Console.ReadLine();
            Console.WriteLine("Вызов метода Decode");
            cipher2.Decode(text4);

            Console.WriteLine("10.2");

            Point point = new Point("purple", true);
            Circle circle = new Circle(7, "hacks", true);
            Rectangle rectangle = new Rectangle(4, 6.3, "indigo", false);

            Console.WriteLine("Точка:");
            point.GetInfo();
            Console.WriteLine("Круг:");
            circle.GetInfo();
            Console.WriteLine("Параллелограмм:");
            rectangle.GetInfo();

            Console.WriteLine("Поменяем цвет и координаты:");

            point.ChangeColor("red");
            circle.ChangeColor("white");
            rectangle.ChangeColor("gray");

            point.MoveHorizontally(3.4);
            point.MoveVertically(123.78);
            Console.WriteLine("Точка:");
            point.GetInfo();

            circle.MoveHorizontally(12);
            circle.MoveVertically(34);
            Console.WriteLine("Круг:");
            circle.GetInfo();

            rectangle.MoveHorizontally(2);
            rectangle.MoveVertically(3);
            Console.WriteLine("Параллелограмм:");
            rectangle.GetInfo();

            Console.ReadKey();
        }
    }
}
