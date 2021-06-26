using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stigal.AppCode
{
    public class FileGenerator
    {
        public string GenerateFile(List<AppPoint> lst)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var point in lst)
            {
                sb.AppendLine($"G1 X{point.X} Y{point.Y} Z1");
            }
            sb.AppendLine($"G1 X{lst[0].X} Y{lst[0].Y} Z1");
            sb.AppendLine($"G1 X0 Y0 Z0");

            return sb.ToString();
        }

        public void SaveFile(string filePath, string fileContent)
        {
            File.WriteAllText(filePath, fileContent);
        }
    }
}
