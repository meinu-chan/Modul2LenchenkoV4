using System;

namespace M2LenchenkoV4
{
    class Program
    {
        static void Main(string[] args)
        {            
            var boss = new BossComp(LeafFactory.GetSaleNum(),LeafFactory.GetSubNum());
            Console.WriteLine(boss.GetTotal());
        }
    }
}
