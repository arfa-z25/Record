using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cash_Managment.Business_Layer;
using Cash_Managment.DataLayer;
using Cash_Managment.Presentation_layer;

namespace Cash_Managment
{
    public partial class Project_Form : Form
    {
      
        private string id2;
      

        public Project_Form()
        {
            InitializeComponent();
        }

        public Project_Form(string id2)
        {
            this.id2 = id2;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string id2 = lblp1.Text;
            Employee e1 = new Employee(id);
            
            Project p = new Project(id2);
            
            e1.employee_Project(p);
            Connection.Assign_Project(e1, p);
            MessageBox.Show("Project is Assigned Succesfully!!");
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
      

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome w1 = new Welcome();
            w1.Show();
            this.Hide();
        }

        private void btnviewproject_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Connection.GetProjectData();
        }

        private void pic2_Click(object sender, EventArgs e)
        {

            string id = textBox2.Text;
            string id2 = lBLp2.Text;
            Employee e1 = new Employee(id);

            Project p = new Project(id2);

            e1.employee_Project(p);
            Connection.Assign_Project(e1, p);
            MessageBox.Show("Project is Assigned Succesfully!!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            string id2 = lblP3.Text;
            Employee e1 = new Employee(id);

            Project p = new Project(id2);

            e1.employee_Project(p);
            Connection.Assign_Project(e1, p);
            MessageBox.Show("Project is Assigned Succesfully!!");
        }
    }
   
}
