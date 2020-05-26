using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace M2LenchenkoV4
{
    abstract class MainComp
    {
        public MainComp() { }
        public abstract float GetTotal();
        public virtual void Add(MainComp component)
        {
            throw new NotImplementedException();
        }
    }
}
