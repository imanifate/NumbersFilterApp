using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFilterApp.FilterStrategyByOverloading
{
    public interface IUserIO
    {
        string Read();
        void Write(string message);
    }
}
