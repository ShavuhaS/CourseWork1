namespace FunctionParser
{
    public class FunctionLib
    {
        public double x { get; set; }
        public double pi { get { return Math.PI; } }
        public double e { get { return Math.E; } }

        public FunctionLib(double x)
        {
            this.x = x;
        }


        public double sin(double val) => Math.Sin(val);
        public double cos(double val) => Math.Cos(val);
        public double tan(double val) => Math.Tan(val);
        public double cot(double val) => 1 / Math.Tan(val);

        public double sqrt(double val) => Math.Sqrt(val);
        public double pow(double val, double degree) => Math.Pow(val, degree);
        public double exp(double val) => Math.Exp(val);
        public double ln(double val) => Math.Log(val);

    }
}
