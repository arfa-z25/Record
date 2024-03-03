using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Part_Time:_Salarycs
    {
        public string position { get; set; }
        public double amount { get; set; }
        public double hours { get; set; }
       
        public Part_Time(string id , string date , string position  , double hours):base(id ,date)
        {
            this.position = position;
        }
        public override double calSalary()
        {
            amount =30000*hours;
            return amount;
        }
    }
}
