using System;
using System.Collections.Generic;
using System.Text;

namespace M2LenchenkoV4
{
    class BossComp:MainComp
    {
        protected List<MainComp> childs { get; private set; }
        private float allSale;

        public BossComp(int alls, int subdistnum)
        {
            this.childs = new List<MainComp>();
            AddChild(this.childs, subdistnum);
            this.allSale = alls * 100;
        }

        public override float GetTotal()
        {
            return this.allSale += ChildTotal();
        }

        public override void Add(MainComp component)
        {
            Add(component);
        }

        private float ChildTotal()
        {
            float sum = 0;
            foreach (var component in this.childs)
            {
                sum += component.GetTotal();
            }
            return sum;
        }

        private void AddChild(List<MainComp> mc, int index)
        {
            for (int i = 0; i < index; i++)
            {
                mc.Add(new SubLeaf());
            }

        }
    }
}
