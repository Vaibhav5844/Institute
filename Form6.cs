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

namespace institute1
{
    public partial class Form6 : Form
    {
        SqlConnection cn = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from enquiry",cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                txt_stud_id.Items.Add(rdr[0]);
                
            }
            rdr.Close();

            SqlCommand cm = new SqlCommand("select * from Cource", cn);
            SqlDataReader rd = cm.ExecuteReader();
            while (rd.Read())
            {
                txt_course.Items.Add(rd[1]);

            }
            rd.Close();


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_add_id.Text != "")
            {
                if (txt_stud_id.Text != "")
                {

                    if (txt_stud_name.Text != "")
                    {
                        if (txt_course.Text != "")
                        {
                            if (txt_mode.Text != "")
                            {

                                SqlCommand cmd = new SqlCommand("sp_save_admission", cn);

                                cmd.Parameters.Add("aid", SqlDbType.VarChar).Value = txt_add_id.Text.ToString();
                                cmd.Parameters.Add("sid", SqlDbType.VarChar).Value = txt_stud_id.Text.ToString();
                                cmd.Parameters.Add("date", SqlDbType.VarChar).Value = txt_date.Text.ToString();
                                cmd.Parameters.Add("snane", SqlDbType.VarChar).Value = txt_stud_name.Text.ToString();
                                cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txt_email.Text.ToString();
                                cmd.Parameters.Add("address", SqlDbType.VarChar).Value = txt_address.Text.ToString();
                                cmd.Parameters.Add("pno", SqlDbType.VarChar).Value = txt_pno.Text.ToString();
                                cmd.Parameters.Add("gender", SqlDbType.VarChar).Value = txt_gender.Text.ToString();
                                cmd.Parameters.Add("c_name", SqlDbType.VarChar).Value = txt_course.Text.ToString();
                                cmd.Parameters.Add("b_time", SqlDbType.VarChar).Value = txt_b_time.Text.ToString();
                                cmd.Parameters.Add("mode", SqlDbType.VarChar).Value = txt_mode.Text.ToString();
                                cmd.Parameters.Add("fee", SqlDbType.VarChar).Value = txt_fee.Text.ToString();
                                cmd.Parameters.Add("fee_type", SqlDbType.VarChar).Value = txt_fee_type.Text.ToString();
                                cmd.Parameters.Add("balance", SqlDbType.VarChar).Value = txt_fee.Text.ToString();
                                

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record saved successfully");

                                txt_add_id.Text = "";
                                txt_stud_id.Text = "";
                                txt_date.Text = "";
                                txt_stud_name.Text = "";
                                txt_email.Text = "";
                                txt_address.Text = "";
                                txt_pno.Text = "";
                                txt_gender.Text = "";
                                txt_course.Text = "";
                                txt_b_time.Text = "";
                                txt_mode.Text = "";
                                txt_fee.Text = "";
                                txt_fee_type.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("plz select mode");
                            }
                        }
                        else
                        {
                            MessageBox.Show("plz select course");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Plz enter student name");
                    }
                }
                else
                {
                    MessageBox.Show("Plz enter student address");
                }
            }
            
            else
            {
                MessageBox.Show("Plz enter addmission id");
            }
        }

        private void txt_stud_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from enquiry where Student_id="+txt_stud_id.Text+";",cn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txt_address.Text = Convert.ToString(rdr[2]);
                txt_gender.Text = Convert.ToString(rdr[3]);
                txt_pno.Text = Convert.ToString(rdr[4]);
                txt_email.Text = Convert.ToString(rdr[5]);
                txt_mode.Text = Convert.ToString(rdr[7]);
            }
            rdr.Close();
        }

        private void txt_fee_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_course.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Cource where co_name='" + txt_course.Text + "';", cn);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    if (txt_fee_type.Text == "One Time")
                    {
                        txt_fee.Text = Convert.ToString(sdr[4]);
                    }
                    else
                    {
                        txt_fee.Text = Convert.ToString(sdr[3]);
                    }
                }
                sdr.Close();
            }
        }

        private void txt_course_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_fee_type.Text != "")
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Cource where co_name='" + txt_course.Text + "';", cn);
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    if (txt_fee_type.Text == "One Time")
                    {
                        txt_fee.Text = Convert.ToString(sdr[4]);
                    }
                    else
                    {
                        txt_fee.Text = Convert.ToString(sdr[3]);
                    }
                }
                sdr.Close();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_delete_admission",cn);

            cmd.Parameters.Add("id",SqlDbType.VarChar).Value = txt_add_id.Text;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully");
            txt_add_id.Text = "";
            txt_stud_id.Text = "";
            txt_date.Text = "";
            txt_stud_name.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_pno.Text = "";
            txt_gender.Text = "";
            txt_course.Text = "";
            txt_b_time.Text = "";
            txt_mode.Text = "";
            txt_fee.Text = "";
            txt_fee_type.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int cnt = 1;
            SqlCommand cmd = new SqlCommand("select max(Add_id) from admission",cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                cnt = Convert.ToInt32(rdr[0]);
                cnt++;
                txt_add_id.Text = cnt.ToString();
            }
            rdr.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMDI f1 = new frmMDI();
            f1.Show();
        }
    }
}
