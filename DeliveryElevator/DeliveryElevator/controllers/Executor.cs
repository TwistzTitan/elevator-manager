using System;
using System.Collections.Generic;
using DeliveryElevator.Models;
namespace DeliveryElevator.Controllers 
{
     class Executor 
    {
        // Executor trigger events by the elevator position
        public EventHandler<ElevatorStatus> notifyStatusElevator;
        private List<Elevator> _elevators;
        public void operateElevator(Elevator ev){
            throw new NotImplementedException();
            // Determines the method to operate the elevetor delivery
        }

        public List<Elevator> getStatusElevators ()=> _elevators;

#region Private Methods
        private void upElevator(){
            throw new NotImplementedException();
        }

        private void downElevator(){
            throw new NotImplementedException();
        }
                
    }
#endregion
}