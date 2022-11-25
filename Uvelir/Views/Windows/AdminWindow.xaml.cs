using System.Windows;
using Uvelir.Model;
using Uvelir.Views.Pages.AdminPages;

namespace Uvelir.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public User User;
        public AdminWindow(User user)
        {
            InitializeComponent();
            this.User = user;
            AdminFrame.Navigate(new MainPageAdmin());
            tblNameUser.Text = $"Пользователь: {user.FirstName} {user.LastName}";
        }
    }
}
