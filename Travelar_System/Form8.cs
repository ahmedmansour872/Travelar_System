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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "projectdatabase.mdf";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

            SqlDataAdapter sda2 = new SqlDataAdapter("select  e.fullname,e.phone,m.[Name of tour],m.[Description],m.[Travels ID],m.[Number of individuals],m.[Individual price],m.[total price] from Custom_tour m inner JOIN  traveler_custom e on e.ID =m.ID", con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["fullname"];
                dataGridView1.Rows[n].Cells[1].Value = item["phone"];
                dataGridView1.Rows[n].Cells[2].Value = item["Name of tour"];
                dataGridView1.Rows[n].Cells[3].Value = item["Description"];
                dataGridView1.Rows[n].Cells[4].Value = item["Travels ID"];
                dataGridView1.Rows[n].Cells[5].Value = item["Number of individuals"];
                dataGridView1.Rows[n].Cells[6].Value = item["Individual price"];
                dataGridView1.Rows[n].Cells[7].Value = item["total price"];

            }
            // num of booking 

            string s2 = "select count(*)from Custom_tour";
            SqlCommand ss2 = new SqlCommand(s2, con);
            con.Open();
            l1.Text = ss2.ExecuteScalar().ToString();
            con.Close();
            // Avg to num of individuals
            string s3 = "select AVG([Number of individuals]) from Custom_tour";
            SqlCommand ss3 = new SqlCommand(s3, con);
            con.Open();
            l2.Text = ss3.ExecuteScalar().ToString();
            con.Close();

            // sum
            string s1 = "select sum([total price])from Custom_tour";
            SqlCommand ss1 = new SqlCommand(s1, con);
            con.Open();
            l3.Text = ss1.ExecuteScalar().ToString();
            con.Close();
            
        }
    }
}
