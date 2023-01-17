using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using groceryCheckoutDesign;
using Newtonsoft.Json.Linq;

namespace groceryExecutables
{
    class Program
    {
        public JObject json;
        private ItemReader reader;
        private Cart cart;

        public Program()
        {
            reader = new ItemReader("C:\\Users\\thums01\\Desktop\\New folder\\groceryCheckoutDesign\\groceryCheckoutDesign\\itemData.json");
            json = reader.json;
            cart = new Cart();
            cart.ItemList = new List<Item>();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            bool cs = true;
            while (cs) {
                Console.WriteLine("Input Item Name");
                p.SearchByName(Console.ReadLine());
                Console.WriteLine("Continue Scan?");
                cs = (Console.ReadLine().ToUpper() != "N");
            }
            Console.WriteLine(p.cart.Total);
        }


        public void SearchByName(String Name) {
            List<Item> i = new List<Item>(from c in json["items"].Where(x => (string)x["name"] == Name) select new Item { Id = (int)c["id"], Name = (string)c["name"], price = (float)c["price"] });
            Console.WriteLine("Input Quantity:");
            int quantity;
            int.TryParse(Console.ReadLine(), out quantity);
            i[0].quantity = quantity;
            this.cart.ItemList.Add(i[0]);
            Console.WriteLine(i);
        
        }

        public void SearchById(int id) {
            Item i = (Item)(from c in json["items"].First(x => (int)x["id"] == id) select new Item { Id = (int)c["id"], Name = (string)c["name"], price = (float)c["price"] });
            Console.WriteLine(i);
            cart.ItemList.Add(i);
        }
    }
}
