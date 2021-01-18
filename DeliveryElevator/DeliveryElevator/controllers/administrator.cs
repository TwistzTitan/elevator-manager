using System;
using System.Collections.Generic;
using DeliveryElevator.Models;
using System.Linq;
namespace DeliveryElevator.Controllers
{
   public class ElevatorAdministrator 
    {   
        // Adminitrator is responsible by the selection and organization of elevators
        #region  Private Attributes
        private List<Elevator> _elevators;
        private Executor _executor;
        
        #endregion
        
        #region Public Properties
        public List<Elevator> myElevators{
            get { return _elevators?? new List<Elevator>();}
            set { _elevators = value;}
        }
        private Executor myExecutor{
            get { return _executor?? new Executor();}
            set { _executor = value;}
        }

        #endregion
        public ElevatorAdministrator(List<Elevator> list = null){
            
           myElevators = list?? new List<Elevator>();
        }

        #region Private Methods
        private bool selectElevator(){
            throw new NotImplementedException();
        }
        
        #endregion
        public List<Elevator> selectStoppedElevator()=> (from i in myElevators where i.Status == 0 select i).ToList();
            
        private Elevator selectRunningElevator(OrderAdministrator odA){
            throw new NotImplementedException();
        }

        public int getElevatorsNumber()=> myElevators.Count();

        public void insertElevator(Elevator ev) => myElevators.Add(ev); // TODO: When insert a elevator, notify the current executor.

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
