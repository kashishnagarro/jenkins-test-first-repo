using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> di = null;//new Dictionary<string, string>();
            //Nullable<KeyValuePair<string, string>> iii = null;

            ////string.IsNullOrEmpty
            ////di.Add("1", "11");
            ////di.Add("2", "22");
            //List<string> li = null;// new List<string>();
            //Console.WriteLine(di?.Any() == true);
            ////Console.WriteLine(li?.count);

            //Console.WriteLine(di.Any());

            //Console.WriteLine(di.ContainsKey("1"));
            //Console.WriteLine(di["1"]);

            //Dictionary<string, Dictionary<string, List<string>>> di = new Dictionary<string, Dictionary<string, List<string>>>();
            //di.Add("Abc", new Dictionary<string, List<string>>() { { "Abc1", new List<string> { "1", "2" } }
            //,{ "Abc11", new List<string> { "1", "2" } }
            //});
            //di.Add("Abc2", new Dictionary<string, List<string>>() { { "Abc3", new List<string> { "4", "2" } } });

            //var a = JsonConvert.SerializeObject(di);

            //Console.WriteLine(a);

            //Dictionary<string, string> di = new Dictionary<string, string> { { "1", "11" } };
            //Console.WriteLine(di["1"]);
            //string a; 
            //Console.WriteLine(di.TryGetValue(di["1"],out a));
            //Console.WriteLine(di.TryGetValue(di["3"], out a));


            List<TestData> testDatas = new List<TestData>();
            testDatas.Add(new TestData { First = "1", Second = "11", Third = 4 });
            testDatas.Add(new TestData { First = "2", Second = "11", Third = 4 });
            testDatas.Add(new TestData { First = "2", Second = "22", Third = 5 });
            testDatas.Add(new TestData { First = "1", Second = "33", Third = 5 });
            testDatas.Add(new TestData { First = "1", Second = "44", Third = 5 });
            testDatas.Add(new TestData { First = "1", Second = "55", Third = 5 });

            //IEnumerable<TestData> testDatas2 = testDatas;
            //foreach (var td in testDatas2) { }

            var abc = testDatas.GroupBy(x => new { x.Third, x.First }).Select(x => new { kk = x.Key.First, ll = x.Select(y => new TestDataSecond { FN = y.Second, LN = y.First }) });

            //List<List<TestData>> testDatas1 = new List<List<TestData>>();

            //testDatas.AddRange(testDatas2);

            //var result = testDatas.GroupBy(a => new { a.Third, a.First }).Select(a => new KeyValuePair<int, long>(a.Key.Third, a.Sum(t => t.Third))).ToDictionary(x=>x.Key, x=>x.Value);
            //var result2 = (IEnumerable<TestDataSecond>)testDatas.Where(x => x.Third == 4).Select(x => 
            //  {
            //      TestDataSecond retval = null;
            //      if (x.First.Equals("1"))
            //          retval= new TestDataSecond { FN = "11" };

            //      return retval;
            //  });

            //var result3 = testDatas.Where(x => x.First.Equals("2")).Sum(x => x.Third);

            //var di = new Dictionary<int, long> { { 1, 10 }, { 2, 20 }, { 3, 30 } };


            //var di1 = di.ElementAt(0);

            //Console.WriteLine();

            Model3 mo3 = new Model3()
            {
                ProductName = "PowerSupplies",
                QuantityM = 20,
                Details = new List<List<Model2>>{
                    new List<Model2>
                        {
                            new Model2{ QuantityMissing=5,Value=new Model1{ ModelNumber="mn1",NumberOPs=5,Technology="tech1" } },
                            new Model2{ QuantityMissing=4,Value=new Model1{ ModelNumber="mn2",NumberOPs=5,Technology="tech2" } },
                            new Model2{ QuantityMissing=3,Value=new Model1{ ModelNumber="mn3",NumberOPs=5,Technology="tech3" } }
                        },
                    new List<Model2>
                        {
                            new Model2{ QuantityMissing=5,Value=new Model1{ ModelNumber="mn11",NumberOPs=5,Technology="tech11" } },
                            new Model2{ QuantityMissing=4,Value=new Model1{ ModelNumber="mn22",NumberOPs=5,Technology="tech22" } },
                            new Model2{ QuantityMissing=3,Value=new Model1{ ModelNumber="mn33",NumberOPs=5,Technology="tech33" } }
                        }
                }
            };

            var mo4 = new List<Model4>
            {
                new Model4{ActualQuantity=5, GroupKey=1,ModelNumber="mn1", NoOfOutputs=10, Quantity=1, Technology="Tech1" },
                new Model4{ActualQuantity=5, GroupKey=1,ModelNumber="mn2", NoOfOutputs=10, Quantity=1, Technology="Tech2" },
                new Model4{ActualQuantity=2, GroupKey=2,ModelNumber="mn3", NoOfOutputs=1, Quantity=2, Technology="Tech3" },
                new Model4{ActualQuantity=2, GroupKey=2,ModelNumber="mn4", NoOfOutputs=1, Quantity=2, Technology="Tech3" },
                new Model4{ActualQuantity=2, GroupKey=2,ModelNumber="mn5", NoOfOutputs=1, Quantity=2, Technology="Tech3" },
                new Model4{ActualQuantity=2, GroupKey=2,ModelNumber="mn6", NoOfOutputs=1, Quantity=2, Technology="Tech3" }
            };

            //var obj1 = mo4.GroupBy(x => new { x.GroupKey }).Select(x => new Model2 { 
            //QuantityMissing=x.Sum(y=>y.Quantity),
            //Value
            //});
            var obj1 = mo4.GroupBy(x => new { x.GroupKey }).Sum(x => x.ElementAt(0).ActualQuantity);
            Console.WriteLine(JsonConvert.SerializeObject(mo3));

            Console.ReadLine();
        }

        static int TestMethod(TestData td)
        {
            return td.Third;
        }
    }

    public class TestDataSecond
    {
        public string FN { get; set; }
        public string LN { get; set; }
    }

    public class TestData
    {
        public string First { get; set; }
        public string Second { get; set; }
        public int Third { get; set; }
    }

    public class Model1
    {
        public string ModelNumber { get; set; }
        public string Technology { get; set; }
        public int NumberOPs { get; set; }
    }

    public class Model2
    {
        public Model1 Value { get; set; }
        public long QuantityMissing { get; set; }
    }

    public class Model3
    {
        public string ProductName { get; set; }
        public long QuantityM { get; set; }
        public List<List<Model2>> Details { get; set; }
    }

    public class Model4
    {
        public string ModelNumber { get; set; }
        public string Technology { get; set; }
        public int NoOfOutputs { get; set; }
        public long Quantity { get; set; }
        public long ActualQuantity { get; set; }
        public int GroupKey { get; set; }
    }
}
