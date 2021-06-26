using System.IO;
using System.Text;

namespace Stigal.AppCode
{
    public class FileGenerator
    {
        public static string PathFile { get; set; }


        public string GenerateFile(AppRectangle r)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"G1 X{r.P1.X} Y{r.P1.Y} Z1");
            sb.AppendLine($"G1 X{r.P2.X} Y{r.P2.Y} Z1");
            sb.AppendLine($"G1 X{r.P3.X} Y{r.P3.Y} Z1");
            sb.AppendLine($"G1 X{r.P4.X} Y{r.P4.Y} Z1");
            sb.AppendLine($"G1 X{r.P1.X} Y{r.P1.Y} Z1");
            sb.AppendLine($"G1 X0 Y0 Z0");

            return sb.ToString();
        }

        public void SaveFile(string filePath, string fileContent)
        {
            File.WriteAllText(filePath, fileContent);
        }
    }
}
