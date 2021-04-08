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
using System.Drawing.Printing;
using System.IO;
//using System.Drawing.Imaging.ImageFormat;
namespace Travelar_System
{
    public partial class Form4 : Form
    {
        
        
        

        public Form4(string id)
        {

            InitializeComponent();
            label1.Text = id;
                       
        }

        public static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string databaseName = "projectdatabase.mdf";
        public static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        

        private void Form4_Load(object sender, EventArgs e)
        {
            string id = label1.Text;
            //label1.Visible = false;
            dataGridView1.Rows.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM Offers where [Travels ID]= '" + id + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["Name of tour"];
                dataGridView1.Rows[n].Cells[1].Value = item["Travels ID"];
                dataGridView1.Rows[n].Cells[2].Value = item["Number of individuals"];
                dataGridView1.Rows[n].Cells[3].Value = item["Individual price"];
                dataGridView1.Rows[n].Cells[4].Value = item["total price"];

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------//
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width-20, s.Height-20, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X+10, this.Location.Y+8, 0, 0, s);
        }

        public string conString = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int x = Convert.ToInt32(phone.Text);
                    string q = "insert into traveler(fullname,phone)values('" + username.Text.ToString() + "','" + x + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("travelar has been Inserted");
                    CaptureScreen();
                    printDocument1.Print();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }
        
                      
    }
    }

