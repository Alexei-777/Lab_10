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
            Console.WriteLine("Введите количество градусов угла");
            double gradus = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество минут угла");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество секунд угла");
            double sec = double.Parse(Console.ReadLine());
            var Radians = string. (gradus + min / 60 + sec / 3600) * (Math.PI) / 180;
            if (gradus < 0)
                Radians = -Radians;
            Console.WriteLine("Значение данного угла в радианах=" + Radians);
            Console.ReadKey();
        }
    }
    class Ygol
    {
        private double gradus;
        private double min;
        private double sec;
       
        public double Gradus
        {
            set
            {
                if (value > 0) { gradus = value; }
                else { Console.WriteLine("Не соответствует параметтрам"); }
            }
            
        }
        public 

        
    }
}
