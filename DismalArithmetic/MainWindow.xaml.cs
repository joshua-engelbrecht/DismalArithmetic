using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace DismalArithmetic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string OperationImage { get; set; } 
        public MainWindow()
        {
            InitializeComponent();

            OperationImage = "/DismalArithmetic;compoent/Images/plus.png";
        }

        private void PreviewTextInputValidate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void ChangeOperation(object sender, MouseButtonEventArgs e)
        {
            OperationImage =  OperationImage.Contains("plus.png") ? "/DismalArithmetic;compoent/Images/multiply.png" : "/DismalArithmetic;compoent/Images/plus.png";
        }
    }
}
