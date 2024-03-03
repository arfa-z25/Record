using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Full_Time:_Salarycs
    {
        public string type { get; set; }
        public double amount { get; set; }
        public Full_Time(string id , string date ,string type):base(id , date)
        {
            this.type = type;

        }
        public override double calSalary()
        {
            amount = 50000;
            return amount;
        }
    }
}
