using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace STUDENT_MS
{
    public class Connection
    {
        private static string connectionString = @"Data Source=htruc;Initial Catalog=STUDENT_MS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
