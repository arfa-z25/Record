using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string phone_no { get; set; }
        public string address { get; set; }
        public string age { get; set; }
        public Person()
        {

        }
        public Person(string name, string gender, string age ,string phone, string address)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.phone_no = phone;
            this.address = address;
        }
    }
}
