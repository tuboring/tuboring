using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static string nameUser = "";
        //Саша// public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sasha\source\repos\tuboring\WindowsFormsApp1\DatabaseVolleyBall.mdf;Integrated Security=True");
        //Леша //public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex-PC\source\repos\tuboring\WindowsFormsApp1\DatabaseVolleyBall.mdf;Integrated Security=True");

        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Алина\Source\Repos\tuboring\WindowsFormsApp1\DatabaseVolleyBall.mdf;Integrated Security = True");

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
