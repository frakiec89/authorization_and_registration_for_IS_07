using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfApp3.DB;

// track


namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btIn.Click += BtIn_Click;
            btReg.Click += BtReg_Click;
        }

        private void BtReg_Click(object sender, RoutedEventArgs e)
        {
           AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.ShowDialog();
        }

        private void BtIn_Click(object sender, RoutedEventArgs e)
        {
        // вадидации  

            try
            {
                Services.UserService service = new Services.UserService();
             
                if (service.IsUser(tbLogin.Text , tbPassword.Text))
                {

                    MessageBox.Show("привет " + service.GetUserName(tbLogin.Text, tbPassword.Text));
                }
                else
                {
                    MessageBox.Show("пользователь не найден!");
                }
            }
            catch 
            {
                MessageBox.Show("ошибка  бд");
            }
        }
    }
}
