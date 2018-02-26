using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lesson08
{
    public class AdoDotNet
    {
        public void GetData()
        {
            using (var connection = new SqlConnection("connString"))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID, Name, Age FROM People";

                    using (var reader = cmd.ExecuteReader())
                    {
                        int idOrdinal = reader.GetOrdinal("ID"),
                            nameOrdinal = reader.GetOrdinal("Name"),
                            ageOrdinal = reader.GetOrdinal("Age");

                        while (reader.Read())
                        {
                            var id = reader.GetInt32(idOrdinal);
                            var name = reader.GetString(nameOrdinal);

                            //int? age = null;

                            //if (!reader.IsDBNull(ageOrdinal))
                            //{
                            //    age = reader.GetInt32(ageOrdinal);
                            //}

                            int? age = reader.GetValue<int?>(ageOrdinal);
                        }
                    }
                }
            }
        }
    }
}
