﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public static class IncidentDB
    {
        public static int AddIncident(Incident incident)
        {
            int registrationCount;

            SqlConnection connection = IncidentsDBConnection.GetConnection();
            string insertStatement =
                "INSERT Incidents (CustomerID, ProductCode, DateOpened, Title, Description) " +
                "VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
            insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
            insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
            insertCommand.Parameters.AddWithValue("@Title", incident.Title);
            insertCommand.Parameters.AddWithValue("@Description", incident.Description);

            string registrationCheckStatement =
                    "SELECT COUNT(*) FROM Registrations " +
                    "WHERE CustomerID = @CustomerID " +
                    "AND ProductCode = @ProductCode";
            SqlCommand registrationCommand = new SqlCommand(registrationCheckStatement, connection);
            registrationCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
            registrationCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);

            try
            {
                connection.Open();
                registrationCount = Convert.ToInt32(registrationCommand.ExecuteScalar());
                if (registrationCount == 0)
                {
                    throw new Exception("The customer and product selected are not registered together.");
                }
                else
                {
                    insertCommand.ExecuteNonQuery();
                }
                string selectStatement = "SELECT IDENT_CURRENT('Incidents') FROM Incidents";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int incidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return incidentID;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
