using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParser
{
    public class FunctionContext : IContext
    {
        private object obj;
        public double x {
            get
            {
                return this.GetVariable("x");
            }
            set
            {
                var x = this.obj.GetType().GetProperty("x");

                if (x is null)
                {
                    throw new UnknownIdentifierException("x");
                }

                x.SetValue(this.obj, value);
            }
        }

        public FunctionContext(double x)
        {
            this.obj = new FunctionLib(x);
        }

        public double GetVariable(string identifier)
        {
            var variable = this.obj.GetType().GetProperty(identifier);

            if (variable is null)
            {
                throw new UnknownIdentifierException(identifier);
            }

            return (double) variable.GetValue(this.obj);
        }

        public double InvokeFunction(string name, params double[] args)
        {
            var func = this.obj.GetType().GetMethod(name);
            
            if (func is null)
            {
                throw new UnknownIdentifierException(name);
            }

            int paramCount = func.GetParameters().Length;
            if (args.Length != paramCount)
            {
                throw new InvalidFunctionCallException(name, args.Length > paramCount);
            }

            object[] objArgs = args.Select((double num) => (object)num).ToArray();
            return (double) func.Invoke(obj, objArgs);
        }
    }
}
