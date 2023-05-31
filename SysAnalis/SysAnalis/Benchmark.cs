namespace SysAnalis
{
    public class Benchmark
    {
        private string name;
        private double value;

        public Benchmark(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name
        {
            get { return name; }
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}