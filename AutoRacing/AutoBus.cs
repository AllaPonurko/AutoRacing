using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRacing
{
    internal class AutoBus : Car
    {
        public AutoBus(string name, string bodytype)
        {
            this.Name = name;
            this.BodyType = bodytype;
            Speed = 0.0;
        }

        public override double ChangeSpeed()
        {
            Speed = (double)(new Random().Next(60, 100) * 1.23);
            return Speed;
        }

        public override async void GoAsync()
        {
            Console.Write($"=>");
            await System.Threading.Tasks.Task.Delay(1000);
            
        }
    }
}
