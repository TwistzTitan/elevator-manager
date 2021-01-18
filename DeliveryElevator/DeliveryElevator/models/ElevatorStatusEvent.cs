using System;
namespace DeliveryElevator.Models
{
   public class ElevatorStatus : EventArgs {

        public int ElevatorID; 
        public int Floor;
    }
}