using System;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int> {list = new int[] {12, 3, 4}};
            list.Append(5);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.GetArray());
        }

    }
}
