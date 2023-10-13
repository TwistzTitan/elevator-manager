using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryElevator.Domain.Enum;

namespace DeliveryElevator.Domain.Models
{
    public struct OperationInfo
    {
        public int Floor { get; set; }
        public double MaxWeight { get; set; }
        public double Weight { get; set; }
        public ElevatorStatus Status { get; set; }
        public int Amount { get; set; }
    }
}