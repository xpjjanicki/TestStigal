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

namespace Stigal
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

        public float StringToFloat(string s)
        {
            float f = 0f;
            float.TryParse(s, out f);
            return f;
        }

        private void BtnGenerateFile_Click(object sender, RoutedEventArgs e)
        {
            string sWidth = string.Empty;
            string sHeight = string.Empty;
            string sX = string.Empty;
            string sY = string.Empty;

            try
            {
                sWidth = txtWidth.Text;
                sHeight = txtHeight.Text;
                sX = txtX.Text;
                sY = txtY.Text;

                float fWidth = StringToFloat(sWidth);
                float fHeight = StringToFloat(sHeight);
                float fX = StringToFloat(sX);
                float fY = StringToFloat(sY);



                MessageBox.Show("Poprawnie wygenerowano plik");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd:\n" + ex.ToString());
            }

            
        }
    }
}
