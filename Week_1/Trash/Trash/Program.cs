using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash
{
    public class Person
    {
        public int age = 18;
        public string name = "Badmash";
        public bool gender = true;
        
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(age);
        }
    }
    class Hamza
    {
        public bool bike = true;
        public Person person = new Person();
        public void Print()
        {
            Console.WriteLine("YES");
            person.Print();
        }
    }
    public class zindagi
    {
        public string life = "Just living And Breathing";
        public string qoute = "A Good Person is a dead person";
        public void Print()
            {
            Console.WriteLine(life);
            Console.WriteLine(qoute);
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hamza hamza = new Hamza();
            hamza.Print();
            zindagi Life = new zindagi();
            Life.Print();
            Console.ReadKey();
        }
    }
}
