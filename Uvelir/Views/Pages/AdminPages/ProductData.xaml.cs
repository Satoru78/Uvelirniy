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
using Uvelir.Context;
using Uvelir.Model;

namespace Uvelir.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProductData.xaml
    /// </summary>
    public partial class ProductData : Page
    {
        public CategoryProduct CategoryProduct { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public ProductData(Product product)
        {
            InitializeComponent();
            Product = product;
            this.DataContext = this;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void txbSearchProduct_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Products = Data.db.Product.ToList();
            ProductDataListView.ItemsSource = Products;
        }
    }
}
