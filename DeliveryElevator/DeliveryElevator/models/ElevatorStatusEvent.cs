using System;
namespace DeliveryElevator.Models
{
    class ElevatorStatus : EventArgs {

        public int ElevatorID; 
        public int Floor;
    }
}