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
    public partial class Form3 : Form
    {
        
        public Form3(string user)
        {
            InitializeComponent();
            label10.Text = user;
        }
        public static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string databaseName = "projectdatabase.mdf";
        public string conString = (@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
       
        
        private void Form3_Load(object sender, EventArgs e)
        {
            name.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add1 done

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(num.Text);
                    int i2 = Convert.ToInt32(price.Text);
                    int total = i * i2;
                    
                 
                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + label4.Text.ToString() + "','" + name.Text.ToString() + "','" + i + "','" + i2 + "','" + total.ToString() + "')";
                    
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                   
                    Form4 f4 = new Form4(name.Text);
                    f4.ShowDialog();
                    //this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add2 done
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(num1.Text);
                    int i2 = Convert.ToInt32(price1.Text);
                    int total = i * i2;

                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + label6.Text.ToString() + "','" + name1.Text.ToString() + "','" + i + "','" + i2 + "','" + total + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form4 f4 = new Form4(name1.Text);
                    f4.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        

       
       

        private void button4_Click(object sender, EventArgs e)
        {
            //add 4
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(textBox10.Text);
                    int i2 = Convert.ToInt32(textBox8.Text);
                    int total = i * i2;

                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + label20.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + total.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form4 f4 = new Form4(textBox9.Text);
                    f4.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //add 5
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(textBox14.Text);
                    int i2 = Convert.ToInt32(textBox12.Text);
                    int total = i * i2;

                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + label25.Text.ToString() + "','" + textBox13.Text.ToString() + "','" + textBox14.Text.ToString() + "','" + textBox12.Text.ToString() + "','" + total.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form4 f4 = new Form4(textBox13.Text);
                    f4.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //add 6
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(textBox18.Text);
                    int i2 = Convert.ToInt32(textBox16.Text);
                    int total = i * i2;

                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + label30.Text.ToString() + "','" + textBox17.Text.ToString() + "','" + textBox18.Text.ToString() + "','" + textBox16.Text.ToString() + "','" + total.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form4 f4 = new Form4(textBox17.Text);
                    f4.ShowDialog();
                   // this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //add 3
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(num2.Text);
                    int i2 = Convert.ToInt32(price2.Text);
                    int total = i * i2;

                    string q = "insert into Offers([Name of tour],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + eeeee.Text.ToString() + "','" + name3.Text.ToString() + "','" + i + "','" + i2 + "','" + total + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form4 f4 = new Form4(name3.Text);
                    f4.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }


        private void img_clik(object sender, EventArgs e)
        {
            if (sender == pictureBox1) {
                Form6 f333 = new Form6(pictureBox1.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox2)
            {
                Form6 f333 = new Form6(pictureBox2.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox3)
            {
                Form6 f333 = new Form6(pictureBox3.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox4)
            {
                Form6 f333 = new Form6(pictureBox4.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox5)
            {
                Form6 f333 = new Form6(pictureBox5.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox6)
            {
                Form6 f333 = new Form6(pictureBox6.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox7)
            {
                Form6 f333 = new Form6(pictureBox7.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox8)
            {
                Form6 f333 = new Form6(pictureBox8.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox9)
            {
                Form6 f333 = new Form6(pictureBox9.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox10)
            {
                Form6 f333 = new Form6(pictureBox10.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox11)
            {
                Form6 f333 = new Form6(pictureBox11.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox12)
            {
                Form6 f333 = new Form6(pictureBox13.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox14)
            {
                Form6 f333 = new Form6(pictureBox14.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox15)
            {
                Form6 f333 = new Form6(pictureBox15.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox16)
            {
                Form6 f333 = new Form6(pictureBox16.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox17)
            {
                Form6 f333 = new Form6(pictureBox17.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox18)
            {
                Form6 f333 = new Form6(pictureBox18.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox19)
            {
                Form6 f333 = new Form6(pictureBox19.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox20)
            {
                Form6 f333 = new Form6(pictureBox20.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox21)
            {
                Form6 f333 = new Form6(pictureBox21.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox22)
            {
                Form6 f333 = new Form6(pictureBox22.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox23)
            {
                Form6 f333 = new Form6(pictureBox23.Image);
                f333.ShowDialog();
            }
            if (sender == pictureBox24)
            {
                Form6 f333 = new Form6(pictureBox24.Image);
                f333.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //custom tour

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    int i = Convert.ToInt32(textBox4.Text);
                    int i2 = Convert.ToInt32(textBox19.Text);
                    int total = i * i2;

                    string q = "insert into Custom_tour([Name of tour],[Description],[Travels ID],[Number of individuals],[Individual price],[total price])values('" + textBox20.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox19.Text.ToString() + "','" + textBox4.ToString() + "','" + total.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("offer has been Inserted");
                    //this.Hide();
                    Form7 f4 = new Form7(textBox6.Text);
                    f4.ShowDialog();
                    // this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("insert is not complet" + ex);

            }

        }

        
    }
}
