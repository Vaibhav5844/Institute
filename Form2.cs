using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace institute1
{
   
    public partial class Form2 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();
        }
        public static bool IsValidEmail(string email)
        {
            String emailPattern = @"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if(String.IsNullOrEmpty(email))
                return false;

            Regex reg = new Regex(emailPattern);
            return reg.IsMatch(email);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                if (txt_name.Text != "")
                {
                    if (IsValidEmail(txt_email.Text))
                    {
                        // Regex reg = new Regex(txt_pno.Text);
                        if (Regex.IsMatch(txt_pno.Text, @"^[0-9]{10}$"))
                        {
                            if (txt_gen.Text != "")
                            {
                                SqlCommand cmd = new SqlCommand("insert_into_trainer", cn);

                                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = txt_id.Text.ToString();
                                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = txt_name.Text.ToString();
                                cmd.Parameters.Add("address", SqlDbType.VarChar).Value = txt_add.Text.ToString();
                                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txt_email.Text.ToString();
                                cmd.Parameters.Add("pno", SqlDbType.VarChar).Value = txt_pno.Text.ToString();
                                cmd.Parameters.Add("gender", SqlDbType.VarChar).Value = txt_gen.Text.ToString();

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Saved successfully");

                                txt_id.Text = "";
                                txt_name.Text = "";
                                txt_add.Text = "";
                                txt_email.Text = "";
                                txt_pno.Text = "";
                                txt_gen.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("plz select your gender");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone no");
                        }
                    }
                    else
                    {
                        MessageBox.Show("plz enter valid email");
                    }
                }
                else
                {
                    MessageBox.Show("plz enter address");
                }
            }
            else
            {
                MessageBox.Show("plz enter trainer name");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "")
            {
                if (txt_name.Text != "")
                {
                    if (IsValidEmail(txt_email.Text))
                    {
                        // Regex reg = new Regex(txt_pno.Text);
                        if (Regex.IsMatch(txt_pno.Text, @"^[0-9]{10}$"))
                        {
                            if (txt_gen.Text != "")
                            {
                                SqlCommand cmd = new SqlCommand("sp_update_trainer", cn);

                                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = txt_id.Text.ToString();
                                cmd.Parameters.Add("name",SqlDbType.VarChar).Value = txt_name.Text.ToString();
                                cmd.Parameters.Add("address",SqlDbType.VarChar).Value= txt_add.Text.ToString();
                                cmd.Parameters.Add("email", SqlDbType.VarChar).Value=txt_email.Text.ToString();
                                cmd.Parameters.Add("pno",SqlDbType.VarChar).Value=txt_pno.Text.ToString();
                                cmd.Parameters.Add("gender",SqlDbType.VarChar).Value = txt_gen.Text.ToString();

                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Reacord updated successfully");

                                txt_id.Text = "";
                                txt_name.Text = "";
                                txt_add.Text = "";
                                txt_email.Text = "";
                                txt_pno.Text = "";
                                txt_gen.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("plz select your gender");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone no");
                        }
                    }
                    else
                    {
                        MessageBox.Show("plz enter valid email");
                    }
                }
                else
                {
                    MessageBox.Show("plz enter address");
                }
            }
            else
            {
                MessageBox.Show("plz enter trainer name");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            String sel = "Select * from trainer";

            SqlDataAdapter sd = new SqlDataAdapter(sel,cn);
            DataSet ds = new DataSet();
            sd.Fill(ds,"trainer");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "trainer";
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_delete_trainer", cn);

                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = txt_id.Text.ToString();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("Plz enter id to delete");
            }

            txt_id.Text = "";
            txt_name.Text = "";
            txt_add.Text = "";
            txt_email.Text = "";
            txt_pno.Text = "";
            txt_gen.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int cnt = 1;

            String que = "select max(t_id) from trainer";
            SqlCommand cmd = new SqlCommand(que, cn);

            SqlDataReader rdr = cmd.ExecuteReader();    
            while(rdr.Read())
            {
                cnt = Convert.ToInt32(rdr[0]);
                cnt++;
                txt_id.Text = cnt.ToString();
            }
            rdr.Close();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(txt_name.Text, "^[a-zA-Z]+$"))
            {

            }
            else
            {
                MessageBox.Show("Numbers not allowed");
                txt_name.Text = "";
            }
        }

        private void txt_add_KeyUp(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(txt_name.Text, "^[a-zA-Z]+$"))
            {

            }
            else
            {
                MessageBox.Show("Numbers not allowed");
                txt_add.Text = "";
            }
        }

        private void txt_pno_KeyUp(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(txt_name.Text, "^[0-9]+$"))
            {

            }
            else
            {
                MessageBox.Show("Alphabets not allowed");
                txt_name.Text = "";
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
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
