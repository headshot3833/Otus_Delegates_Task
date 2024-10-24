using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Delegates_Task
{
    public static class CollectionExtensions
    {

        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || convertToNumber == null) throw new ArgumentNullException();
            return collection.OrderByDescending(convertToNumber).FirstOrDefault();

        }
    }
}
