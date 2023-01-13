using System;
using System.Collections.Generic;

namespace groceryCheckoutDesign
{
    public class Cart
    {
        public List<Item> ItemList;
        public float Total { get { return this.CaliculateTotal(); }}

        public float CaliculateTotal() {
            float t = 0;
            this.ItemList.ForEach((Item i) => { t += i.price; });
            return t;
        }
    }
}
