using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _8_CuadrosTexto.exe
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                //Invierte la visibilidad 0 = Visible, 1 = Hidden
                ayudaNombreTextBlock.Visibility = (Visibility)Math.Abs((int)ayudaNombreTextBlock.Visibility - 1);
            }
        }

        private void apellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                //Invierte la visibilidad 0 = Visible, 1 = Hidden
                ayudaApellidoTextBlock.Visibility = (Visibility)Math.Abs((int)ayudaApellidoTextBlock.Visibility - 1);
            }
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                bool esEntero = int.TryParse((sender as TextBox).Text, out int valor);
                ayudaEdadTextBlock.Visibility = esEntero ? Visibility.Hidden : Visibility.Visible;
            }
        }
    }
}
