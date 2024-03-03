using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.UI
{
    internal class WorkoutRoutineUI
    {
        public static void Menu()
        {
            Console.WriteLine("1. Display All Data");
            Console.WriteLine("2. Display Workout routine of a Person");
            Console.WriteLine("3. Add Work routine ");
            Console.WriteLine("4. Add Exercise");
            Console.WriteLine("5. Remove Exercise");
            Console.WriteLine("6. Remove Person");
            Console.WriteLine("7. Exit");
        }
        public static string Name()
        {
            string Name;
            Console.WriteLine("Enter the name of the person: ");
            Name =Console.ReadLine();
            return Name;
        }
        public static float Weight()
        {
            float Weight;
            Console.WriteLine("Enter the weight of the person: ");
            Weight = float.Parse(Console.ReadLine());
            return Weight;
        }
        public static int Index() 
        {
            int Index;
            Console.WriteLine("Enter the index: ");
            Index = int.Parse(Console.ReadLine());
            return Index;
        }
        public static string NameEx()
        {
            string Name;
            Console.WriteLine("Enter the name of the exercise: ");
            Name = Console.ReadLine();
            return Name;
        }
        public static float WeightEx() 
        {
            float Weight;
            Console.WriteLine("Enter the weight to lift: ");
            Weight = float.Parse(Console.ReadLine());
            return Weight;
        }
        public static string Repitition()
        {
            string Repitition;
            Console.WriteLine("Does this exercise have repition enter yes or no: ");
            Repitition = Console.ReadLine();
            return Repitition;
        }
        public static int EnterSets()
        {
            int EnterSets;
            Console.WriteLine("Enter the sets of the exercise: ");
            EnterSets = int.Parse(Console.ReadLine());
            return EnterSets;
        }
    }
}
