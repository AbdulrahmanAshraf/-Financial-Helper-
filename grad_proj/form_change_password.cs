using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace grad_proj
{
    public partial class form_change_password : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5APU4L4;Initial Catalog=project;Integrated Security=true");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable tab;
        public form_change_password()
        {
            InitializeComponent();
        }

        private void form_change_password_Load(object sender, EventArgs e)
        {

        }

        private void lab_user_name_Click(object sender, EventArgs e)
        {

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_change_Click(object sender, EventArgs e)
        {
            if (tb_oldpass.Text.Length > 0 && tb_username.Text.Length > 0)
            {
                da = new SqlDataAdapter("select count(*) from users_id where UserName='" + tb_username.Text + "'and password='" + tb_oldpass.Text + "'", cn);
                tab = new DataTable();
                da.Fill(tab);
                if (tab.Rows[0][0].ToString() == "1")
                {
                    if (tb_newpass.Text == tb_confirm.Text)
                    {
                        cmd = new SqlCommand("update users_id set password='" + tb_newpass.Text + "' where UserName='" + tb_username.Text + "'and password='" + tb_oldpass.Text + "'", cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password changed sucesfully");
                    }
                    else
                    {//no= 
                    }
                }
                else
                { ///not found
                    MessageBox.Show("user not found .. please try again");
                }
            }
            else
            {//enter
                MessageBox.Show("please enter suffecient data");
            }
        }

        
       
    }
}
