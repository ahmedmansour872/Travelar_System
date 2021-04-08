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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
             string path = Path.GetFullPath(Environment.CurrentDirectory);
         string databaseName = "projectdatabase.mdf";
         SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

            SqlDataAdapter sda2 = new SqlDataAdapter("select  e.fullname,e.phone,m.[Name of tour],m.[Travels ID],m.[Number of individuals],m.[Individual price],m.[total price] from Offers m inner JOIN  traveler e on e.ID =m.ID", con); 
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["fullname"];
                dataGridView1.Rows[n].Cells[1].Value = item["phone"];
                dataGridView1.Rows[n].Cells[2].Value = item["Name of tour"];
                dataGridView1.Rows[n].Cells[3].Value = item["Travels ID"];
                dataGridView1.Rows[n].Cells[4].Value = item["Number of individuals"];
                dataGridView1.Rows[n].Cells[5].Value = item["Individual price"];
                dataGridView1.Rows[n].Cells[6].Value = item["total price"];

            }
            // num of booking 

            string s2 = "select count(*)from Offers";
            SqlCommand ss2 = new SqlCommand(s2, con);
            con.Open();
            l1.Text = ss2.ExecuteScalar().ToString();
            con.Close();
            // Avg to num of individuals
            string s3 = "select AVG([Number of individuals]) from Offers";
            SqlCommand ss3 = new SqlCommand(s3, con);
            con.Open();
            l2.Text = ss3.ExecuteScalar().ToString();
            con.Close();

            // sum
            string s1 = "select sum([total price])from Offers";
            SqlCommand ss1 = new SqlCommand(s1, con);
            con.Open();
            l3.Text = ss1.ExecuteScalar().ToString();
            con.Close();
            //num of Tour in Aswan
            string t1 = "select count([Name of tour])from Offers where [Name of tour]= 'Tour in Aswan';";
            SqlCommand tt1 = new SqlCommand(t1, con);
            con.Open();
            ll1.Text = tt1.ExecuteScalar().ToString();
            con.Close();
            //num of Tour in Luxor
            string t2 = "select count([Name of tour])from Offers where [Name of tour]= 'Tour in Luxor';";
            SqlCommand tt2 = new SqlCommand(t2, con);
            con.Open();
            ll2.Text = tt2.ExecuteScalar().ToString();
            con.Close();
            //num of Cairo Tours from El Gouna
            string t3 = "select count([Name of tour])from Offers where [Name of tour]= 'Cairo Tours from El Gouna';";
            SqlCommand tt3 = new SqlCommand(t3, con);
            con.Open();
            ll3.Text = tt3.ExecuteScalar().ToString();
            con.Close();
            //num of Alexandria Day Tour 
            string t4 = "select count([Name of tour])from Offers where [Name of tour]= 'Alexandria Day Tour';";
            SqlCommand tt4 = new SqlCommand(t4, con);
            con.Open();
            ll4.Text = tt4.ExecuteScalar().ToString();
            con.Close();
            //num of Nile Cruise Tour in Sharm  
            string t5 = "select count([Name of tour])from Offers where [Name of tour]= 'Nile Cruise Tour in Sharm';";
            SqlCommand tt5 = new SqlCommand(t5, con);
            con.Open();
            ll5.Text = tt5.ExecuteScalar().ToString();
            con.Close();
            //num of Giftun Tours in Hurghada 
            string t6 = "select count([Name of tour])from Offers where [Name of tour]= 'Giftun Tours in Hurghada';";
            SqlCommand tt6 = new SqlCommand(t6, con);
            con.Open();
            ll6.Text = tt6.ExecuteScalar().ToString();
            con.Close();

        }
    }
}
