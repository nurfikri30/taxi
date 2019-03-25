using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class Program
    {
        static void Main(string[] args)
        {
            taxi saya = new taxi();

            saya.nama = "fikri";
            saya.onduty = true;
            saya.pass = 3f;

            saya.status();
            saya.drop();

            Console.ReadKey();
        }
    }
}
