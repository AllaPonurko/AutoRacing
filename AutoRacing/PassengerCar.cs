using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRacing
{
    class PassengerCar:Car
    {
       
        public PassengerCar(string name, string bodytype)
        {
            this.Name = name;
            this.BodyType = bodytype;
            Speed = 0.0;
        }

        public override double ChangeSpeed()
        {
            Speed = (double)(new Random().Next(70, 150) * 1.33);
            return Speed;
        }

        public override async void GoAsync()
        {
            Console.Write($"=>");
            await Task.Delay(1000);
           
        }
    }
}
