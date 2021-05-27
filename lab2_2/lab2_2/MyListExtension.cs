using System;

namespace lab2_2
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.list;
        }
    }
}