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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
//using AbstractClasses;

namespace AbstractClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //настройка первоначального вида
        static string Role_1 = "";
        static string Name_1 = "";
        static float Price_1 = 0;
        static float Balance_1 = 0;
        static float Cost_1 = 0;

        User user = new User(Name_1, Role_1);
        Client client = new Client(Name_1, Role_1, Price_1);
        Manager manager = new Manager(Name_1,Role_1, Price_1, Balance_1);
        Admin admin = new Admin(Name_1,Role_1,Balance_1,Price_1, Cost_1);
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
            Application.Current.MainWindow.Close();
        }

        

        //public void checkUser()
        //{

        //    string select = "SELECT * FROM db.users WHERE login = '" + LoginTextBox.Text + "' and password = '" + LoginPassBox.Password + "';";
        //    //string sql = "INSERT INTO db.users(login, password) values ('" + RegLoginText.Text + "','" + RegPassBox.Password + "');";
        //    MySqlConnection connect = new MySqlConnection("Database = db; Data Source = localhost; User Id = root;Password = Misha13242704");
        //    //MySqlDataReader mySelect = new MySqlDataReader(select, connect);
        //    using (MySqlCommand mySelect = new MySqlCommand(select, connect))

        //    try
        //    {
            
        //        connect.Open();

        //        MySqlDataReader data = mySelect.ExecuteReader();
        //            if (data.Read())
        //            {
        //                //MessageBox.Show("Пользователь найден");
        //                ChoiceRole();
        //            }
        //            else
        //                MessageBox.Show("Его нет(((");
            
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Database connection error. \n\n\n\nMore:\n" + ex.ToString());//вывод сообщения об ошибке.
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }

        //}

        /*
        string select = "SELECT * FROM db.users WHERE login = '" + LoginTextBox.Text + "' and password = '" + LoginPassBox.Password + "';";
            //string sql = "INSERT INTO db.users(login, password) values ('" + RegLoginText.Text + "','" + RegPassBox.Password + "');";
            MySqlConnection connect = new MySqlConnection("Database = db; Data Source = localhost; User Id = root;Password = Misha13242704");
            //MySqlDataReader mySelect = new MySqlDataReader(select, connect);
            using (MySqlCommand mySelect = new MySqlCommand(select, connect))
        */
        public string r;

        //проверка loginBox.text на правильность введенной информации
        public void ChoiceRole(string r)
        {
            if (r == "Client")
            {
                client = new Client("Ivan", "Client", 238000000);

            }
            else if (r == "Manager")
            {
                manager = new Manager("Andrey", "Manager", 238000000, 5);
            }
            else if(r == "Admin") 
            {
                admin = new Admin("Michail", "Admin", 238000000, 5, 450);
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }
        ///////////////////////////////////////////////////////////////////////////


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            r = LoginTextBox.Text.ToString();
            if (r == "")// Проверка на пустое значение LoginBox.Text
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                ChoiceRole(r);
                this.Hide();
                WindowInformation mainWindow = new WindowInformation(client, manager, admin, r);
                mainWindow.Show();
                Application.Current.MainWindow.Close();
            }
        }
    }
}
