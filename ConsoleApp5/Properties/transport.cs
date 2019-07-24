using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orders;
namespace Transports
{
    class Transport
    {
        private int maxVolume { get; set; }
        private int curVolume { get; set; }
        private int maxCap { get; set; }
        private int curCap { get; set; }
        private int trId { get; set; }
        private int from { get; set; }
        private int to { get; set; }
        public Transport(int tId, int vol, int w)
        {
            trId = tId;
            maxVolume = vol;
            maxCap = w;
        }

        public bool Order(Order ord)
        {
            if (curCap == 0 && curVolume == 0)
            {
                return First_order(ord);

            }
            if (checkVolume(ord) == checkWeight(ord) == checkFromTo(ord) == true)
            {
                curCap += ord.getWeight();
                curVolume += ord.getVolume();
                return true;
            }
            return false;
        }
        public bool First_order(Order order)
        {
            this.from = order.getFrom();
            this.to = order.getTo();
            this.curCap = order.getWeight();
            this.curVolume = order.getVolume();
            return true;

        }

        public bool checkWeight(Order ord)
        {
            if (curCap + ord.getWeight() > maxCap) { return false; }
            else { return true; }

        }
        public bool checkVolume(Order ord)
        {
            if (curVolume + ord.getVolume() > maxCap)
            { return false; }
            else
            { return true; }
        }
        public bool checkFromTo(Order ord)
        {
            if (from == ord.getFrom() && to == ord.getTo()) { return true; }
            else { return false; }
        }
        public void getInfo()
        {
            Console.WriteLine($"max Volume of car: {maxVolume}m3    current Volume: {curVolume}m3");
            Console.WriteLine($"max Capacity of car: {maxCap}kg     current Capacity: {curCap}kg");
            Console.WriteLine($"Transport ID: {trId}");
        }
    }
}
