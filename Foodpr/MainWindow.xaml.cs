using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Foodpr
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int total = 0,count=0;

            if(ckburgur.IsChecked == true)
            {
                total += 120;
                count++;
            }

            if (ckpizza.IsChecked == true)
            {
                total += 250;
                count++;
            }

            if (ckpasta.IsChecked == true)
            {
                total += 110;
                count++;
            }

            if (ckfr.IsChecked == true)
            {
                total += 70;
                count++;        
            }

            if (ckcold_d.IsChecked == true)
            {
                total += 20;
                count++;
            }

            if (ckice.IsChecked == true)
            {
                total += 35;
                count++;
            }

            lbitem.Content = count.ToString();
            lbprice.Content = total.ToString();
            int tax;
            tax = total * 5 / 100;

            lbtex.Content = tax.ToString();

            lbtam.Content = (total + tax).ToString();


        }
    }
}