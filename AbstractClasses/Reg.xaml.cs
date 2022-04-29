using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AbstractClasses
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Go_BackClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
        /*
        public void Test()
        {
            string connection = "server=localhost; user=L1cheE;database=db; password=Misha13242704";
            MySqlConnection connect = new MySqlConnection(connection);
            try
            {
                connect.Open();
                MessageBox.Show("Open");
                connect.Close();
                MessageBox.Show("Close");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegBtnReg_Click(object sender, RoutedEventArgs e)
        {
            Test();
        }
        */





        //БД

        //MySqlConnection connect = new MySqlConnection("server=localhost; user=L1cheE; database=db; password=Misha13242704;");

        
        public void InsertUser()
        {
            string sql = "INSERT INTO db.users(login, password) values ('" + RegLoginText.Text + "','" + RegPassBox.Password + "');";
            MySqlConnection connect = new MySqlConnection("Database = db; Data Source = localhost; User Id = root;Password = Misha13242704");
            MySqlCommand myCommand = new MySqlCommand(sql, connect);

            try
            {
                connect.Open();

                myCommand.Parameters.AddWithValue("@RegLoginText", Convert.ToString(RegLoginText.Text));
                myCommand.Parameters.AddWithValue("@RegPassBox", Convert.ToString(RegPassBox.Password));
                myCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error. \n\n\n\nMore:\n" + ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }

        private void RegBtnReg_Click(object sender, RoutedEventArgs e)
        {
            InsertUser();
        }
        
    }
    
}
