using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

        string pathAuto = @"auto.txt";
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
                    WorkBD test = new WorkBD();
                    if (hardPass > 1)
                    {
                        if (!test.userHave(loginText.Text))
                        {
                            using (FileStream fs = File.Create(pathAuto))
                            {
                                byte[] info = new UTF8Encoding(true).GetBytes($"{loginText.Text}\n{passwordText.Password}");
                                // Add some information to the file.
                                fs.Write(info, 0, info.Length);
                            }

                            // строка подключения к базе данных
                            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseLogins.mdf;Integrated Security=True";
                            SqlConnection connection = new SqlConnection(connectionString);
                            connection.Open();
                            string query = $"INSERT INTO Logins(Login, Password) VALUES ('{loginText.Text.ToString()}', '{passwordText.Password.ToString()}')";
                            SqlCommand command = new SqlCommand(query, connection);
                            // выполняем запрос
                            command.ExecuteNonQuery();
                            MainWindow m = new MainWindow();
                            m.Show();
                            connection.Close();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Такой логин уже есть");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Слишком легкий пароль");
                    }


                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }

            }
            else
            {
                MessageBox.Show("Логин должен быть минимум 3 символа");
            }

        }



        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            string pass = passwordText.Password;
            int hardPass = 0;
            if (hasNumber.IsMatch(pass) && pass.Length >= 4) hardPass++;
            if (hasUpperChar.IsMatch(pass) && pass.Length >= 4) hardPass++;
            if (hasUpperCharMini.IsMatch(pass) && pass.Length >= 4) hardPass++;
            if (hasMinimum8Chars.IsMatch(pass) && pass.Length >= 4) hardPass++;
            if (hardPass == 0) { prov.Background = new SolidColorBrush(Colors.Gray); prov.Content = "Не подходит"; }
            else if (hardPass == 1) { prov.Background = new SolidColorBrush(Colors.Red); prov.Content = "Плохой"; }
            else if (hardPass == 2) { prov.Background = new SolidColorBrush(Colors.Orange); prov.Content = "Нормальный"; }
            else if (hardPass == 3) { prov.Background = new SolidColorBrush(Colors.Yellow); prov.Content = "Хороший"; }
            else if (hardPass == 4) { prov.Background = new SolidColorBrush(Colors.LightGreen); prov.Content = "Отличный"; }
        }
        private void passV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordText3.Text = passwordText.Password.ToString();
            passwordText.Visibility = Visibility.Hidden;
            passwordText3.Visibility = Visibility.Visible;
        }

        private void passV_MouseUp(object sender, MouseButtonEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText3.Visibility = Visibility.Hidden;
        }

        private void passV_MouseLeave(object sender, MouseEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText3.Visibility = Visibility.Hidden;
        }
    }
}
