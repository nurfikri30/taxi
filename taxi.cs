using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class taxi
    {
        public string nama { get; set; }
        public Boolean onduty { get; set; }
        public float pass { get; set; }

        public void status()
        {
            Console.WriteLine("nama  : {0}", nama);
            Console.WriteLine("Onduty :{0}", onduty);
            Console.WriteLine("pass  : {0}", pass);
            Console.WriteLine("{0} sedang menjemput penumpang", nama);
        }
        public void drop()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", nama);
        }

    }
}

