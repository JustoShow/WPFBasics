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

namespace WPFBasics
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

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtDescription.Text);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            this.txtDescription.Text = 
                this.txtLength.Text =
                this.txtSupplierName.Text =
                this.txtSupplierCode.Text =
                this.txtNote.Text =
                String.Empty;

            this.chkAssembly.IsChecked =
                this.chkDrill.IsChecked =
                this.chkFold.IsChecked =
                this.chkLaser.IsChecked =
                this.chkLathe.IsChecked = 
                this.chkPlasma.IsChecked =
                this.chkPurchase.IsChecked = 
                this.chkRoll.IsChecked =
                this.chkSaw.IsChecked = 
                this.chkWeld.IsChecked =
                false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.txtLength.Text += $" {((CheckBox)sender).Content}";
        }
    }
}
