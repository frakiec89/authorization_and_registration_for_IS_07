
using System;
using System.Windows;
// track

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void btAddus_Click(object sender, RoutedEventArgs e)
        {

            /// валидация 
            if (tb_name.Text == "")
            {
                MessageBox.Show("Пустое  имя ");
                return;
            }

            /// валидация 
            if (tb_email.Text == "")
            {
                MessageBox.Show("Пустой емеил ");
                return;
            }


            /// валидация 
            if (tb_password.Text == "")
            {
                MessageBox.Show("Пустое  пароль ");
                return;
            }


            try
            {
                Services.UserService services = new Services.UserService();
                services.AddUser(tb_name.Text, tb_email.Text, tb_password.Text);
                MessageBox.Show("Ура");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка  бд \n" + ex.Message);
            }
        }
    }
}
