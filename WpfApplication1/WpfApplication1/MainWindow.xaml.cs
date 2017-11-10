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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        int b = 0;
        int z = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
            textbox1.Focus();
            a = 0; 
            b = 0;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {

        }

     
        private void button18_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            z = 20;
            textbox1.Text = "0";
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            z = 22;
            textbox1.Text = "0";
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            z = 24;
            textbox1.Text = "0";
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            z = 27;
            textbox1.Text = "0";
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToInt32(textbox1.Text);
            if (z != 0)
            {
                if (z == 27)
                {
                    textbox1.Text = Convert.ToString(a + b);
                    z = 0;
                }
                if (z == 24)
                {
                    textbox1.Text = Convert.ToString(a - b);
                    z = 0;
                }
                if(z==22)
                {
                    textbox1.Text = Convert.ToString(a * b);
                    z = 0;
                }
                if (z == 20)
                {
                    textbox1.Text = Convert.ToString(a / b);
                    z = 0;
                }
            }
        }

      


    }
}
