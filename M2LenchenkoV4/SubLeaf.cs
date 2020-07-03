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
            get => 100 * LeafFactory.GetSaleNum();
            set => _sale = value;
        }

        public SubLeaf()
        {
            //this._sale += this._salenum;
            this._sale += this._salenum + this.GetTotal();
            var factory = LeafFactory.CreateNewChild();
            this._sale += ((factory != null) ? factory.GetTotal() : 0);
        }

        public override float GetTotal()
        {
            return this._sale*.05f;
        }

        //private float GetValue()
        //{
        //    return (LeafFactory.CreateNewChild() == null) ? 0 : LeafFactory.CreateNewChild().GetTotal();
        //}
    }
}