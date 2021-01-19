using System;
namespace DeliveryElevator.Models
{
   public class ElevatorReportStatus : EventArgs {

        public int ElevatorID; 
        public int Floor;
    }
}