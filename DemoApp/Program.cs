using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> demo = new List<string>();

            demo.Add("Bob");
            demo.Add("George");
            demo.Add("Tom");
            demo.Add("Sue");

            //long way

            //for (int i = 0; i < demo.Count; i++)
            //{
            //    Console.WriteLine(demo[i]);
            //}

            //Shorter way and same results

            foreach (string name in demo)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
