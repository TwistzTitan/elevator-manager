using System.Collections.Generic;
using NUnit.Framework;
using DeliveryElevator.Controllers;
using DeliveryElevator.Models;
namespace DeliveryTests
{
    [TestFixture]
    public class ElevatorAdministratorTest
    {
        ElevatorAdministrator evAdm;
        [SetUp]
        public void Setup()
        {
            var ev = new List<Elevator>(){ 
                new Elevator(1, 4, 3,0),
                new Elevator(1,6,5,1),
                new Elevator(0,0,0,0),
                new Elevator(2,8,10,1),
                new Elevator(0,0,-1,0)
            };
            evAdm = new ElevatorAdministrator(ev);
            
        }

        [Test]
        public void ReturnNumberOfElevator()
        {
            Assert.AreEqual(5,evAdm.getElevatorsNumber()) ;
        }

        [Test]
        public void Select_Stopped_Elevators() 
        {
            Assert.AreEqual(3,evAdm.selectStoppedElevator().Count);
        } 

    }
}