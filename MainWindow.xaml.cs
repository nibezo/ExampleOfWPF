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

namespace ExampleOfWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal a = Convert.ToDecimal(InputOne.Text);
                decimal b = Convert.ToDecimal(InputTwo.Text);
                decimal sum = a + b;

                Output.Text = Convert.ToString(sum);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
