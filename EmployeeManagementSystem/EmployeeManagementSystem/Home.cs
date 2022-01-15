using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblCalisan_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();

            this.Hide();
        }

        private void pictureBoxCalisan_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();

            this.Hide();
        }

        //Çıkıi label
        private void lblCikis_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCikis_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void pictureBoxMaas_Click(object sender, EventArgs e)
        {
            frmSalary salary = new frmSalary();
            salary.Show();

            this.Hide();
        }
    }
}
