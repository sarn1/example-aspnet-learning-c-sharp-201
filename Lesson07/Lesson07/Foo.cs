using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Lesson07
{
    public class Foo<T> 
        where T : IDbConnection, new()
    {
        public T Property { get; private set; }

        public Foo() : this(new T())
        {
        }

        public Foo(T obj)
        {
            Property = obj;
        } 
    }
}
