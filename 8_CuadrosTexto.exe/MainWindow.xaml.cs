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
            nombreTextBox.Tag = ayudaNombreTextBlock;
            apellidoTextBox.Tag = ayudaApellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox campo = sender as TextBox;
            TextBlock tag = campo.Tag as TextBlock;
            if (e.Key == Key.F1)
            {
                //Invierte la visibilidad 0 = Visible, 1 = Hidden
                tag.Visibility = (Visibility)Math.Abs((int)tag.Visibility - 1);
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
