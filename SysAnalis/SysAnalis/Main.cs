using SysAnalis;
using System;
using System.Collections.Generic;

namespace SysAnalis
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Artem", 0.6);
            Person person2 = new Person("Alex", 0.4);

            //Artem
            person1.AddBenchmark(new Benchmark("Price", 0.8));
            person1.AddBenchmark(new Benchmark("Quality", 0.2));

            person1.AddItem(new Item("Bakery", new Dictionary<string, double>
            {
                { "Price", 0.7 },
                { "Quality", 0.4 }
            }));

            person1.AddItem(new Item("McD", new Dictionary<string, double>
            {
                { "Price", 0.4 },
                { "Quality", 0.3 }
            }));

            person1.AddItem(new Item("KFC", new Dictionary<string, double>
            {
                { "Price", 0.2 },
                { "Quality", 0.5 }
            }));

            //Alex
            person2.AddBenchmark(new Benchmark("Price", 0.3));
            person2.AddBenchmark(new Benchmark("Quality", 0.7));

            person2.AddItem(new Item("Bakery", new Dictionary<string, double>
            {
                { "Price", 0.5 },
                { "Quality", 0.5 }
            }));

            person2.AddItem(new Item("McD", new Dictionary<string, double>
            {
                { "Price", 0.7 },
                { "Quality", 0.5 }
            }));

            person2.AddItem(new Item("KFC", new Dictionary<string, double>
            {
                { "Price", 0.6 },
                { "Quality", 0.4 }
            }));

            int index = FindBestOption(new List<Person> { person1, person2 });
            Console.WriteLine(person1.Items[index]);
        }

        private static int FindBestOption(List<Person> persons)
        {
            double[] sums = new double[persons[0].Items.Count];

            for (int i = 0; i < sums.Length; i++)
            {
                for (int j = 0; j < persons.Count; j++)
                {
                    double num = persons[j].Value;
                    double num2 = persons[j].SumsOfItems()[i];
                    sums[i] += num * num2;
                }
            }

            int index = 0;
            for (int i = 0; i < sums.Length; i++)
            {
                if (sums[i] < sums[index])
                {
                    return index;
                }
            }

            return index;
        }
    }
}