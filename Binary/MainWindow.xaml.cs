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

namespace Binary
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gen_btn_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            //try
            //{
                string s = "";
                for (long i = 0; i < long.Parse(TB_lenght.Text); i++)
                {
                    s += r.Next(0, 2);
                }
                lbl_result.Text = s;

            binary2decimal b2d = new binary2decimal(s);
            b2d.Show();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
