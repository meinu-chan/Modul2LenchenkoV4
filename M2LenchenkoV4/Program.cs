using System;

namespace M2LenchenkoV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of sales: ");
            int nsale = int.Parse(Console.ReadLine());
            if (nsale <= 0)
                throw new Exception("Invalid number(nsale)");
            Console.Write("Enter subdistribution: ");
            int nsub = int.Parse(Console.ReadLine());
            if (nsub <= 0)
                throw new Exception("Invalid number(nsub)");
            var boss = new BossComp(nsale,nsub);
            Console.WriteLine(boss.GetTotal());
        }
    }
}
