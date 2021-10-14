using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных.
//Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
//Создать объект на основе разработанного класса. Осуществить использование объекта в программе.

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ygol rad = new Ygol();
            Console.WriteLine("Введите число 1 или 2"); //Для понимания работы
            int a= Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Введите число градусов угла");
                rad.gradus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число минут угла");
                rad.min = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число секунд угла");
                rad.sec = Convert.ToDouble(Console.ReadLine());
                double Radian = (rad.gradus + rad.min / 60 + rad.sec / 3600) * (Math.PI) / 180;
                Console.WriteLine("1 вариант. Угол радиан = " + Radian); //Для понимания работы
                Console.WriteLine("1 вариант. Угол радиан = " + rad.Radian); //Для понимания работы
            }
            else
            {
                rad.Enter();
                rad.ToRadians();
            }

            Console.ReadKey();
        }

    }

    class Ygol
    {
        public double gradus;
        public double min;
        public double sec;
        public double Radian;

        public void Enter()
        {
            Console.WriteLine("Введите число градусов угла");
            this.gradus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число минут угла");
            this.min = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите число секунд угла");
            this.sec = Convert.ToDouble(Console.ReadLine());
        }
        public void ToRadians()
        {
            double Radian = (gradus + min / 60 + sec / 3600) * (Math.PI) / 180;
            Console.WriteLine("2 Вариант. Угол радиан = " + Radian);
        }



    }
}
