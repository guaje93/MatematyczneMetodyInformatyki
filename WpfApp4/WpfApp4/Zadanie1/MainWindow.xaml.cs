using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Konstruktor inicializujący okno (to co jest napisane w XAML)
        public MainWindow()
        {
            InitializeComponent();
        }


        //Metoda podpięta pod przycisk
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComplexNumbers z1 = null, z2 = null;

            try
            {
                z1 = new ComplexNumbers(Double.Parse(txtBoxZ1a.Text.Replace(",", ".")), Double.Parse(txtBoxZ1b.Text.Replace(",", ".")));
                z2 = new ComplexNumbers(Double.Parse(txtBoxZ2a.Text), Double.Parse(txtBoxZ2b.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect syntax", "error", MessageBoxButton.OK, MessageBoxImage.Warning);
                ClearTxtBoxes();
                return;
            }
            
            ////Adding
            ComplexNumbers Z1PlusZ2 = ComplexNumbersCalculator.AddingCalculator(z1, z2);
            ShowComplexNumbers(Z1PlusZ2, AddingTxtBoxArithmetic, AddingTxtBoxTrighonometric, AddingTxtBoxExponential);

            ////Substracting
            ComplexNumbers Z1MinusZ2 = ComplexNumbersCalculator.SubstractingCalculator(z1, z2);
            ShowComplexNumbers(Z1MinusZ2, SubstringTxtBoxArithmetic, SubstringTxtTrighonometric, SubstringTxtBoxExponential);

            ////Multiplaying
            ComplexNumbers Z1MultiplyZ2 = ComplexNumbersCalculator.MultiplyingCalculator(z1, z2);
            ShowComplexNumbers(Z1MultiplyZ2, MultiplyingTxtBoxArithmetic, MultiplyingTxtBoxTrighonometric, MultiplyingTxtBoxExponential);

            ////Dividing
            ComplexNumbers Z1DivideZ2 = ComplexNumbersCalculator.DividingCalculator(z1, z2);
            ShowComplexNumbers(Z1DivideZ2, DividingTxtBoxArithmetic, DividingTxtBoxTrighonometric, DividingTxtBoxExponential);
        }

        //Metoda ustawiająca text w TextBoxach
        public void ShowComplexNumbers(ComplexNumbers complex, TextBox txtBox1, TextBox txtBox2, TextBox txtBox3)
        {
            txtBox1.Text = complex.ToArithmethicExpression();
            txtBox2.Text = complex.ToTrighonometricExpression();
            txtBox3.Text = complex.ToExponentialExpression();
        }

        //Metoda czyszcząca pola textboxów
        public void ClearTxtBoxes()
        {
            AddingTxtBoxArithmetic.Text = AddingTxtBoxExponential.Text = AddingTxtBoxTrighonometric.Text = "";
            SubstringTxtBoxArithmetic.Text = SubstringTxtBoxExponential.Text = SubstringTxtTrighonometric.Text = "";
            MultiplyingTxtBoxArithmetic.Text = MultiplyingTxtBoxExponential.Text = MultiplyingTxtBoxTrighonometric.Text = "";
            DividingTxtBoxArithmetic.Text = DividingTxtBoxExponential.Text = DividingTxtBoxTrighonometric.Text = "";
        }

        //Handler przesuwania okna 
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        //Wyłączanie apki
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
