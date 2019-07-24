using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transports;
using Workers;
using Orders;
using CLients;
using ConsoleApp5;

namespace CW_15._07._19.Properties
{

    class request
    {
        //private long request_id;
        Order ord = new Order(3214, 200, 2000, 1, 2);
        private Transport tr = new Transport(321, 200, 2000);
        public void check()
        {
            if (tr.Order(ord) == true)
            {
                Console.WriteLine("Do you want to commit the request?: y/n");
                tr.getInfo();
            }
        }

        //static void Main(string[] args)
        //{
        //    request r = new request();
        //    r.check();
        //    Console.ReadKey();

        //}


    }
}




