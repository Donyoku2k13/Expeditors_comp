using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Worker : Person
    {
        private DateTime employment_date { get; set; }
        private String position { get; set; }
        private int salary { get; set; }
        public Worker() : base()
        { }

    }
}