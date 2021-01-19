using System;
using System.Collections.Generic;
namespace DeliveryElevator.Models
{
    public class Elevator
    {

        #region Private Attributes
        private static int _id;
        private int _floor;
        private int _destiny;
        private int _orderLimit;
        private List<Order> _orders;
        private int _moveTo;

        #endregion

        #region Public Properties
        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public int Destiny
        {
            get { return _destiny; }
            set { _destiny = value; }
        }

        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public int LimitOrders
        {
            get { return _orderLimit; }
            set { _orderLimit = value; }
        }

        public int Status
        {
            get { return _moveTo; }
            set { _moveTo = value; }
        }
        #endregion
        public Elevator(int floor, int destiny, int limitOrder, List<Order> list = null)
        {

            _id++;
            Orders = list ?? new List<Order>();
            Floor = floor;
            Destiny = destiny;
            LimitOrders = limitOrder;

            if (_destiny > floor) Status = 2;
            else if(_destiny < floor){ Status = 1; }
            else { Status = 0; }

        }
        #region Public Methods
      
        #endregion
    }


    public enum ElevatorStatus
    {
        Stopped = 0,
        Down = 1, 
        Up = 2,
    };
}
