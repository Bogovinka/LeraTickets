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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicketBuy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathAuto = @"auto.txt";
        int countL = 0;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                loginText.Text = File.ReadLines("auto.txt").First();
                passwordText.Password = File.ReadLines("auto.txt").Skip(1).First();
            }
            catch { }
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            WorkBD f = new WorkBD();
            if (countL >= 3)
            {
                Capcha c = new Capcha();
                c.ShowDialog();
                if (c.DialogResult == true)
                {
                    if (f.userHave(loginText.Text, passwordText.Password))
                    {
                        Menu m = new Menu();
                        m.Show();
                        using (FileStream fs = File.Create(pathAuto))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes($"{loginText.Text}\n{passwordText.Password}");
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                        this.Close();
                    }
                    else
                    {
                        countL = 0;
                        MessageBox.Show("Такого пользователя не существует или такого пароля");
                    }
                }
            }
            else
            {
                if (f.userHave(loginText.Text, passwordText.Password))
                {
                    using (FileStream fs = File.Create(pathAuto))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes($"{loginText.Text}\n{passwordText.Password}");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                    Menu m = new Menu();
                    m.Show();
                    this.Close();
                }
                else
                {
                    countL++;
                    MessageBox.Show("Такого пользователя не существует или такого пароля");
                }
            }

        }

        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }



        private void passV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordText2.Text = passwordText.Password.ToString();
            passwordText.Visibility = Visibility.Hidden;
            passwordText2.Visibility = Visibility.Visible;
        }

        private void passV_MouseUp(object sender, MouseButtonEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText2.Visibility = Visibility.Hidden;
        }

        private void passV_MouseLeave(object sender, MouseEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText2.Visibility = Visibility.Hidden;
        }

    }
}
