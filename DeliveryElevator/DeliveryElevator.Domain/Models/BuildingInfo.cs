using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryElevator.Domain.Models
{
    public struct BuildingInfo
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public int Elevators { get; set; }

    }
}