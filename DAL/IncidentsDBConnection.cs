﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    public static class IncidentsDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
