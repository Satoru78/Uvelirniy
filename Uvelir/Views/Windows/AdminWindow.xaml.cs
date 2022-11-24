using System.Windows;
using Uvelir.Views.Pages.AdminPages;

namespace Uvelir.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            AdminFrame.Navigate(new MainPageAdmin());
        }
    }
}
