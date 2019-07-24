using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;
using Orders;
namespace CLients
{
    class Client : Person
    {
        private long[] a_order_id = new long[1];

        public Client(String name, String surname, String patronymic, Order ord) : base(name, surname, patronymic)
        {
            int[] s = new int[a_order_id.Length + 1];
            a_order_id[0] = ord.getOrderId();
            a_order_id.CopyTo(s, 0);
            s = new int[a_order_id.Length + 1];
            s.CopyTo(a_order_id, 0);
        }
        public void SetOrder(int order)
        {
            a_order_id[a_order_id.Length - 1] = order;
            int[] s = new int[a_order_id.Length + 1];
            a_order_id.CopyTo(s, 0);
            s = new int[a_order_id.Length + 1];
            s.CopyTo(a_order_id, 0);

        }
    }
}
