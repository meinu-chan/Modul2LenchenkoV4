using System;
using System.Runtime.CompilerServices;

namespace M2LenchenkoV4
{
    class LeafFactory
    {
        public static MainComp CreateNewChild()
        {
            Console.WriteLine("Want some more distribution?");
            switch (Console.ReadLine())
            {
                case "y":
                    return new SubLeaf();
                case "n":
                    return null;
                default:
                    throw new Exception("Only 'y' or 'n'.");
            }
        }

        public static int GetSaleNum()
        {
            Console.Write("Enter number of sales: ");
            int nsale = int.Parse(Console.ReadLine());
            return (nsale <= 0) ? throw new Exception("Invalid number(nsub)") : nsale;
        }

        public static int GetSubNum()
        {
            Console.Write("Enter subdistribution: ");
            int nsub = int.Parse(Console.ReadLine());
            return (nsub <= 0) ? throw new Exception("Invalid number(nsub)") : nsub;
        }

    }
}