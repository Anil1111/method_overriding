using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
     class BaseClass
        {
            public virtual string YourCity()
            {
                return "Dallas";
            }
        }

        class DerivedClass : BaseClass
        {
            public override string YourCity()
            {
                return "Irving";
            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                DerivedClass d = new DerivedClass();
                string city = d.YourCity();
                Console.WriteLine(city);
                Console.ReadLine();
            }
     }
}


