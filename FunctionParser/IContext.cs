using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParser
{
    public interface IContext
    {
        double GetVariable(string identifier);
        double InvokeFunction(string name, params double[] args);
    }
}
