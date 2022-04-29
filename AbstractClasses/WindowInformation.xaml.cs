using System;
using System.Collections.Generic;
using System.IO;
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
using AbstractClasses;


namespace AbstractClasses
{
    /// <summary>
    /// Логика взаимодействия для WindowInformation.xaml
    /// </summary>
    public partial class WindowInformation : Window
    {
        internal WindowInformation(Client client, Manager manager, Admin admin, string Role) // Присваивание полей к переменным.
        {
            InitializeComponent();

            if (Role == "Admin")
            {
                LabelBalance.Content = "Остаток на скаде: " + admin.Balance + " шт";
                LabelRole.Content = admin.RoleUser;
                LabelName.Content = admin.NameUser;
                LabelPrice.Content = "Цена в $: " + admin.Price;
                LabelCost.Content = "Цена двойного кресла в $: " + admin.Cost + " за 1шт";
            }
            else if (Role == "Client")
            {
                LabelRole.Content = client.RoleUser;
                LabelName.Content = client.NameUser;
                LabelPrice.Content = "Цена в $: " + client.Price;
            }
            else
            {
                LabelRole.Content = manager.RoleUser;
                LabelName.Content = manager.NameUser;
                LabelPrice.Content = "Цена в $: " + manager.Price;
                LabelBalance.Content = "Остаток на скаде: " + manager.Balance + " шт";
            }
        }

        private void ButtonMain_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\AbstractClasses\AbstractClasses\source\Boeing747-400.txt"));
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
            Application.Current.MainWindow.Close();
        }
    }
}

