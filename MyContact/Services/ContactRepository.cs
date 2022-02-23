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
        private string connectionString = @"Data Source=DESKTOP-SLPSJR0\ALI2012SQLINSTAN; Initial Catalog=ContactDb; Integrated Security=true;";
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
            throw new NotImplementedException();
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
