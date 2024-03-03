using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
        abstract class _Salarycs
    {

         public  string Employee_id;
         
         public string salary_date;
        

        public _Salarycs( string id , string date )
        {

            this.Employee_id = id;
            
            this.salary_date = date;
        }
         public abstract double calSalary();
       


    }
}
