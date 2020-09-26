using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wform1
{
    public partial class Home_Screen : Form
    {
        public Home_Screen()
        {
            InitializeComponent();
        }
        private void Home_Screen_Click(object sender, EventArgs e)
        {


            string UserName = this.User_Name_TextBox.Text;
            string Password = this.Password_TextBox.Text;
            if (UserName.Equals("nethra") && Password.Equals("nethra"))
            {
                MessageBox.Show("login successful", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("invalid credentials", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




    


