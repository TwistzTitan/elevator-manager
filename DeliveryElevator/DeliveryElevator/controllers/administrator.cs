using System;
using System.Collections.Generic;
using DeliveryElevator.Models;
namespace DeliveryElevator.Controllers
{
    class Administrator 
    {   
        // Adminitrator is responsible by the selection and organization of elevators

        List<Elevator> _elevators; 

        public Administrator(){
        
        }

        private void selectElevator(Order od){
            throw new NotImplementedException();
        }

    }

    class OrderAdminitrator
    {
        private Queue<Order> _orders;

        protected Queue<Order> Orders 
        {
            get { return _orders ?? new Queue<Order>(); }
            set { _orders = value; } 
        }

        private void addOrder(Order o)
        {
            throw new NotImplementedException();
        }
        private void removeOrder()
        {
        
        }
        public void receiveOrder(Order o)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Order> selectOrderByFloor(int f) 
        {
            throw new NotImplementedException();
        }

    }
}
