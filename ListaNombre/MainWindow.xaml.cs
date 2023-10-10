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

namespace ListaNombre
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AgregarTexto();
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            //Filtrar por tecla pulsada, cuanda el codigo sea el del ENTER
            if(e.Key == Key.Enter)
            {
                AgregarTexto();
            }
        }
        private void AgregarTexto()
        {
            if(!txtName.Text.Equals(""))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("error", "Hueco vacio",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
