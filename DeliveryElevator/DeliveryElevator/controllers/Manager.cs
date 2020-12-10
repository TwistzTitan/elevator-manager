using System;
using System.Text;
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

            Console.WriteLine("Welcome to Delivery Elevator");
        }

        public void Menu(){
            StringBuilder options = new StringBuilder(@"
             Options\t	Description\n
             -h\t 		help\n
             -n\t		new Order\n
             -q\t		quit from program\n
            ");
            
            Console.WriteLine(options);
        }
    }
}