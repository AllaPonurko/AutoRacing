using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRacing
{
    class Game
    {
       public delegate double Delegate1(int value1,double value2);
        public delegate void Delegate2(string str);
       public event Action<string> action = (str) => Console.WriteLine(str);
        public void Message()
        {
            action(" Финиш!");
        }
    }
}
