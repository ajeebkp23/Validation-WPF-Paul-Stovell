using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PaulStovell.Samples.WpfValidation
{
    /// <summary>
    /// Interaction logic for AdvancedWindow.xaml
    /// </summary>

    public partial class AdvancedWindow : Window
    {

        public AdvancedWindow()
        {
            InitializeComponent();
            AdvancedCustomer c = new AdvancedCustomer();
            c.Name = "Fred";
            c.Address = "1/3 Powell Street";
            this.DataContext = c;
        }

    }
}