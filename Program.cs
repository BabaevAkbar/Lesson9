using System;
using Models;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Задание 1
            // TemperatureConverter.CelsiusOfFahrenheit(50);
            // TemperatureConverter.FahrenheitOfCelsius(122);

            //Задание 2
            Car c1 = new Car("BMW", "F-10", 2024);
            (string Marka, string Model, int YearBirth) = c1;
            Console.WriteLine($"Марка машины: {Marka}. Модель: {Model}. Год выпуска: {YearBirth}.");
            Console.WriteLine("Hrrlo");
        }
    }
    
}