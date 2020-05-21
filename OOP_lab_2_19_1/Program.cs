using System;

namespace OOP_lab_2_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Дитина");
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Пiдлiток");
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Юнак");
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    Console.WriteLine("Молода людина");
                    break;
                default:
                    Console.WriteLine("Доросла людина");
                    break;
            }
        }
    }
}
