using System;

namespace Models
{
    public static class TemperatureConverter
    {
        private static double Temperature{ get; set; }

        public static void CelsiusOfFahrenheit(double temperatureCelsius)
        {
            Temperature = temperatureCelsius;

            double result = temperatureCelsius * 9 / 5 + 32;
            Console.WriteLine($"Температура {temperatureCelsius} градусов по Цельсию равен {result} градусов по Фаренгейту");
        }
        public static void FahrenheitOfCelsius(double temperatureFahrenheit)
        {
            Temperature = temperatureFahrenheit;

            double result2 =(temperatureFahrenheit - 32)/1.8;

            Console.WriteLine($"Температура {temperatureFahrenheit} градусов по Фаренгейту равен {result2} градусов по Цельсию");
        }
    }

    public class Car
    {
        private string Marka{ get; set; }
        private string Model{ get; set; }
        private int YearBirth{ get; set; }

        public Car(string marka, string model, int yearBirth)
        {
            Marka = marka;
            Model = model;
            YearBirth = yearBirth;
        }

        public void Deconstruct(out string carMarka, out string carModel, out int carYearBirth)
        {
            carMarka = Marka;
            carModel = Model;
            carYearBirth = YearBirth;
        }
    }
}
