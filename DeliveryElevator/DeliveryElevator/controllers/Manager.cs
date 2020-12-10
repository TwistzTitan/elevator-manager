using System;
using System.Text;
using System.Threading;
using DeliveryElevator.Models;
namespace DeliveryElevator.Controllers
{
    class Manager { 

        public Manager()
        {

        }
        public void Start()
        { 
                Presentation();
                Menu();
                
        }

        public void Presentation(){

            Console.WriteLine("\tWelcome to Delivery Elevator");
        }

        public void Menu(){
            StringBuilder options = new StringBuilder(@"
             Options	Description
             -h 	    help to show this menu
             -n		    new Order
             -ESC		quit from program
            ");
            
            Console.WriteLine(options.ToString(),ConsoleColor.Blue);
            ConsoleKeyInfo c = new ConsoleKeyInfo();
            do
            {

                while (Console.KeyAvailable == false) Thread.Sleep(50);
                c = Console.ReadKey();
                if (c.Key == ConsoleKey.H) Console.WriteLine(options.ToString(), ConsoleColor.Blue);
                if (c.Key == ConsoleKey.N) createNewOrder();
            }
            while (c.Key != ConsoleKey.Escape);
        }
    
        public void createNewOrder()
        {
            Console.WriteLine("Whats is the floor of order?");
            var floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Whats is the destiny floor of order?");
            var destinyFloor = int.Parse(Console.ReadLine());
            Order o = new Order(floor, destinyFloor);
            new OrderAdminitrator().receiveOrder(o);
            
        }
    }
}