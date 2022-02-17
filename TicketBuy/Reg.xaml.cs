using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TicketBuy
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        Regex hasNumber = new Regex(@"[0-9]+");
        Regex hasUpperChar = new Regex(@"[A-Z]+");
        Regex hasUpperCharMini = new Regex(@"[a-z]+");
        Regex hasMinimum8Chars = new Regex(@".{8,}");

        public Reg()
        {
            InitializeComponent();
        }
        private void nextB_Click(object sender, RoutedEventArgs e)
        {
            if (loginText.Text.Replace(" ", "").Length >= 3)
            {
                if (passwordText.Password == passwordText2.Password)
                {
                    string pass = passwordText.Password;
                    int hardPass = 0;
                    if (hasNumber.IsMatch(pass)) hardPass++;
                    if (hasUpperChar.IsMatch(pass)) hardPass++;
                    if (hasUpperCharMini.IsMatch(pass)) hardPass++;
                    if (hasMinimum8Chars.IsMatch(pass)) hardPass++;
                    if (hardPass > 1)
                    {
                        Menu m = new Menu();
                        m.Show();
                    }
                    else MessageBox.Show("Слишком легкий пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else MessageBox.Show("Пароли не совпадают", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else MessageBox.Show("Логин должен быть минимум 3 символа", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void passwordText_KeyUp(object sender, KeyEventArgs e)
        {
            string pass = passwordText.Password;
            int hardPass = 0;
            if (hasNumber.IsMatch(pass)) hardPass++;
            if (hasUpperChar.IsMatch(pass)) hardPass++;
            if (hasUpperCharMini.IsMatch(pass)) hardPass++;
            if (hasMinimum8Chars.IsMatch(pass)) hardPass++;
            if (hardPass <= 1) prov.Background = new SolidColorBrush(Colors.Red);
            else if (hardPass == 2) prov.Background = new SolidColorBrush(Colors.Orange);
            else if (hardPass == 3) prov.Background = new SolidColorBrush(Colors.Yellow);
            else if (hardPass == 4) prov.Background = new SolidColorBrush(Colors.LightGreen);
        }
    }
}
