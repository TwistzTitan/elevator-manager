using System;
using System.Collections.Generic;
using DeliveryElevator.Models;
using System.Linq;
namespace DeliveryElevator.Controllers
{
   public class ElevatorAdministrator 
    {   
        // Adminitrator is responsible by the selection and organization of elevators

        private List<Elevator> _elevators {
            get { return _elevators?? new List<Elevator>();}
            set { _elevators = value;}
        } 
        private Executor myExecutor{
            get { return myExecutor?? new Executor();}
            set { myExecutor = value;}
        }
        
        public ElevatorAdministrator(List<Elevator> list = null){
            
           _elevators = list?? new List<Elevator>();
        }

        private bool selectElevator(){
            throw new NotImplementedException();
        }
        private List<Elevator> selectStoppedElevator(){
            
            var elevator  =  (from i in _elevators where i._status == 0 select i).ToList();
            return elevator;
        }
        private Elevator selectRunningElevator(OrderAdministrator odA){
            throw new NotImplementedException();
        }

        public int getElevatorsNumber()=> _elevators.Count();

        public void insertElevator(Elevator ev) => _elevators.Add(ev); // TODO: When insert a elevator, notify the current executor.

    }

    class OrderAdministrator
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
            throw new NotImplementedException();
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
