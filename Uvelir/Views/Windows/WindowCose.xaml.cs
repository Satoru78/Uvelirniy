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
using System.Windows.Shapes;

namespace Uvelir.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowCose.xaml
    /// </summary>
    public partial class WindowCose : Window
    {
        public WindowCose()
        {
            InitializeComponent();
            txbWindowCode.Text = GenericPassword();
        }
        public string GenericPassword()
        {
            int num_letters = 8;

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdifghijklmnopqrstuvwxyz#$%^&@123456789!".ToCharArray();
            Random rand = new Random();
            string word = "";

            for (int j = 1; j <= num_letters; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                word += letters[letter_num];
            }    
            
            return word;
        }
    }
}
