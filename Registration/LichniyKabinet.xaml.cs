using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Registration
{
    /// <summary>
    /// Логика взаимодействия для LichniyKabinet.xaml
    /// </summary>
    public partial class LichniyKabinet : Window
    {

        public void PerehodNaVhod()
        {
            MainWindow Vihod = new MainWindow();
            Vihod.Show();
            Close();
        }

        public LichniyKabinet(string PeredachiyLogin)
        {
            InitializeComponent();

           // Заполнение полей данными пользователя

            Entities userContext = new Entities();

            var Sravnenie = userContext.Persona.FirstOrDefault(p=>p.LoginPolzovately == PeredachiyLogin);
            if (Sravnenie != null)
            {
                LoginText.Content = Sravnenie.LoginPolzovately;
                FioText.Content = Sravnenie.FIO;
                DataRozdeniaText.Content =Convert.ToString(Sravnenie.DataRozdeniy);
                DolznostText.Content = Sravnenie.Dolznost;
                EmailText.Content = Sravnenie.Email;
                TelefonText.Content =Sravnenie.NomerTelephona;
                PolText.Content = Sravnenie.Pol;
                
            }

        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            PerehodNaVhod();
        }

        // Редоктирование полей с личной информацией в зависимости от должности пользоввателя
        private void Redaktirovanie_Click(object sender, RoutedEventArgs e)
        {

                Gotovo.Visibility = Visibility.Visible;

            if (Convert.ToString(DolznostText.Content) == "Администратор")
            {
                LoginText.Visibility = Visibility.Hidden;
                FioText.Visibility = Visibility.Hidden;
                EmailText.Visibility = Visibility.Hidden;
                TelefonText.Visibility = Visibility.Hidden;
                PolText.Visibility = Visibility.Hidden;

                LoginBox.Visibility = Visibility.Visible;
                FioBox.Visibility = Visibility.Visible;
                EmailBox.Visibility = Visibility.Visible;
                TelefonBox.Visibility = Visibility.Visible;
                PolBox.Visibility = Visibility.Visible;
            }
            else
            {
                FioText.Visibility = Visibility.Hidden;
                EmailText.Visibility = Visibility.Hidden;
                TelefonText.Visibility = Visibility.Hidden;
                PolText.Visibility = Visibility.Hidden;

                FioBox.Visibility = Visibility.Visible;
                EmailBox.Visibility = Visibility.Visible;
                TelefonBox.Visibility = Visibility.Visible;
                PolBox.Visibility = Visibility.Visible;

            }
        }

        //Сохранение изменений в БД
       private void Gotovo_Click(object sender, RoutedEventArgs e)
       {
         Entities userContex = new Entities();

          //Сохранение изменений в таблицу Persona

         var Sravnenie = userContex.Persona.FirstOrDefault(p => p.LoginPolzovately == Convert.ToString(LoginText.Content));
         if (Sravnenie != null)
         {


            Sravnenie.LoginPolzovately = LoginBox.Text;
            Sravnenie.FIO = FioBox.Text;
            Sravnenie.Email = EmailBox.Text;
            Sravnenie.NomerTelephona = TelefonBox.Text;
            Sravnenie.Pol = PolBox.Text;

            userContex.SaveChanges();

            LoginText.Content = Sravnenie.LoginPolzovately;
            FioText.Content = Sravnenie.FIO;
            DataRozdeniaText.Content = Convert.ToString(Sravnenie.DataRozdeniy);
            DolznostText.Content = Sravnenie.Dolznost;
            EmailText.Content = Sravnenie.Email;
            TelefonText.Content = Sravnenie.NomerTelephona;
            PolText.Content = Sravnenie.Pol;

         }

         //Сохранение изменений в таблицу Polzovatel

         var Sravnenie1 = userContex.Polzovatel.FirstOrDefault(p => p.Login == Convert.ToString(LoginText.Content));
            if (Sravnenie1 != null)
            {
                Sravnenie1.Login = LoginBox.Text;
                userContex.SaveChanges();
                
            }

            userContex.Dispose();
            Gotovo.Visibility = Visibility.Hidden;

            LoginText.Visibility = Visibility.Visible;
            FioText.Visibility = Visibility.Visible;
            EmailText.Visibility = Visibility.Visible;
            TelefonText.Visibility = Visibility.Visible;
            PolText.Visibility = Visibility.Visible;

            LoginBox.Visibility = Visibility.Hidden;
            FioBox.Visibility = Visibility.Hidden;
            EmailBox.Visibility = Visibility.Hidden;
            TelefonBox.Visibility = Visibility.Hidden;
            PolBox.Visibility = Visibility.Hidden;
        }

     
    }
}
