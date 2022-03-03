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
            SqlConnection connection= new SqlConnection(connectionString);
            string Qurey =String.Format( "Delete Persons where ID={0}",ContactID);
            
            try
            {
                SqlCommand command = new SqlCommand(Qurey,connection);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;   
            }
            finally
            {
                connection.Close();
            }

        }

        public bool Edit(int ContactID, string name, string family, int age, string phoneNumber, string Mobile, string Email, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "Update Persons Set Name=@Name,Family=@Family,Age=@Age,PhonNumber=@PhonNumber,Mobile=@Mobile,Email=@Email,Address=@Address WHere ID=@contactId;";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@PhonNumber", phoneNumber);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@contactId", ContactID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch 
            {

                return false;
            }
            finally
            {
                
                connection.Close();
            }
            
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
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "Select * From Persons Where ID="+ContactID;

            SqlDataAdapter dtAdaptor = new SqlDataAdapter(Query, connection);
            DataTable dtTblSelect = new DataTable();

            dtAdaptor.Fill(dtTblSelect);
            return dtTblSelect;
        }
    }
}
