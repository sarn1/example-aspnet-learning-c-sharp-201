using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Lesson08
{
    public static class DataReaderExtensions
    {
        public static T GetValue<T>(this IDataReader r, int index)
        {
            T value = default(T);

            if (!r.IsDBNull(index))
            {
                value = (T) r[index];
            }

            return value;
        }
    }
}
