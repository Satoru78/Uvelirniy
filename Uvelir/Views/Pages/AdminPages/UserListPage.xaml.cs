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
using Uvelir.Model;
using Uvelir.Context;


namespace Uvelir.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для UserListPage.xaml
    /// </summary>
    public partial class UserListPage : Page
    {
        public User User;
        public Role Role;
        public List<LoginHistory> LoginHistories { get; set; }
        public LoginHistory LoginHistory { get; set; }
        public UserListPage(LoginHistory loginHistory)
        {
            InitializeComponent();
            this.LoginHistory = loginHistory;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoginHistories = Data.db.LoginHistory.ToList();
            LoginList.ItemsSource = LoginHistories;
        }
    }
}
