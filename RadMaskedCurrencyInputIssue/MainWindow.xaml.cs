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
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls.ScheduleView;
using System.ComponentModel;

namespace Themes_Issues_Checking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public MainWindow()
        {            
            InitializeComponent();          
            this.DataContext = this;
        }

        private void Numeric_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private decimal _qty = 120;
        public decimal Qty
        {
            get { return _qty; }
            set 
            { 
                Qty = value;
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Numeric_Loaded(object sender, RoutedEventArgs e)
        {
             var textBox = sender as RadMaskedNumericInput;
             if (textBox != null)
             {
             }
        }

        private void TxtPhone1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var maskedInput = sender as RadMaskedCurrencyInput;
            if ((e.Key == Key.Delete || e.Key == Key.Back) && maskedInput.Text.Length == maskedInput.SelectionLength)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    this.maskedInput.SelectionStart = 0;
                }));
            }
        }
      

        //private void RadMaskedCurrencyInput_ValueChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
        //{
        //    if (this.maskedInput.Value == 0)
        //    {
        //        Dispatcher.BeginInvoke(new Action(() =>
        //        {
        //            this.maskedInput.SelectionStart = 0;
        //        }));
        //    }
        //}        
    }
}
