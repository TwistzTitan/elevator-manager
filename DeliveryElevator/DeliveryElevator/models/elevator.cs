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
        private int _status;

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
            get { return _status; }
            set { _status = value; }
        }
        #endregion
        public Elevator(int floor, int destiny, int limitOrder,int status, List<Order> list = null)
        {

            _id++;
            Orders = list ?? new List<Order>();
            Floor = floor;
            Destiny = destiny;
            LimitOrders = limitOrder;
            Status = status;

        }
        #region Public Methods
        public int getOrderLimit() => LimitOrders;

        #endregion
    }
}
