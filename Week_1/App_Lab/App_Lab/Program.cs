using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int size = 50;
            int display = 0;
            int catchValue = 0;
            string[] fruitName = new string[size];
            int[] fruitNumber = new int[size];
            float[] fruitPrice = new float[size];
            string name;
            while (count != 1)
            {
                Console.Clear();
                role();
                name = Console.ReadLine();
                if (name == "Admin")
                {
                    catchValue = RealAdmin();
                    if(catchValue == 1)
                    {
                        Console.WriteLine("Enter the number of fruits you want to add in your Shop");
                        size = int.Parse(Console.ReadLine());
                        adminmenu(size, fruitName, fruitNumber, fruitPrice);
                        display++;
                    }
                    else if(catchValue == 2 && display !=0)
                    {
                        DisplayAfterCustomerBought(size, fruitName, fruitNumber, fruitPrice);
                    }
                }
                else if (name == "Client")
                {
                    clientMenu(size, fruitName, fruitNumber, fruitPrice);
                }
                else if (name == "Exit")
                {
                    count = 1;
                }
            }
        }
        static void role()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Admin");
            Console.WriteLine("Client");
            Console.WriteLine("Exit");
        }
        static void adminmenu(int size, string[] fruitName, int[] fruitNumber, float[] fruitPrice)
        {
            Console.Clear();
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the name of Fruit number {i + 1}: ");
                fruitName[i] = Console.ReadLine();
                Console.WriteLine($"Fruit number of {fruitName[i]}: ");
                fruitNumber[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Price of {fruitName[i]} per piece: ");
                fruitPrice[i] = float.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
        static void clientMenu(int size, string[] fruitName, int[] fruitNumber, float[] fruitPrice)
        {
            float bill = 0;
            int numOfFruit=0;
            int fruitSize;
            int count = 0;
            Console.Clear();
            Console.WriteLine("The name and Prices and amount of the Fruits are Given Below:");
            Console.WriteLine("Name\t\t\tPrice Per Piece\t\tNumber of Fruites");
            
            for (int i = 0;i<size;i++)
            {
                Console.WriteLine($"{fruitName[i]}\t\t\t{fruitPrice[i]}\t\t\t{fruitNumber[i]}");
            }
            
            Console.Write("Enter the number of fruits you want to buy: ");
            fruitSize = int.Parse(Console.ReadLine());
            string[] nameOfFruitBought = new string[fruitSize];
            int[] numberOfFruitBought = new int[fruitSize];
           
            for (int i = 0;i<fruitSize ; i++)
            {
                Console.Write("Enter the name of fruit: ");
                nameOfFruitBought[i] = Console.ReadLine();
                Console.Write($"Enter the number of {nameOfFruitBought[i]}: ");
                numberOfFruitBought[i] = int.Parse(Console.ReadLine());
                fruitNumber[i] = fruitNumber[i] - numberOfFruitBought[i];
                count++;
            }

            int j = 0;
            for (int i = 0; j<count ; i++)
            {
                if (nameOfFruitBought[j] == fruitName[j])
                {
                       bill += (numberOfFruitBought[i] * fruitPrice[i]);
                    numOfFruit += numberOfFruitBought[i];
                       j++;
                }
            }
            j = 0;

            Console.WriteLine($"The name of the fruits boughts are: ");
            for (int i = 0; j < count; i++)
            {
                if (nameOfFruitBought[j] == fruitName[j])
                {
                    Console.WriteLine($"{nameOfFruitBought[i]}");
                    j++;
                }
            }
            Console.WriteLine($"Your Bill is {bill} and the Total pieces of all fruits combined {numOfFruit}");
            Console.ReadKey();
        }
        static void DisplayAfterCustomerBought(int size, string[] fruitName, int[] fruitNumber, float[] fruitPrice) 
        {
            Console.Clear();
            Console.WriteLine("The Name and Price and Amount of the Fruits are Given Below:");
            Console.WriteLine("Name\t\t\tPrice Per Piece\t\tNumber of Fruites\"");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{fruitName[i]}\t\t\t{fruitPrice[i]}\t\t\t{fruitNumber[i]}");
            }
            Console.ReadKey();
        }
        static int RealAdmin()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("Select one of the options.");
            Console.WriteLine("1. If you want to add data about fruits type 1");
            Console.WriteLine("2. If you want to review the previous data type 2");
            num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
