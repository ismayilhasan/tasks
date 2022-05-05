using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task_vechile
{
    class Bus : Vechile
    {
        byte passengerCount;


        public Bus(string brand, string model, string color, byte maxspeed,byte passengercount) : base(brand,model,color,maxspeed)
        {
            Brand = brand;
            Model = model;
            Color = color;
            maxSpeed = maxspeed;
            passengerCount = passengercount;
        }

        public override void getInfo()
        {
            Console.WriteLine($"Brand Name of Car : {Brand} \nModel of car : {Model} \nColor : {Color} \nmax speed : {maxSpeed} \nPassenger Count : {passengerCount}");
        }
    }
}
