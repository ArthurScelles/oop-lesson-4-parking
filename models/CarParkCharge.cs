using System;
using oop_lesson_4_parking.models;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking.models
{
    public class CarParkCharge
    {
        public CarParkCharge()
        {
            //Console.WriteLine("CarParkCharge here");
        }
        public override string ToString()
        {
            return "CarParkCharge here";
        }
        public float CalculatedCharges(int hour)
        {
            int min = 2;
            float result = 0;
            if (hour<=3)
                {
                result = 2;
                }
            else
                {
                result = 2 + ((float)hour - 3)/2;
                }
            if (result>=10)
            {
                result = 10;
            }
            return result;
        }
    }
}
