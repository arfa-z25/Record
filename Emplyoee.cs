using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Employee:Person
    {
         public string Employee_ID { get; set; }
         public string Department_id { get; set; }
         public int P_no { get; set; }
         public bool Active { get; set; }
        public string Image { get; set; }

        public Employee(string id)
        {
            this.Employee_ID = id;
        }

        public Employee(string E_id, string name, string gender,string age,string phone_no ,bool active ,int no, string address,string d_id , string image):base(name,gender, age,phone_no ,address)
        
    {
            this.Employee_ID = E_id;
            this.Department_id = d_id;
            this.P_no = no;
            this.Active = active;
            this.Image = image;
            
    }
        //AN EMPLOYEE HAS MAX 4 PROJECTS AGAINST IT SO ASSOCIATION OF ONE TO MANY EXIST HERE
        Project[] array = new Project[4];
        int index = 0;
        public void employee_Project(Project p)
        {
            array[index] = p;
            index++;
        }

       
    }
}
