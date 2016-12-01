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

namespace BuildACalculator
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
        
        

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            var TopInput = float.Parse(this.TopInput.Text);
            var BottomInput = float.Parse(this.BottomInput.Text);
            var answer = TopInput + BottomInput;
            this.answer.Content = answer;

        }

        private void Subtrack_Click(object sender, RoutedEventArgs e)
        {
            var TopInput = float.Parse(this.TopInput.Text);
            var BottomInput = float.Parse(this.BottomInput.Text);
            var answer = TopInput - BottomInput;
            this.answer.Content = answer;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            var TopInput = float.Parse(this.TopInput.Text);
            var BottomInput = float.Parse(this.BottomInput.Text);
            var answer = TopInput * BottomInput;
            this.answer.Content = answer;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            var TopInput = float.Parse(this.TopInput.Text);
            var BottomInput = float.Parse(this.BottomInput.Text);
            var answer = TopInput / BottomInput;
            this.answer.Content = answer;
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {
            var TopInput = float.Parse(this.TopInput.Text);
            var BottomInput = float.Parse(this.BottomInput.Text);
            var answer = TopInput % BottomInput;
            this.answer.Content = answer;
        }
    }
}
