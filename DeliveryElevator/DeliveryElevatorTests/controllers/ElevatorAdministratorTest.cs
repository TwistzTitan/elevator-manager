using System;
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
                new Elevator(1, 4, 3),
                new Elevator(1,6,5),
                new Elevator(0,0,0),
                new Elevator(2,8,10),
                new Elevator(8,2,5),
                new Elevator(0,0,-1)
            };
            
            evAdm = new ElevatorAdministrator(ev);

        }

        [Test]
        public void Select_At_Least_One_Stopped_Elevators()
        {
            Assert.GreaterOrEqual(
                    evAdm.selectStoppedElevator().Count,
                    1,
                    "The total of elevators was: " + evAdm.selectStoppedElevator().Count.ToString()
            );
        }

        [Test]
        public void Select_Running_Elevator() {

            Assert.IsInstanceOf<List<Elevator>>(evAdm.selectRunningElevator());
            Assert.True(evAdm.selectRunningElevator().Count > 0);
            evAdm.selectRunningElevator().ForEach((e)=> Assert.True(e.Floor > 0));

        }

        [Test]
        public void Not_Select_Any_Running_Elevator()
        {
            evAdm.myElevators = new List<Elevator>()
            {
                new Elevator(0,0,10),
                new Elevator(0,0,8),
            };
            Assert.AreEqual(0, evAdm.selectRunningElevator().Count);
            Console.WriteLine(evAdm.myElevators.Count);
        }

        [TestCase(5,0)]
        [TestCase(4,8)]
        public void Select_Running_Elevator_For_Order_By_Destiny(int f, int d)            
        {
            Order o = new Order(floor: f, destiny: d);
            var result = evAdm.selectRunningElevatorForOrder(o);
            Assert.IsInstanceOf<Elevator>(result);
            Assert.True(result.Status == o.GetMoveTo());
            Assert.LessOrEqual(Math.Abs(result.Floor - o.GetFloor()),3);
            Assert.Less(result.Orders.Count, result.LimitOrders);
        }

        [Test]
        public void Select_Stopped_Elevator_For_Order_By_Destiny()
        {

        }

    }
}