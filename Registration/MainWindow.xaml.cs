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
using System.Data.Entity;



namespace Registration
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


        //Проверка на совпадение значений БД, для последующего входа в личный кабинет
        private void Vhod_Click(object sender, RoutedEventArgs e)   
        {
            Entities userContext = new Entities();

            var Proverka = userContext.Polzovatel.FirstOrDefault(p => p.Parol == ParolText.Password && p.Login == LoginText.Text);

            if (ParolText.Password != "" && LoginText.Text != "")
            {
                if (Proverka != null)
                {
                    MessageBox.Show("Welcome to Deep Dark Fantasy.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);

                    var PeredachiyLogin = LoginText.Text;
                    LichniyKabinet lichniyKabinet = new LichniyKabinet(PeredachiyLogin);
                    lichniyKabinet.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Неверный Логин или пароль.", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Не введен логин или пароль!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        //Переход на окно регистрации
        private void OtkritieRegistraciy_Click(object sender, RoutedEventArgs e)
        {
            FormaRegistraciy formaRegistraciy = new FormaRegistraciy();
            formaRegistraciy.Show();
            Close();
        }
    }
}
