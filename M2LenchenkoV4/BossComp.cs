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
            for (int i = 0; i < subdistnum; i++)
            {
                childs.Add(new SubLeaf());
            }
            this.allSale = alls * 100;
        }

        public override float GetTotal()
        {
            return this.allSale += HelpMe();
        }

        public override void Add(MainComp component)
        {
            Add(component);
        }

        private float HelpMe()
        {
            float sum = 0;
            foreach (var component in this.childs)
            {
                sum += component.GetTotal();
            }
            return sum;
        }
    }
}
