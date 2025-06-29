using CrudOwn.ModelWidoku;
using CrudOwn.Services;
using Kolory_WPF.ModelWidoku;

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

namespace CrudOwn.Widok
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ShowInTaskbar = true; // domyślnie true, ale warto jawnie ustawić
            this.WindowState = WindowState.Minimized; // zminimalizowane
            this.Loaded += MainWindow_Loaded;


        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            Jump.UstawJumpList();
            string aa = GetExplorer.GetActiveFolder();
            MessageBox.Show(aa, "Aktywny folder", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        
    }
}
