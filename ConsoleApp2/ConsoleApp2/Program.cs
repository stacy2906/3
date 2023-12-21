using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banknote banknote = new Banknote("usd", 30, 210);
            banknote.DisplayDetals();

            Banknote banknote1 = new Banknote();
            banknote1.Name = "usd2";
            banknote1.Demonation = 60;
            banknote1.Quantity = 216;
            banknote1.DisplayDetals();

            Banknote banknote2 = new Banknote("usd3", 30, 200);
            banknote2.DisplayDetals();

            banknote.Change(20);
            banknote1.Change(5);
            banknote2.Change(-20);
            banknote.DisplayDetals();
            banknote1.DisplayDetals();
            banknote2.DisplayDetals();

            
            Console.Write("Введите цену-");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nCan afford {x}$ purchase with {banknote.Name}: {banknote.Kvo(x)}");
            Console.WriteLine($"Can afford {x}$ purchase with {banknote1.Name}: {banknote1.Kvo(x)}");
            Console.WriteLine($"Can afford {x}$ purchase with {banknote2.Name}: {banknote2.Kvo(x)}");

            Console.ReadKey();

        }
    }
}
