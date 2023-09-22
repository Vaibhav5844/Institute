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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace institute1
{
    public partial class Form7 : Form
    {
        SqlConnection cn = null;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("Select * from admission",cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txt_id.Items.Add(reader[0]);
                txt_name.Items.Add(reader[3]);
            }
            reader.Close();

        }

        private void txt_id_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  SqlCommand cmd = new SqlCommand("Select * from admission", cn);
            SqlDataReader rea = cmd.ExecuteReader();
            while (rea.Read())
            {
                //txt_id.Items.Add(reader[0]);

               // txt_name.Text=Convert.ToString(rea[3]);
                txt_email.Text =Convert.ToString(rea[4]);
                txt_pno.Text = Convert.ToString(rea[6]);
                txt_course.Text = Convert.ToString(rea[8]);
                txt_mode.Text = Convert.ToString(rea[10]);
                txt_total_fee.Text = Convert.ToString(rea[11]);
                txt_fee_type.Text = Convert.ToString(rea[12]);

            }
            rea.Close();*/
        }

        private void txt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from admission where S_name ='"+txt_name.Text+"';", cn);
            SqlDataReader rea = cmd.ExecuteReader();
            while (rea.Read())
            {
                txt_id.Text =Convert.ToString(rea[0]);

               // txt_name.Text = Convert.ToString(rea[3]);
                txt_email.Text = Convert.ToString(rea[4]);
                txt_pno.Text = Convert.ToString(rea[6]);
                txt_course.Text = Convert.ToString(rea[8]);
                txt_mode.Text = Convert.ToString(rea[10]);
                txt_total_fee.Text = Convert.ToString(rea[11]);
                txt_fee_type.Text = Convert.ToString(rea[12]);
                txt_paid_fee.Text= Convert.ToString(rea[13]);
                txt_balance_fee.Text = Convert.ToString(rea[14]);

            }
            rea.Close();
        }

        private void txt_paid_fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_save_reeceipt",cn);

            

             

            cmd.Parameters.Add("id",SqlDbType.VarChar).Value = txt_id.Text.ToString();
            cmd.Parameters.Add("date", SqlDbType.VarChar).Value = txt_date.Text.ToString();
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = txt_name.Text.ToString();
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txt_email.Text.ToString();
            cmd.Parameters.Add("pno", SqlDbType.VarChar).Value = txt_pno.Text.ToString();
            cmd.Parameters.Add("c_name", SqlDbType.VarChar).Value = txt_course.Text.ToString();
            cmd.Parameters.Add("fee_type", SqlDbType.VarChar).Value = txt_fee_type.Text.ToString();
            cmd.Parameters.Add("mode", SqlDbType.VarChar).Value = txt_mode.Text.ToString();
            cmd.Parameters.Add("total_fee", SqlDbType.VarChar).Value = txt_total_fee.Text.ToString();
            cmd.Parameters.Add("paying_now", SqlDbType.VarChar).Value = txt_currently_paying.Text.ToString();
            cmd.Parameters.Add("total_paid", SqlDbType.VarChar).Value = txt_paid_fee.Text.ToString();
            cmd.Parameters.Add("balance", SqlDbType.VarChar).Value = txt_balance_fee.Text.ToString();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inforamtion saved");

            int fee, c_paying, balace, paid;
            c_paying = Convert.ToInt32(txt_currently_paying.Text);
            fee = Convert.ToInt32(txt_total_fee.Text);
            paid = Convert.ToInt32(txt_paid_fee.Text);
            balace = fee - (c_paying + paid);
            paid = paid + c_paying;

            SqlCommand sqlCommand = new SqlCommand("update admission set paid_fees=" + paid + ",balance_fees=" + balace+"where Add_id="+txt_id.Text,cn);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Record updated");
            txt_currently_paying.Text = "";



        }

        private void txt_currently_paying_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI f1 = new frmMDI();
            f1.Show();
        }
    }
}
