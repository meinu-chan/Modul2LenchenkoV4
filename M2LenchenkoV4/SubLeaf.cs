using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace M2LenchenkoV4
{
    class SubLeaf : MainComp
    {
        private float sale { get; set; }

        public SubLeaf()
        {
            Console.Write("Enter number for children's sales: ");
            int salenum = int.Parse(Console.ReadLine());
            if (salenum <= 0)
                throw new Exception("Invalid number(SubLeaf18)");
            this.sale += 100 * salenum;
            MoreChildren();
        }

        private void MoreChildren()
        {
            Console.WriteLine("Want some more distribution?");
            switch(Console.ReadLine())
            {
                case "y":
                    CreateChild();
                    break;
                case "n":
                    GetTotal();
                    break;
                default:
                    throw new Exception("Only 'y' or 'n'.");
            }
        }

        private void CreateChild()
        {
            float sum = 0;
            var sb = new SubLeaf();
            sum += sb.GetTotal();
            this.sale += sum;
        }

        public override float GetTotal()
        {
            return this.sale * .05f;
        }
    }
}