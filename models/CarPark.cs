using System;
using oop_lesson_4_parking.models;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class CarPark
    {
        public List<Customer> customerList = new List<Customer>();

        public CarParkCharge carparkcharge = new CarParkCharge();  
        public CarPark()
        {
            //Console.WriteLine("CarPark here");
        }
        public override string ToString()
        {
            return "CarPark here";
        }

        public void CalculatedCharges()
        {
            foreach(Customer customer in customerList)
            {
                float calculatedcharge = carparkcharge.CalculatedCharges(customer.hour);
                Console.WriteLine("Customer " + customer.name + " for " +customer.hour + " hours you need to pay " + calculatedcharge + " euros");
            }
        }
    }
}
