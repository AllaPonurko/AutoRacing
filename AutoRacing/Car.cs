using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRacing
{
    abstract class Car
    {
        public string Name;
        public double Speed;
        public string BodyType;
        public string GetName => Name;
        public double GetSpeed => Speed;
        public abstract void GoAsync();
        public  void GoToTheStart(string str)
        {
            Console.WriteLine(str);
        }
        public void StartRace(string str)
        {
            Console.WriteLine(str);
        }

        public abstract double ChangeSpeed();
        public double TimeRacing(int s, double v)
        {
            return (double)(s/v)*60.0;
        }
        


    }
    
}
