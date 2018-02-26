using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson07;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Lesson07Test
{
    [TestClass]
    public class FooTests
    {
        [TestMethod]
        public void FooTest()
        {
            var sqlConnectionFoo = new Foo<SqlConnection>();
            var oleDbConnectionFoo = new Foo<OleDbConnection>(new OleDbConnection());
        }
    }
}
