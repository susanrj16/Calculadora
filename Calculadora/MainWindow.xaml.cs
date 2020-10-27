using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculadora
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

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            char x = (operadorTextBox.Text)[0];
            try
            {
                int a = Int32.Parse(operador1TextBox.Text);
                int b = Int32.Parse(operador2TextBox.Text);
                int res = 0;

                switch (x)
                {
                    case '*':
                        res = a * b;
                        resultadoTextBox.Text = res.ToString();
                        break;
                    case '/':
                        res = a / b;
                        resultadoTextBox.Text = res.ToString();
                        break;
                    case '+':
                        res = a + b;
                        resultadoTextBox.Text = res.ToString();
                        break;
                    case '-':
                        res = a - b;
                        resultadoTextBox.Text = res.ToString();
                        break;
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos");
            }

        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((operadorTextBox.Text).Equals("*") || (operadorTextBox.Text).Equals("/") || (operadorTextBox.Text).Equals("+") || (operadorTextBox.Text).Equals("-"))
            {
                calcularButton.IsEnabled = true;
            }
            else
            {
                calcularButton.IsEnabled = false;
            }
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operador1TextBox.Text = "";
            operador2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }
    }
}
