using System;
using System.Windows;

namespace L8HWT4Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int operand1, operand2;
            int.TryParse(TB1.Text, out operand1);
            int.TryParse(TB2.Text, out operand2);
            if (Mod.IsChecked == true)
            {
                TB3.Text = Convert.ToString( operand1 % operand2);
            }
            else if (Deg.IsChecked == true)
            {
                TB3.Text = Convert.ToString(Math.Pow(operand1,operand2));
            }
            else if (Con.IsChecked == true)
            {
                for (int i = operand2; i != 0; i /= 10)
                {
                    operand1 *= 10;
                    operand1 += operand2;
                }

                TB3.Text = Convert.ToString(Math.Pow(operand1, operand2));
            }
            else if (Div.IsChecked == true)
            {
                TB3.Text = Convert.ToString(operand1/operand2);
            }
        }
    }
}
