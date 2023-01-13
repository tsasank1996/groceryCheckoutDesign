using System;
using System.Collections.Generic;
using System.Text;

namespace groceryCheckoutDesign
{
    public class Item
    {
        public int Id;
        public int Name;
        public int price;
    }

    class PerishableItem:Item
    {
        public int quantity;
    }
    class NonPerishableItem : Item
    {
        public int Count;
    }
}
