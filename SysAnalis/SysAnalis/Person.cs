using SysAnalis;
using System.Collections.Generic;

namespace SysAnalis
{
    public class Person
    {
        private string name;
        private double value;
        private List<Benchmark> benchmarks = new List<Benchmark>();
        private List<Item> items = new List<Item>();

        public Person(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public Person(string name, double value, List<Benchmark> benchmarks, List<Item> items)
        {
            this.name = name;
            this.value = value;
            this.benchmarks = benchmarks;
            this.items = items;
        }

        public void SetBenchmarks(List<Benchmark> benchmarks)
        {
            this.benchmarks = benchmarks;
        }

        public void SetItems(List<Item> items)
        {
            this.items = items;
        }

        public double[] SumsOfItems()
        {
            double[] sum = new double[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < benchmarks.Count; j++)
                {
                    double a = items[i].BenchmarkValues.GetValueOrDefault(benchmarks[j].Name);
                    double b = benchmarks[j].Value;
                    sum[i] += a * b;
                }
            }

            return sum;
        }

        public string Name
        {
            get { return name; }
        }

        public double Value
        {
            get { return value; }
        }

        public List<Benchmark> Benchmarks
        {
            get { return benchmarks; }
        }

        public List<Item> Items
        {
            get { return items; }
        }

        public void AddBenchmark(Benchmark benchmark)
        {
            benchmarks.Add(benchmark);
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }
    }
}