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
        Double a = 0;
        Double b = 0;
        Double z = 0;
        double x = 0;
        Double c = 0;
        double memory = 0;

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
            windows1.Width = 430;
            textbox1.Text = "0";
            textbox1.Focus();
            a = 0; 
            b = 0;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "1";
            }
            else
            {
                textbox1.Text = "1";
            }
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "2";
            }
            else
            {
                textbox1.Text = "2";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "3";
            }
            else
            {
                textbox1.Text = "3";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "4";
            }
            else
            {
                textbox1.Text = "4";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "5";
            }
            else
            {
                textbox1.Text = "5";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "6";
            }
            else
            {
                textbox1.Text = "6";
            }   
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "7";
            }
            else
            {
                textbox1.Text = "7";
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "8";
            }
            else
            {
                textbox1.Text = "8";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "9";
            }
            else
            {
                textbox1.Text = "9";
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
             memory = 0;
             textbox1.Text = "0";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = Convert.ToString(memory);
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(textbox1.Text);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            memory+=double.Parse(textbox1.Text);
           
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(textbox1.Text);
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
                if (textbox1.Text.Length != 0)
            {
                textbox1.Text = textbox1.Text.Substring(0, textbox1.Text.Length - 1);
            }
        }
        

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
            a = 0;
            b = 0;
            z = 0;
        }

     
        private void button18_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = Convert.ToString(Convert.ToInt32 (textbox1.Text) * (-1));                 
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
           a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            z = 20;
            textbox1.Text = "0";
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            z = 21;
            textbox1.Text = "0";
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            z = 22;
            textbox1.Text = "0";
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textbox1.Text);
            x = Convert.ToDouble(1.0 / Convert.ToDouble(a));
            textbox1.Text = Convert.ToString(x);
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            z = 24;
            textbox1.Text = "0";
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "0")
            {
                textbox1.Text += "0";
            }
            else
            {
                textbox1.Text = "0";
            }
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
             if (textbox1.Text != "0")
            {
                textbox1.Text += ",";
            }
            else
            {
                textbox1.Text = ",";
            }
        
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            z = 27;
            textbox1.Text = "0";
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(textbox1.Text);
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
                if (z == 21)
                {
                    textbox1.Text = Convert.ToString((a * b)/100);
                    z = 0;
                }
                
                if (z == 22)

                {
                    textbox1.Text = Convert.ToString(a * b);
                    z = 0;
                }
                if (z == 20)
                {
                    textbox1.Text = Convert.ToString(a / b);
                    z = 0;                             
                }
                if(z==35)
                {
                    a = Convert.ToDouble(textbox1.Text);
                    textbox1.Text = Convert.ToString(Math.Pow(a, a));
                }
              
            }
        }     
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("23");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (windows1.Width == 430)
            {
                windows1.Width = 600;
                button40.Content = "<";
            }
            else
            {
                   windows1.Width = 430;
                   button40.Content = ">";
            }
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Sin(a));
        }

        private void button30_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Cos(a));
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Tan(a));
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
           
        }
      
        private void button33_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Log10(a));
        }
  private void button34_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Pow(a, 2));
        }

  private void button35_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      z = 35;
      textbox1.Text = "0";
     
  }

  private void button36_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Pow(a, 3));
  }

  private void button37_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      z = 37;
      textbox1.Text = "0";
  }

  private void button38_Click(object sender, RoutedEventArgs e)
  {

  }

  private void button39_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Pow(10, a));
  }

  private void button41_Click(object sender, RoutedEventArgs e)
  {

  }

  private void button42_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Sinh(a));
  }

  private void button44_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Tanh(a));
  }

  private void button43_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Cosh(a));
  }

  private void button45_Click(object sender, RoutedEventArgs e)
  {
      textbox1.Text = Convert.ToString(3.141592653589793238462643);
  }

  private void button41_Click_1(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Log(a));
  }

  private void button46_Click(object sender, RoutedEventArgs e)
  {
    a = Convert.ToDouble(textbox1.Text);
            textbox1.Text = Convert.ToString(Math.Exp(a));
  }

  private void button47_Click(object sender, RoutedEventArgs e)
  {
      a = Convert.ToDouble(textbox1.Text);
      textbox1.Text = Convert.ToString(Math.Abs(a));
  }

  private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
  {

   }


  

 
       
    }
}
