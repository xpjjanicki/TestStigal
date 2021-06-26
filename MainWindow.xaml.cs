using System;
using System.Windows;
using System.Windows.Shapes;
using Microsoft.Win32;
using Stigal.AppCode;

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

        public void ShowSaveFileDialog(AppRectangle r)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FileGenerator fg = new FileGenerator();
                string fileContent = fg.GenerateFile(r);

                fg.SaveFile(saveFileDialog.FileName, fileContent);
            }
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

                AppPoint startPoint = new AppPoint() {
                    X = fX,
                    Y = fY
                };

                Move m = new Move();
                AppRectangle r = new AppRectangle();
                r = m.GenerateRectangle(fWidth, fHeight, startPoint);

                ShowSaveFileDialog(r);


                MessageBox.Show("Poprawnie wygenerowano plik");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd:\n" + ex.ToString());
            }

            
        }
    }
}
