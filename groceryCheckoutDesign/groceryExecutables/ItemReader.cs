using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groceryExecutables
{
    class ItemReader
    {
        private string Location;
        private StreamReader sReader;
        public JObject json;
        public ItemReader( string location)
        {
            Location = location;
            sReader = new StreamReader(Location);
            string jsonString = sReader.ReadToEnd();
            json = JObject.Parse(jsonString);
        }
    }
}
