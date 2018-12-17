using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> s = new MyList<int>(5);
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);
            s.Add(6);
           
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}
