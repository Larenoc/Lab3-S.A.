using System.Collections.Generic;

namespace SysAnalis
{
    public class Item
    {
        private string name;
        private Dictionary<string, double> benchmarkValues;

        public Item(string name, Dictionary<string, double> benchmarkValues)
        {
            this.name = name;
            this.benchmarkValues = benchmarkValues;
        }

        public string Name
        {
            get { return name; }
        }

        public Dictionary<string, double> BenchmarkValues
        {
            get { return benchmarkValues; }
        }

        public override string? ToString()
        {
            return $"Item: {name}";
        }
    }
}