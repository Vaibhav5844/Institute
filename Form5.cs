using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace institute1
{
    public partial class Form5 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();
        }
        public static bool IsValidEmail(string email)
        {
            String emailPattern = @"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (String.IsNullOrEmpty(email))
                return false;

            Regex reg = new Regex(emailPattern);
            return reg.IsMatch(email);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (txt_add.Text != "")
                {
                    if (IsValidEmail(txt_email.Text))
                    {
                        // Regex reg = new Regex(txt_pno.Text);
                        if (Regex.IsMatch(txt_pno.Text, @"^[0-9]{10}$"))
                        {
                            if (txt_gender.Text != "")
                            {
                                if (txt_time.Text != "")
                                {
                                    if (txt_mode.Text != "")
                                    {
                                        SqlCommand cmd = new SqlCommand("sp_insert_enquiry", cn);

                                        cmd.Parameters.Add("sid", SqlDbType.VarChar).Value = txt_id.Text.ToString();
                                        cmd.Parameters.Add("date", SqlDbType.VarChar).Value = txt_date.Text.ToString();
                                        cmd.Parameters.Add("add", SqlDbType.VarChar).Value = txt_add.Text.ToString();
                                        cmd.Parameters.Add("gender", SqlDbType.VarChar).Value = txt_gender.Text.ToString();
                                        cmd.Parameters.Add("pno", SqlDbType.VarChar).Value = txt_pno.Text.ToString();
                                        cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txt_email.Text.ToString();
                                        cmd.Parameters.Add("btime", SqlDbType.VarChar).Value = txt_time.Text.ToString();
                                        cmd.Parameters.Add("mode", SqlDbType.VarChar).Value = txt_mode.Text.ToString();




                                        cmd.CommandType = CommandType.StoredProcedure;

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Reacord inserted successfully");

                                        txt_id.Text = "";
                                        txt_gender.Text = "";
                                        txt_add.Text = "";
                                        txt_email.Text = "";
                                        txt_pno.Text = "";
                                        txt_time.Text = "";
                                        txt_mode.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Plz select mode");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Plz enter time");
                                }
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
                MessageBox.Show("plz enter student id");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int cnt = 1;

            String que = "select max(Student_id) from enquiry";
            SqlCommand cmd = new SqlCommand(que, cn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cnt = Convert.ToInt32(rdr[0]);
                cnt++;
                txt_id.Text = cnt.ToString();
            }
            rdr.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                SqlCommand cmd = new SqlCommand("sp_delete_enquiry", cn);

                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = txt_id.Text.ToString();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");

                txt_id.Text = "";
                txt_gender.Text = "";
                txt_add.Text = "";
                txt_email.Text = "";
                txt_pno.Text = "";
                txt_time.Text = "";
                txt_mode.Text = "";
            }
            else
            {
                MessageBox.Show("Plz enter student id");
            }
        }

        private void txt_pno_KeyUp(object sender, KeyEventArgs e)
        {
            /*if(Regex.IsMatch(txt_pno.Text,"[0-9]+$"))
            {

            }
            else
            {
                MessageBox.Show("Phone no cannot contain numbers");
                txt_pno.Text = "";
            } */
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
