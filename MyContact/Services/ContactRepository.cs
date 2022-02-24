using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContact
{
    class ContactRepository : IContactRepository
    {
        private string connectionString = @"Data Source=.\ALI2012SQLINSTAN; Initial Catalog=ContactDb; Integrated Security=true;";
        public bool Delet(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int ContactID, string name, string family, int age, string phoneNumber, string Mobile, string Email, string address)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, int age, string phoneNumber, string Mobile, string Email, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into Persons (Name,Family,Age,PhonNumber,Mobile,Email,Address) Values (@Name,@Family,@Age,@PhonNumber,@Mobile,@Email,@Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@PhonNumber", phoneNumber);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                int result= command.ExecuteNonQuery();
                connection.Close();
                if (result>0)
                {
                    return true;
                }
                return false;

            }
            catch 
            {
                connection.Close();
                return false;
                
                
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string Query = "Select * From Persons";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter(Query,connection);
            DataTable datatable = new DataTable();
            sqlDataAdaptor.Fill(datatable);
            return datatable;
        }

        public DataTable SelectID(int ContactID)
        {
            throw new NotImplementedException();
        }
    }
}
