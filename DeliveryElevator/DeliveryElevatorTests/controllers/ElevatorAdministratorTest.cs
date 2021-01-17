
using NUnit.Framework;
using System.Collections.Generic;


namespace DeliveryElevatorTests
{
    public class ElevatorAdministratorTest
    {
   
 
        [Test]
        public void Test1()
        {
            
            ElevatorAdministrator elAdm = new ElevatorAdministrator(new List<Elevator>() { new Elevator(1, 5, 3) });

            Assert.AreEqual(1,elAdm.GetElevatorsNumber());
        }
    }
}