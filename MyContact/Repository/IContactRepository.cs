using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContact
{
    interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectID(int ContactID);
        bool Insert(string name,string family,int age,string phoneNumber,string Mobile,string Email,string address);
        bool Edit(int ContactID, string name, string family, int age, string phoneNumber, string Mobile, string Email, string address);
        bool Delet(int ContactID);
    }
}
