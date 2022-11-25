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
using System.Windows.Threading;
using Uvelir.Context;
using Uvelir.Model;
using Uvelir.Views.Windows;

namespace Uvelir
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Avtorization : Window
    {
        public LoginHistory LoginHistory { get; set; }
        DispatcherTimer timer = new DispatcherTimer();
        public DateTime TimeBlock { get; set; }
        public Avtorization()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now <= TimeBlock)
            {
                LoginBtn.IsEnabled = false;
            }
            else
            {
                LoginBtn.IsEnabled = true;
                timer.Stop();
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = Data.db.User.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Text);
                if (currentUser != null && tblCaptcha.Text == tblCaptcha.Text)
                {
                    AdminWindow adminWindow = new AdminWindow(currentUser);
                    adminWindow.ShowDialog();
                    //var loginTime = Data.db.LoginHistory.FirstOrDefault(item => item.LoginTime == DateTime.Now);
                    //if (loginTime)
                    //{
                        
                    //   Data.db.LoginHistory.Add(loginTime);

                        
                    //    Data.db.SaveChanges();

                    //}
                }
                else
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                    CaptchaPanel.Visibility = Visibility.Visible;
                    tblCaptcha.Text = GenericCaptcha();
                    timer.Start();
                    TimeBlock = DateTime.Now.AddSeconds(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ошибка");
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public string GenericCaptcha()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdifghijklmnopqrstuvwxyz#$%^&@123456789!".ToCharArray();
            Random rand = new Random();
            string word = "";

            for (int j = 1; j <= 4; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }

            return word;
        }

        private void btnCaptcha_Click(object sender, RoutedEventArgs e)
        {
            tblCaptcha.Text = GenericCaptcha();
        }
    }
}
