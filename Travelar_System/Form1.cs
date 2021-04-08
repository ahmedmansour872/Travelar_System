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

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string databaseName = "projectdatabase.mdf";
        public string conString = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        private void login_Load(object sender, EventArgs e)
        {
            username.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd1 = new SqlCommand(@"SELECT Count(*) FROM admin WHERE Username=@uname and Password=@pass", Connection);
                    cmd1.Parameters.AddWithValue("@uname", username.Text);
                    cmd1.Parameters.AddWithValue("@pass", password.Text);
                    int result1 = (int)cmd1.ExecuteScalar(); 
                    
                    //----------------------------
                    SqlCommand cmd2 = new SqlCommand(@"SELECT Count(*) FROM signup WHERE username=@uname and password=@pass", Connection);
                    cmd2.Parameters.AddWithValue("@uname", username.Text);
                    cmd2.Parameters.AddWithValue("@pass", password.Text);
                    int result2 = (int)cmd2.ExecuteScalar();
                    //-----------------------
                    if (result1 > 0)
                    {
                        //MessageBox.Show("Login Success");
                        
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        this.Close();
                    }
                    if (result2 > 0)
                    {
                       // MessageBox.Show("Login Success");

                        this.Hide();
                       // Form3 f3 = new Form3();


                        Form3 f333 = new Form3(username.Text);
                        f333.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Incorrect login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }

                
                
                    
                
               

            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

