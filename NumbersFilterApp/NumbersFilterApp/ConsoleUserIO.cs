using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFilterApp
{
    public class ConsoleUserIO : IUserIO
    {
        public string Read() => Console.ReadLine();
        public void Write(string message) => Console.WriteLine(message);
       
    }
}
