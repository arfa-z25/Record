using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Contract:_Salarycs
    {
        public string type;
        public double amount;
        public int year;
        public Contract(string id , string date , string type , int year):base(id , date)
        {
            this.type = type;
            this.year = year;
        }
        public override double calSalary()
        {
           if (year>=1 && year<=5)
            {
                amount = 60000;
            }
           else if(year>=5 && year<=10)
            {
                amount = 80000;
            }
           else
            {
                amount = 0;
            }
            return amount;
           
        }
    }
}
