using System;

namespace FirstHomeTask
{
    class EffectiveAirTemperature
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter value temperature in Celsius: ");
            double _T = double.Parse(Console.ReadLine());
            double T = _T / 5 * 9 + 32;
            Console.Write("Please, enter value wind speed in meters per second: ");
            double _v = double.Parse(Console.ReadLine());
            double v = _v * 2.237;
            double w = (35.74 + 0.6215 * T + (0.4275 * T - 35.75) * Math.Pow(v, 0.16) - 32) * 5 / 9;
            if ((_T < 50) && ((_v < 120) || (_v > 3))) Console.WriteLine($"   \n\nEffective temperature: {w}");
            else Console.WriteLine($"   \n\nEffective temperature: {w}      Please check the entered values!!!");
        }
    }
}
