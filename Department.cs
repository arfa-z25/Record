using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Department
    {

        private string Position { get; set; }
        private string D_Name { get; set; }
        private string Location { get; set; }

        public Department(string D_Name, string Position, string Location)
        {
            this.D_Name = D_Name;
            this.Position = Position;
            this.Location = Location;
        }
        //AS aginst one department there can be max 30 employess , so there is a relation of assocaition
        //between these two classes.
        Employee[] array = new Employee[30];
        int index = 0;
        public void Insert_employee_in_department(Employee e)
        {
            array[index] = e;
            index++;
        }
        public override string ToString()
        {
            return string.Format("Department is  :\t[0]\n Location of Department:\t[1]\n Position in Department is : \t[3]", D_Name, Location, Position);
        }

    }
}
