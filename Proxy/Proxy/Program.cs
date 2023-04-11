using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            BankConsult c = new BankConsProxy();
            int num;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Якi документи потрiбнi для вiдкриття рахунку?");
                Console.WriteLine("2 - Як можна поповнити рахунок?");
                Console.WriteLine("3 - Яка мiнiмальна сума, яку можна зняти з банкомату?");
                Console.WriteLine("4 - Якi переваги у вашого банку?");
                Console.WriteLine("5 - Вихiд");
                Console.WriteLine();

                Console.Write("Напишiть номер запитання: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine(c.GetCons(num));
            } 
            while (num!=5);

            Console.WriteLine();
        }
    }
}
