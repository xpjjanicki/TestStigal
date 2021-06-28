using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Microsoft.Win32;
using Stigal.AppCode;

namespace Stigal
{
    public partial class MainWindow : Window
    {
        public List<AppPoint> lstPoints = new List<AppPoint>();

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

        public void ShowSaveFileDialog(List<AppPoint> lst)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FileGenerator fg = new FileGenerator();
                string fileContent = fg.GenerateFile(lst);

                fg.SaveFile(saveFileDialog.FileName, fileContent);
            }
        }

        private void BtnGenerateFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtWidth.Text.Trim().Length > 0 &&
                    txtHeight.Text.Trim().Length > 0 &&
                    txtX.Text.Trim().Length > 0 &&
                    txtY.Text.Trim().Length > 0)
                {
                    string sWidth = string.Empty;
                    string sHeight = string.Empty;
                    string sX = string.Empty;
                    string sY = string.Empty;

                    sWidth = txtWidth.Text;
                    sHeight = txtHeight.Text;
                    sX = txtX.Text;
                    sY = txtY.Text;

                    float fWidth = StringToFloat(sWidth);
                    float fHeight = StringToFloat(sHeight);
                    float fX = StringToFloat(sX);
                    float fY = StringToFloat(sY);

                    AppPoint startPoint = new AppPoint()
                    {
                        X = fX,
                        Y = fY
                    };

                    Move m = new Move();
                    lstPoints = m.GenerateShape(fWidth, fHeight, startPoint);

                    ShowSaveFileDialog(lstPoints);


                    MessageBox.Show("Poprawnie wygenerowano plik");
                }
                else
                {
                    MessageBox.Show("Wypełnij formularz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd:\n" + ex.ToString());
            }
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            if (lstPoints.Count > 0)
            {
                img.Children.Clear();

                PointCollection collection = new PointCollection();
                foreach (var point in lstPoints)
                {
                    collection.Add(new Point(point.X, point.Y));
                }
                collection.Add(new Point(lstPoints[0].X, lstPoints[0].Y));

                Polyline line = new Polyline()
                {
                    Points = collection,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };

                img.Children.Add(line);
            }
            else
            {
                MessageBox.Show("Najpierw wygeneruj plik.");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            img.Children.Clear();
            txtWidth.Clear();
            txtHeight.Clear();
            txtX.Clear();
            txtY.Clear();
            lstPoints.Clear();
        }
    }
}
