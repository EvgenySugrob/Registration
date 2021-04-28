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
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class FormaRegistraciy : Window
    {
        public FormaRegistraciy()
        {
            InitializeComponent();
        }

        public void PerehodNaAvtorizaciy()
        {
            MainWindow formaAvtorizaciy = new MainWindow();
            formaAvtorizaciy.Show();
            Close();
        }


        //Сохранение значений в базу данных
        public static void RegistrPerson(string LoginPolzovately1, string Parol1, string Dolznost1, string FIO1, string DataRozdeniy1, string NomerTelephona1, string Email1, string Pol1)
        {
            //Сохранение значений в талицу Persona
            Entities userContext = new Entities();
            Persona persona = new Persona
            {
                LoginPolzovately = LoginPolzovately1,
                Dolznost = Dolznost1,
                FIO = FIO1,
                DataRozdeniy = DateTime.Parse(DataRozdeniy1),
                NomerTelephona = NomerTelephona1,
                Email = Email1,
                Pol = Pol1
            };


            //Сохранение значений в таблицу Polzavately
            Polzovatel polzovatel = new Polzovatel
            {
                Login = persona.LoginPolzovately,
                Parol = Parol1

            };
            persona.KodPolzovately = polzovatel.CodePolzovately; 
        

            //сохранение значений в таблицу Dolznost
            Dolznost dolznost = new Dolznost
            {
                Dolznosty = persona.Dolznost
            };
            polzovatel.KodeDolznosty = dolznost.KodeDolznosty; 
           
            userContext.Persona.Add(persona);
            userContext.Polzovatel.Add(polzovatel);
            userContext.Dolznost.Add(dolznost);
            userContext.SaveChanges();
            userContext.Dispose();
        }

        private void NovayRegistraciy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string LoginPolzovately1 = LoginText.Text;         //Создание переменных, в которые заносятся значения из TextBox/PasswordBox
                string Parol1 = ParolText.Password;
                string RetryParol1 = RetryParolText.Password;
                string Dolznost1 = DolznkstText.Text;
                string FIO1 = FIOText.Text;
                string DataRozdeniy1 = DenRozdeniyText.Text;
                string NomerTelephona1 = TelephonText.Text;
                string Email1 = EmailText.Text;
                string Pol1 = PolText.Text;

                if (LoginPolzovately1.Length > 3 && Parol1.Length > 8)   // Проверка логина и пароля на допустимое кол-во символов
                {

                    if (Parol1 == RetryParol1)   //Проверка на совпадение паролей
                    {
                        RegistrPerson(LoginPolzovately1, Parol1, Dolznost1, FIO1, DataRozdeniy1, NomerTelephona1, Email1, Pol1);

                        MessageBox.Show("Регистрация успешна", "Регистрация");

                        LoginText.Clear();
                        ParolText.Clear();
                        RetryParolText.Clear();
                        DolznkstText.Clear();
                        FIOText.Clear();
                        DenRozdeniyText.Clear();
                        TelephonText.Clear();
                        EmailText.Clear();
                        PolText.Clear();
                        PerehodNaAvtorizaciy();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
                        ParolText.Clear();
                        RetryParolText.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Логин должен быть больше трех символов.\nПароль должен быть больше восьми символов.", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Необходимо заполнить все поля","Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
              
            }
           

            
        }

        //Переход на окно авторизации

        private void Vozvrat_Click(object sender, RoutedEventArgs e)
        {
            PerehodNaAvtorizaciy();
        }


    }
}
