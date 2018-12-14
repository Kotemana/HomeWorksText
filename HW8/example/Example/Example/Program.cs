using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            using (var reader = new StreamReader("Json.txt"))
            {
                json = reader.ReadToEnd();
            }
            GirlCollection collection = JsonConvert.DeserializeObject<GirlCollection>(json);

            foreach (var girl in collection.Girls)
            {
                Console.WriteLine($"{girl.name} works in {girl.location}");
            }
            Console.ReadLine();
        }

    }

    //this should be in separate files
    public class Price
    {
        public int Top { get; set; }
        public int Classic { get; set; }
        public int Back { get; set; }
    }

    public class Girl
    {
        public string name { get; set; }
        public string location { get; set; }
        public Price price { get; set; }
    }

    public class GirlCollection
    {
        public List<Girl> Girls { get; set; }
    }
}
