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
using System.Diagnostics.Eventing.Reader;

namespace institute1
{
    public partial class Form4 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            SqlCommand cmd = new SqlCommand("select * from login where User_name ='"+txt_uname.Text+"'and Password='"+txt_pass.Text+"';", cn);
           // MessageBox.Show("Executed sql Command");
           // cmd.Parameters.Add("uname",SqlDbType.VarChar).Value = txt_uname.Text.ToString();
           // cmd.Parameters.Add("pass",SqlDbType.VarChar).Value = txt_pass.Text.ToString();
           // MessageBox.Show("para passed");
          //  cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();

           SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                cnt ++;
               
            }

            if (cnt == 1)
            {
                MessageBox.Show("Login success");
                this.Hide();
                frmMDI f1 = new frmMDI();
                f1.Show();
                cnt = 0;
            }
            else
            {
                MessageBox.Show("Login failed");
                cnt = 0;
            }
            sdr.Close();
        }
    }
}
