using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Admin : Person
    {
        private string Admin_Id;
        private string username;
        private string password;
        public Admin(string Admin_ID, string username, string pass, string name, string gender,string age, string phone, string address) :
            base(name, gender, age, phone, address)
        {
            this.Admin_Id = Admin_ID;
            this.username = username;
            this.password = pass;
        }
    }
}
