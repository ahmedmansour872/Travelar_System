using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelar_System
{
    static class Program
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "projectdatabase.mdf";
        public static SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
        
        /// <summary>
        /// 
        /// The main entry point for the application.
        /// </summary>
       
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
