using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace M2LenchenkoV4
{
    class SubLeaf : MainComp
    {
        private float _sale { get; set; }
        private int _salenum 
        {
            get => GetSaleNum();
        }

        private int GetSaleNum()
        {
            Console.Write("Enter number for children's sales: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
                throw new Exception("Invalid number(SubLeaf19)");
            return n;
        }

        public SubLeaf()
        {
            this._sale += 100 * this._salenum;
        }

        public override float GetTotal()
        {
            return this._sale * .05f;
        }
    }
}