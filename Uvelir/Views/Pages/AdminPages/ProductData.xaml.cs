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

        private void cmbProductCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category((cmbProductCategory.SelectedItem as ComboBoxItem).Content.ToString(), cmbProductCategory.Text);
        }
        private void Category(string type = "", string search = "")
        {
            var materials = Data.db.Product.ToList();
            if (!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(type))
            {
                if (type == "Серьги")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Серьги").ToList();
                }
                if (type == "Подвеска")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Подвеска").ToList();
                }
                if (type == "Ожерелье")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Ожерелье").ToList();
                }
                if (type == "Браслет")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Браслет").ToList();
                }
                if (type == "Брошь")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Брошь").ToList();
                }
                if (type == "Кольцо")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Кольцо").ToList();
                }
                if (type == "Колье")
                {
                    materials = materials.Where(item => item.CategoryProduct.Title == "Колье").ToList();
                }              
                if (type == "Все")
                {
                    materials = materials.ToList();
                }
            }
            ProductDataListView.ItemsSource = materials;
        }
    }
}
