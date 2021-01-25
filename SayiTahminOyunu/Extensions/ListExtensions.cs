using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public static class ListExtensions
    {
        public static T GetItem<T>(this IEnumerable<T> list, T obj)
        {
            T item = list.SingleOrDefault((c) => c.Equals(obj));
            return item;
        }
        public static T GetItem<T>(this IEnumerable<T> list, object obj)
        {
            T item = list.SingleOrDefault((c) => c.Equals(obj));
            return item;
        }
    }
}
