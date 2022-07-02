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

namespace Burtsev_PR315_Lombard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtBoxLogin.Text = String.Empty;
            txtBoxPassword.Text = String.Empty;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Workman user = null;
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;
            LombardEntities entities = new LombardEntities();

            user = entities.Workmen.FirstOrDefault(itUser => itUser.Login == login);

            if (user == null)
            {
                MessageBox.Show("Пользователь с данным логином не найден");
                return;
            }

            user = entities.Workmen.FirstOrDefault(itUser => itUser.Login == login && itUser.Password == password);
            if (user == null)
            {
                MessageBox.Show("введён не правильный пароль");
            }

            else
            {
                MessageBox.Show($"Пользователь с именем {user.FullName} найден");
            }
        }
    }
}
