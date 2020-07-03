using System;
using System.Runtime.CompilerServices;

namespace M2LenchenkoV4
{
    class LeafFactory
    {
        public static MainComp CreateNewChild(SubLeaf sb)
        {
            Console.WriteLine("Want some more distribution?");
            switch (Console.ReadLine())
            {
                case "y":
                    return new SubLeaf();
                case "n":
                    sb.GetTotal();
                    return sb;
                default:
                    throw new Exception("Only 'y' or 'n'.");
            }
        }

        //private static int GetSaleNum()
        //{
        //    Console.Write("Enter number for children's sales: ");
        //    int n = int.Parse(Console.ReadLine());
        //    if (n <= 0)
        //        throw new Exception("Invalid number(SubLeaf19)");
        //    return n;
        //}
    }
}