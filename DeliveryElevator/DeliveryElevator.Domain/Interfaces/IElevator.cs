using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryElevator.Domain.Interfaces
{
    public interface IElevator
    {
        void Execute(ICommand command);
    }
}