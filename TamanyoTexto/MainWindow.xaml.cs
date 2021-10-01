using System.Windows;
using System.Windows.Controls;

namespace TamanyoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TamañoTexto_Checked(object sender, RoutedEventArgs e)
        {
            PruebaTextblock.FontSize = double.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
