using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Managment.Business_Layer
{
    class Project
    {
        public string Project_ID { get; set; }
        public string Project_Name { get; set; }
        public string project_Budget { get; set; }
        public string project_status { get; set; }



         public Project(string id)
        {
            this.Project_ID = id;

        }
            public Project(string id, string name, string budget)
            {
                this.Project_ID = id;
                this.Project_Name = name;
                this.project_Budget = budget;
            }
        
    }
}
