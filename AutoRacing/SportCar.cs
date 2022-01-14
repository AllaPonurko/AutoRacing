using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRacing
{
    class SportCar:Car
    {
        
        public SportCar(string name, string bodytype)
        {
            this.Name = name;
            this.BodyType = bodytype;
            Speed = 0.0;
        }
        public override double ChangeSpeed()
        {
            Speed = (double)(new Random().Next(100, 240) * 1.33);
            return Speed;
        }

        public override async void GoAsync()
        {
            Console.Write($"=>");
            await System.Threading.Tasks.Task.Delay(1000);

        }
        
    }
}
