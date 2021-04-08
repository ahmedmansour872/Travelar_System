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
using System.IO;
namespace Travelar_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string databaseName = "projectdatabase.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

        public string conString = (@"Data Source=(localdb)MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            //add employee
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                    string q = "insert into signup(username,password,salary,department,phone)values('" + username.Text.ToString() + "','" + password.Text.ToString() + "','" + salary.Text.ToString() + "','" + department.Text.ToString() + "','" + phone.Text.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee has been Inserted");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //show emploee
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM signup ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
               
                 dataGridView1.Rows[n].Cells[0].Value = item["Username"];
                dataGridView1.Rows[n].Cells[1].Value = item["Password"];
                dataGridView1.Rows[n].Cells[2].Value = item["Salary"];
                dataGridView1.Rows[n].Cells[3].Value = item["Department"];
                dataGridView1.Rows[n].Cells[4].Value = item["Phone"];
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("delete FROM signup WHERE username='" + username.Text + "'and password='" + password.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("ID has been deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete  is not complet" + ex);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update signup SET username='" + username.Text + "',password='" + password.Text + "',salary='" + salary.Text + "',department='" + department.Text + "',phone='" + phone.Text + "'WHERE username='" + username.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show(" Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update  is not complet" + ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f333 = new Form3(label4.Text);
            f333.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form5 f5 = new Form5();
            f5.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
