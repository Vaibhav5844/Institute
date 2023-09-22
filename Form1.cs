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
using System.Text.RegularExpressions;

namespace institute1
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        String sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if(txt_id.Text != "")
            {
                if(txt_name.Text !="")
                {
                    if(txt_duration.Text !="")
                    {
                        if(txt_insta.Text !="")
                        {
                            SqlCommand cmd = new SqlCommand("sp_save", cn);

                            cmd.Parameters.Add("@c_id",SqlDbType.VarChar).Value = txt_id.Text.ToString();
                            cmd.Parameters.Add("@c_name",SqlDbType.VarChar).Value=txt_name.Text.ToString();
                            cmd.Parameters.Add("@duration",SqlDbType.VarChar).Value= txt_duration.Text.ToString();  
                            cmd.Parameters.Add("@installment",SqlDbType.VarChar).Value = txt_insta.Text.ToString();
                            cmd.Parameters.Add("@oneTime",SqlDbType.VarChar).Value = txt_ot.Text.ToString();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record saved");

                            txt_id.Text = "";
                            txt_name.Text = "";
                            txt_duration.Text = "";
                            txt_insta.Text = "";
                            txt_ot.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Enter insta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter duration");
                    }
                }
                else
                {
                    MessageBox.Show("Plz enter name");
                }
            }
            else
            {
                MessageBox.Show("Plz enter id");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();
            
           
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (txt_name.Text != "")
                {
                    if (txt_duration.Text != "")
                    {
                        if (txt_insta.Text != "")
                        {
                            SqlCommand cmd = new SqlCommand("sp_update",cn);

                            cmd.Parameters.Add("c_id", SqlDbType.VarChar).Value = txt_id.Text.ToString();
                            cmd.Parameters.Add("c_name", SqlDbType.VarChar).Value = txt_name.Text.ToString();
                            cmd.Parameters.Add("duration", SqlDbType.VarChar).Value = txt_duration.Text.ToString();
                            cmd.Parameters.Add("insta",SqlDbType.VarChar).Value = txt_insta.Text.ToString();
                            cmd.Parameters.Add("oneTime",SqlDbType.VarChar).Value=txt_ot.Text.ToString();  
                            
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update success");
                           
                        }
                        else
                        {
                            MessageBox.Show("Enter insta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter duration");
                    }
                }
                else
                {
                    MessageBox.Show("Plz enter name");
                }
            }
            else
            {
                MessageBox.Show("Plz enter id");
            }
            txt_id.Text = "";
            txt_name.Text = "";
            txt_duration.Text = "";
            txt_insta.Text = "";
            txt_ot.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            

            if(txt_id.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_delete_one", cn);

                cmd.Parameters.Add("C_id",SqlDbType.VarChar).Value = txt_id.Text.ToString();



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Plz enter id");
            }
            txt_id.Text = "";
            txt_name.Text = "";
            txt_duration.Text = "";
            txt_insta.Text = "";
            txt_ot.Text = "";
        }

        public void gridView()
        {
            String select = "select * from Cource";

            SqlDataAdapter da = new SqlDataAdapter(select,cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cource");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Cource";
        }
        private void btn_display_Click(object sender, EventArgs e)
        {
            gridView();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int cnt = 1;

            SqlCommand cmd = new SqlCommand("Select max(Co_id) as id from Cource", cn);

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cnt = Convert.ToInt32(sdr[0]);
                cnt++;
                txt_id.Text = cnt.ToString();
            }
            sdr.Close();

        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            if(Regex.IsMatch(txt_name.Text, "[a-zA-Z]+$"))
            {

            }
            else
            {
                MessageBox.Show("Numbers not allowed");
                txt_name.Text = "";
            }
        }

        private void txt_insta_KeyUp(object sender, KeyEventArgs e)
        {
            //Regex regex = new Regex(@"[\d]");
            //regex = new Regex("[0-9]");
            if (Regex.IsMatch(txt_insta.Text, "[0-9]+$"))
            {

            }
            else
            {
                MessageBox.Show("Alphabets not allowed");
                txt_insta.Text = "";
            }
        }

        private void txt_ot_KeyUp(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(txt_ot.Text, "^[0-9]+$"))
            {

            }
            else
            {
                MessageBox.Show("Alphabets not allowed");
                txt_ot.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI f1 = new frmMDI();
            f1.Show();
          
            
        }
    }
}
