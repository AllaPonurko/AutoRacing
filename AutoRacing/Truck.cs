using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRacing
{
    class Truck : Car
    {
        public Truck(string name, string bodytype)
        {
            this.Name = name;
            this.BodyType = bodytype;
            Speed = 0.0;
        }
        public override double ChangeSpeed()
        {
            Speed = (double)(new Random().Next(50, 100) * 1.23);
            return Speed;
        }

        public override async void GoAsync()
        {
            Console.Write($"=>");
            await Task.Delay(1000);
            
        }
    }
}
