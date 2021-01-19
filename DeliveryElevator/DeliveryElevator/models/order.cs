using System;

namespace DeliveryElevator.Models
{
   public class Order
    {
        private int _floor;
        private int _destiny;
        private int _moveTo;

        public Order(int floor = 0, int destiny = 0)
        {
            _floor = floor;
            _destiny = destiny;

            if (_destiny > floor) _moveTo = 2;
            else { _moveTo = 1; }
        }

        public int GetMoveTo() => _moveTo;
        public int GetFloor() => _floor;
    }

}