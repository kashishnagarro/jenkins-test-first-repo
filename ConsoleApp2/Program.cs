using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //List<string> li = new List<string> {
            //"The selected lineal(s) will receive a 1/8\" deduction off of the width for inside mount selection."
            //};
            //string a = JsonConvert.SerializeObject(li);
            //Console.WriteLine(a);

            //Dictionary<int, string> di = new Dictionary<int, string> { { 1, "1" }, { 2, "2" }, { 3, "3" } };

            //foreach(var kv in di.Keys.ToList())
            //{
            //    di[kv] = "4";
            //}
            //var li1 = new List<string> { "11", "22", null, "33", "44", "55", null, null };

            //try
            //{
            //    var aa = li1.Single(x => x.Equals("44"));
            //}
            //catch (Exception e)
            //{
            //    var ab = li1.SingleOrDefault(x => x.Equals("55"));
            //}

            //var di1 = new Dictionary<int, int>
            //{
            //    {1,10},
            //    {2,12},
            //    {3,23},
            //    {4,0},
            //    {5,25},
            //    {6,0}
            //};

            ////di1.GetValueOrDefault
            //var di2 = new Dictionary<string, string>
            //{
            //    { "111","kkk" },
            //    {"222","lll" },
            //    {"333","ksjdh" }
            //};
            //string ab = null;
            //Console.WriteLine("kkk".Equals(null));



            //var a = di1.Where(a => a.Value > 0).ToDictionary(a => a.Key, a => a.Value);


            //var dictGroup = new Dictionary<string, int> { { "mm1", 1 }, { "mm2", 2 }, { "mm3", 1 } };

            var lineItems = new List<LineItem>
            {
                new LineItem{Id=1, Product="p1",Quantity=2, FeatureOptions = new Dictionary<string, string>{{ "ModelNumber","mm1"}} },
                new LineItem{Id=2, Product="p1",Quantity=4, FeatureOptions = new Dictionary<string, string>{{ "ModelNumber","mm2"}} },
                new LineItem{Id=3, Product="p1",Quantity=6, FeatureOptions = new Dictionary<string, string>{{ "ModelNumber","mm2"}} },
                new LineItem{Id=4, Product="p1",Quantity=8, FeatureOptions = new Dictionary<string, string>{{ "ModelNumber","mm2"}} },
                new LineItem{Id=5, Product="p1",Quantity=10, FeatureOptions = new Dictionary<string, string>{{ "ModelNumber","mm3"}} }
            };

            Type p = (new { Product = "", Quantity = 1 }).GetType();

            IEnumerable <IGrouping<().GetType(),LineItem>> a = lineItems.GroupBy(x => new { x.Product, x.Quantity });
            //a.Where(x=>x.Key.)
            Console.WriteLine(a.GetType().ToString());


            //var a = lineItems.SingleOrDefault(x => x.Id > 3);

            //var luData1 = lineItems.ToLookup(x => x.FeatureOptions["ModelNumber"], x => x.Quantity);
            //var luData = lineItems.ToLookup(x => dictGroup[x.FeatureOptions["ModelNumber"]], x => x.Quantity);
            //var diData = luData.ToDictionary(x => x.Key, x => x.Sum(y => y));
            //IEnumerable<string> li1 = new List<string>();
            //IEnumerable<string> li2 = new List<string> { "11", "22" };

            //List<string> li3 = li2.Concat(li1).ToList();

            Console.ReadLine();
        }

        static string GetValueOrDefault(string pn, Dictionary<string, string> di)
        {
            return di.ContainsKey(pn) ? di[pn] : null;
        }
    }

    public class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public Dictionary<string, string> FeatureOptions { get; set; }
    }
}
