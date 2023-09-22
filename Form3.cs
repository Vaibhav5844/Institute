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

namespace institute1
{
    public partial class Form3 : Form
    {
        SqlConnection cn = null;
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=VAIBHAV\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
            cn.Open();


            SqlCommand cmd = new SqlCommand("Select * from Cource", cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txt_c_name.Items.Add(rdr[1]);
            }
            rdr.Close();

            SqlCommand cm = new SqlCommand("Select * from trainer",cn);
            SqlDataReader cmdr = cm.ExecuteReader();
            while(cmdr.Read())
            {
                txt_t_name.Items.Add(cmdr[1]);
            }
            cmdr.Close();
        }

        private void txt_c_name_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_save_batches",cn);

            cmd.Parameters.Add("id",SqlDbType.VarChar).Value=txt_id.Text.ToString();
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = txt_c_name.Text.ToString();
            cmd.Parameters.Add("sdate", SqlDbType.Date).Value = txt_start.Text.ToString();
            cmd.Parameters.Add("time", SqlDbType.VarChar).Value = txt_time.Text.ToString();
            cmd.Parameters.Add("trainer", SqlDbType.VarChar).Value = txt_t_name.Text.ToString();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sel = "select * from batches";

            SqlCommand cmd = new SqlCommand(sel,cn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sa.Fill(ds,"batches");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "batches";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_delete_batches", cn);

            cmd.Parameters.Add("id",SqlDbType.VarChar).Value=txt_id.Text.ToString();

            cmd.CommandType= CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully");

            txt_id.Text = "";
            txt_start.Text = "";
            txt_time.Text = "";
            txt_c_name.Text = "";
            txt_t_name.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            int cnt = 1;

            SqlCommand cmd = new SqlCommand("select max(B_id) from batches",cn);

            SqlDataReader srd = cmd.ExecuteReader();
            while(srd.Read())
            {
                cnt = Convert.ToInt32(srd[0]);
                cnt++;
                txt_id.Text = cnt.ToString();
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
