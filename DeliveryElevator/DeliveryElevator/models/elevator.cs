using System;
using System.Collections.Generic;
namespace DeliveryElevator.Models
{
    public class Elevator 
    { 
        private static int _id;
        private int _floor;
        private int _destiny; 
        private int _orderLimit;
        private List<Order> _orders;
        public int _status;
        public Elevator(int floor, int destiny, int limitOrder, int status) 
        {
            _id++;
            _floor = floor;
            _destiny = destiny;
            _orderLimit = limitOrder;
            _status = status;
        }

        public int getOrderLimit() => _orderLimit;

        public void insertOrders() => throw new NotImplementedException();

    }
}
