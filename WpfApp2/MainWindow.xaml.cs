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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            ResultadoTextBox.Text = "0";
            ResultadoTextBox.IsEnabled = false;

        }

        //Evento del botón que limpia y deja los TextBox a '0'
        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            ResultadoTextBox.Text = "0";

        }
        
        //Evento que controla los cambions en los TextBox de los dos operandos
        private void Operandos_TextChanged(object sender, TextChangedEventArgs e)
        {
            OperacionesOperandos();
        }

        //Evento que controla si los radio buttons están checkeados
        private void RadioButtons_Checked(object sender, RoutedEventArgs e)
        {
            OperacionesOperandos();
        }

        //Método general para realizar las operaciones necesarias.
        private void OperacionesOperandos()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
            {
                if ((bool)SumaRadioButton.IsChecked)
                {
                    ResultadoTextBox.Text = (int.Parse(Operando1TextBox.Text) + int.Parse(Operando2TextBox.Text)).ToString();
                }
                else if ((bool)RestaRadioButton.IsChecked)
                {
                    ResultadoTextBox.Text = (int.Parse(Operando1TextBox.Text) - int.Parse(Operando2TextBox.Text)).ToString();
                }
                else if ((bool)MultiplicacionRadioButton.IsChecked)
                {
                    ResultadoTextBox.Text = (int.Parse(Operando1TextBox.Text) * int.Parse(Operando2TextBox.Text)).ToString();
                }
                else if ((bool)DivisionRadioButton.IsChecked)
                {
                    if (int.Parse(Operando2TextBox.Text) == 0)
                        ResultadoTextBox.Text = "ERROR!";
                    else
                        ResultadoTextBox.Text = (int.Parse(Operando1TextBox.Text) / int.Parse(Operando2TextBox.Text)).ToString();
                }
            }

        }
    }
}
