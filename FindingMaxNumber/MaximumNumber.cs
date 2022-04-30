using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxNumber
{
    public class MaximumNumber<T> where T : IComparable
    {
        public T[] value;

        public void MaxNumber(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T PrintMaxMethod()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is :" + max);
            return max;
        }
    }
    //public class MaximumNumber
    //{
    //  public string FindMaxString(string first, string second, string third)
    //{
    //  if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
    //{
    //  Console.WriteLine("First Number is greater: " + first);
    //return first;
    //}
    //if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
    //{
    //  Console.WriteLine("Second Number is greater: " + second);
    //return second;
    //}
    //else
    //{
    //  Console.WriteLine("Third Number is greater: " + third);
    //return third;
    //}
    //}
    //}
}
