using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame
{
    public class UI
    {
        public virtual void PrintString(string _str, params object[] args)
        {
            Console.WriteLine("ARV FRA DENNE KLASSE!!!!!!!!!!!!!");
        }
    }
    public class ConsoleUI : UI
    {
        public override void PrintString(string _str, params object[] args)
        {
            Console.WriteLine(_str, args);
        }
    }
}
