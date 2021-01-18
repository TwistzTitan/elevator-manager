using System;

namespace DeliveryElevator.Models
{
   public class Order
    {
        private int _floor;
        private int _destiny;

        public Order(int floor = 0, int destiny = 0)
        {
            _floor = floor;
            _destiny = destiny;
        }
    }

}