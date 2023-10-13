using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryElevator.Domain.Models;

namespace DeliveryElevator.Domain.Interfaces
{
    public interface IAdmin
    {
        
    }

    public abstract class IElevatorAdmin {

        private List<IElevator> _elevators;
        private BuildingInfo _buildingInfo;

        public EventHandler<OperationInfo> OnOperationInfoChanged;
    }
}