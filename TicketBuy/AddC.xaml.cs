using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AddC.xaml
    /// </summary>
    public partial class AddC : Window
    {
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseLogins.mdf;Integrated Security=True";
        public AddC()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            int test;
            if (int.TryParse(Size.Text, out test) && int.TryParse(Image.Text, out test))
            {
                if (Convert.ToInt32(Image.Text) < 5 && Convert.ToInt32(Image.Text) > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCom = new SqlCommand($"INSERT INTO Concerts VALUES(N'{Name.Text}', N'{Image.Text}', N'{Size.Text}', N'{Note.Text}')", connection);
                        connection.Open();
                        sqlCom.ExecuteNonQuery();
                        Menu m = new Menu();
                        m.Show();
                        this.Close();
                    }
                }
                else MessageBox.Show("Нет такого номера картинки");
            }
            else MessageBox.Show("В строке картика или в строке количество мест вы вели буквы");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
