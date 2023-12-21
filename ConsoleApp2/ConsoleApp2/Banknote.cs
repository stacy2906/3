using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Banknote
    {
        private string name;
        private int demonation;
        private int quantity;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be null");
                }
            }
        }

        public int Demonation

        {
            get { return demonation; }
            set
            {
                if (value > 0)
                {
                    demonation = value;
                }
                else
                {
                    Console.WriteLine("Demonation must be a positive number");
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity must be a positive number");
                }
            }

        }

        public Banknote() { }

        public Banknote(string name, int demonation , int quantity)
        {
            Name = name;
            Demonation = demonation;
            Quantity = quantity;

        }

        public void DisplayDetals()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Demonation:" + Demonation);
            Console.WriteLine("Quantity:" + Quantity);
        }

        public void Change(int change)
        { Quantity += change; }

        public bool Kvo(int x)
        {

            return Quantity * Demonation >= x;
        }
    }
}