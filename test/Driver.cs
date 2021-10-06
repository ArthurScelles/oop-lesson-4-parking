using System;
using oop_lesson_4_parking.models;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.test
{
    public class Driver
    {
        public Driver()
        {
            //Console.WriteLine("Driver here");
        }

        public void CreateObject()
        {
            CarPark carpark = new CarPark();

            carpark.customerList.Add(new Customer(2,"Arthur"));
            carpark.customerList.Add(new Customer(3,"Bob"));
            carpark.customerList.Add(new Customer(4,"Claire"));
            carpark.customerList.Add(new Customer(5, "Dana"));
            carpark.customerList.Add(new Customer(6, "Emma"));
            carpark.customerList.Add(new Customer(16, "Fred"));
            carpark.customerList.Add(new Customer(24, "Greg"));

            carpark.CalculatedCharges();

            CarParkCharge carparkcharge = new CarParkCharge();
            //Customer customer = new Customer(9);
        }
    }
}
