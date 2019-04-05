using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoNeedToKnows
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo2();

            "kevin".ToJson();
           
        }

        private static void demo2() {
            var name = "kevin";
            Console.WriteLine("kevin".ToXml("name"));
            //Console.WriteLine(StringExtensions.ToXml("kevin", "name"));
            // <name>kevin</name>
        }

        private static void demo1()
        {
            Console.WriteLine("Hello World!");


            var s = 42;
            string s2 = "olivier";


            List<string> namen = new List<string>();
            namen.Add("Jan");


            IEnumerable<string> resultaat = from naam in namen
                                            select naam;
            
            Console.WriteLine(s);
        }
    }

    //static class StringExtensions {
    //    public static string ToXml(this string value, string tagnaam) {
    //        //return "<" + tagnaam + ">" + value + "</" + tagnaam + ">";
    //        return $"<{tagnaam}>{value}</{tagnaam}>";
    //    }
    //}

    public static class StringExtensions {
        public static string ToJson(this string value) {
            return $"{{name: {value}}}";
        }
    }


}
