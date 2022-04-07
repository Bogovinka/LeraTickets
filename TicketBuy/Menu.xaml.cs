using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace TicketBuy
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseLogins.mdf;Integrated Security=True";
        Image image;
        Label name;
        Label note;
        Label size;
        Border border;
        StackPanel res;
        Button but;
        public void relSV()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Concerts", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read())
                {
                    name = new Label();
                    name.Content = read.GetString(0).ToString();
                    name.FontSize = 36;
                    image = new Image();
                    image.Source = new BitmapImage(new Uri($"{Convert.ToString(read.GetValue(1))}.png", UriKind.Relative));
                    size = new Label();
                    size.Content = "Количество мест: " + read.GetValue(2).ToString();
                    note = new Label();
                    note.Content = "Описание: " + read.GetString(3).ToString();
                    border = new Border();
                    border.BorderBrush = Brushes.Black;
                    border.BorderThickness = new Thickness(2, 2, 2, 2);
                    border.Margin = new Thickness(20, 20, 20, 0);
                    border.Background = Brushes.MediumPurple;
                    but = new Button();
                    but.Content = "Купить билет";
                    but.Click += new RoutedEventHandler(Button_Click);
                    but.Tag = read.GetString(0).ToString();
                    res = new StackPanel();
                    res.Children.Add(name);
                    res.Children.Add(image);
                    res.Children.Add(size);
                    res.Children.Add(note);
                    res.Children.Add(but);
                    border.Child = res;
                    sP.Children.Add(border);
                }
            }
        }
        public Menu()
        {
            InitializeComponent();
            loginName.Content = $"Логин: {File.ReadLines("auto.txt").First()}";
            if (File.ReadLines("auto.txt").First() == "admin") add.Visibility = Visibility.Visible;
            relSV();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button) sender;
            MessageBox.Show($"Нажал на {b.Tag.ToString()}");
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddC a = new AddC();
            a.Show();
            this.Close();
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}
