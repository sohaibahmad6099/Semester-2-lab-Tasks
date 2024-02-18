using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskWeek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome To Speed Calculator");
            float distance, time;
            Console.Write("Enter The distance in Km: ");
            distance = float.Parse(Console.ReadLine());
            Console.Write("Enter Time in hours: ");
            time = float.Parse(Console.ReadLine());
            float speed = distance/time;
            if(time<=0)
            {
                Console.WriteLine("Error: Time is less than Zero");
                return;
            }
            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine($"Time: {time} hr");
            Console.WriteLine($"Your Speed is : {speed} km/hr");
            Console.WriteLine("Thank you for using the Speed Calculator");
            Console.ReadKey();
            */
            float temp;
            Char unit;
            Console.WriteLine("Welcome To Temperature Converter");
            Console.Write("Enter the Temperature: ");
            temp = float.Parse( Console.ReadLine());
            Console.Write("Enter unit of temperature: ");
            unit = Char.Parse(Console.ReadLine());
            float tempInCel, tempInFarn;
            if (unit == 'F')
            {
                tempInCel = (temp - 32) * 5 / 9;
                Console.WriteLine($"Farenheit in celsius is: {tempInCel} C");
            }
            else if(unit == 'C')
            {
                tempInFarn = (temp * 9 / 5) + 32;
                Console.WriteLine($"Celsius in Farenheit is: {tempInFarn} F");
            }
            Console.WriteLine("Thank you for using this temperature Calculator");
            Console.Read();
        }
    }
}