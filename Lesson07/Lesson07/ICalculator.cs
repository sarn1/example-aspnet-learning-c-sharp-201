using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{
    public interface ICalculator<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
    }
}
