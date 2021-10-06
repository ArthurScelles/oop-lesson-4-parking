using System;
using oop_lesson_4_parking.models;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        public  int hour {get; set; }
        public string name { get; set; }
        public Customer(int hour,string name)
        {
            this.name = name;
            this.hour = hour;
            //Console.WriteLine("Customer here");
        }
        public override string ToString()
        {
            return "Customer here";
        }
    }
}
