using System;
using System.Collections.Generic;
using static AutoRacing.Game;

namespace AutoRacing
{
    
    class Program
    {  
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Game game = new Game();
            Car sportcar = new SportCar("Toyota", "спорт");
            Car passengercar = new PassengerCar("Folkswagen", "пассажир");
            Car truck = new Truck("Volvo", "грузовик");
            Car autobus= new AutoBus("Mercedes", "автобус");
            Car[] car = { sportcar, passengercar, truck, autobus };
   
            foreach (var item in car)
            {
                Game.Delegate2 a=item.GoToTheStart;
                Console.WriteLine(item.GetName+" "+item.BodyType);
                a("Выйти на старт");
            }
            foreach (var item in car)
            {
                Game.Delegate2  b = item.StartRace;
                Console.WriteLine(item.GetName + " " + item.BodyType);
                b("Начать гонку");
            }
            List<double> list=new List<double>();
            foreach(var item in car)
            { double v = item.ChangeSpeed();
                Game.Delegate1 c = item.TimeRacing;
                Console.WriteLine(item.GetName + " " + item.BodyType+" "+Convert.ToDouble(v));
                double t = c(100,v);
                list.Add(t); 
                Console.WriteLine(Convert.ToDouble(t));
                
              for (int i=0;i<(int)t;i++)
                {
                    item.GoAsync();
                }
                game.Message();
            }
            list.Sort();
            Console.WriteLine($"Минимальное время гонки: "+Convert.ToDouble(list[0]));


        }
    }
}
