using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task_vechile
{
    class Vechile
    {
        protected string Brand;
        protected string Model;
        protected string Color;
        protected byte maxSpeed;

        public Vechile()
        {
            Console.WriteLine("Car was created");
        }
        
        public Vechile(string brand,string model,string color,byte maxspeed) : this(brand,model)
        {
            Brand = brand;
            Model = model;
            Color = color;
            maxSpeed = maxspeed;
        }

        public Vechile(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }

        public virtual void getInfo()
        {
            Console.WriteLine($"\nBrand Name of Car : {Brand} \nModel of car : {Model} \nColor : {Color} \nmax speed : {maxSpeed}");
        }
    }
}
