using System.Windows;


namespace TamanyoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TamañoTexto_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (sender == ButtonPequeño)
            {
                PruebaTextblock.FontSize = 36;
            }
            if (sender == ButtonMediano)
            {
                PruebaTextblock.FontSize = 48;
            }
            if(sender == ButtonGrande)
            {
                PruebaTextblock.FontSize = 72;
            }
        }
    }
}
