using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Order
    {
        private long a_order_id;
        private int volume;
        private int weight;
        private readonly int to;
        private readonly int from;

        public Order(long a_order, int vol, int w, int to1, int from1)
        {

            a_order_id = a_order;
            volume = vol;
            weight = w;
            to = to1;
            from = from1;
        }

        public long getOrderId()
        {
            return a_order_id;
        }
        public int getWeight()
        {
            return weight;
        }
        public int getVolume()
        {
            return volume;
        }

        public int getFrom()
        {
            return from;
        }
        public int getTo() { return to; }
        public void GetInfo()
        {
            Console.WriteLine($"Order id: {a_order_id} Order Volume: {volume}m3  Weight: {weight}");
        }

        
        
            static void Main(string[] args)
            {
            Order ord = new Order(123456, 200, 2000, 1, 2);
            ord.GetInfo();
            Console.ReadKey();
            }
        
    }
}



