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

namespace first_task
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



        private void ManualCount(object sender, RoutedEventArgs e)
        {
            try
            {
                Error.Text = "";
                ClearAll();
                char[] delimiterChars = { ' ', ',' };
                string[] arr_text = ManualArray.Text.Split(delimiterChars);
                List<int> arr_int = new List<int>();


                foreach (string i in arr_text)
                {
                    arr_int.Add(short.Parse(i));
                }
                foreach (int i in arr_int)
                {
                if (i % 2 == 0)
                {
                        Couple.Text += $"{i} ";
                    }
                    else
                    {
                    NotCouple.Text += $"{i} ";
                    }
                }
                TheBiggest.Text = arr_int.Max().ToString();
                TheLowest.Text = arr_int.Min().ToString();
                TheMiddle.Text = arr_int.Average().ToString();
                Summ.Text = arr_int.Sum().ToString();

            }
            catch (FormatException)
            {
                Error.Text = "Введите корректный формат строки.\nТолько целые числа через запятую или пробел";
            }
        }
        private void AutoCount(object sender, RoutedEventArgs e) 
        {
            try {
            Error.Text = "";
            ClearAll();
                List<int> arr_int = new List<int>();
                Random rnd = new Random();
                int number = short.Parse(AutoArray.Text);

                for (int i = 0; i < number; i++)
                {
                arr_int.Add(rnd.Next(-100, 100));
            }

                foreach (int i in arr_int)
            {
                if (i % 2 == 0)
                {
                    Couple.Text += $"{i} ";
                }
                else
                {
                    NotCouple.Text += $"{i} ";
                }
            }
            TheBiggest.Text = arr_int.Max().ToString();
            TheLowest.Text = arr_int.Min().ToString();
            TheMiddle.Text = arr_int.Average().ToString();
            Summ.Text = arr_int.Sum().ToString();
            }
            catch (FormatException)
            {
                Error.Text = "Введите корректный формат строки.\nТолько целые числа через запятую или пробел";
            }
        }

        public void ClearAll()
        {
            TheBiggest.Text = "";
            TheLowest.Text = "";
            TheMiddle.Text = "";
            Couple.Text = "";
            NotCouple.Text = "";
            Summ.Text = "";

        }
        private void AutoArray_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AutoArray.Text = "";
        }

        private void ManualArray_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ManualArray.Text = "";
        }
    }
}
