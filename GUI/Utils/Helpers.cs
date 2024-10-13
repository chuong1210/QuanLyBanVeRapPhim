using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utils
{
    public class Helpers
    {
        
        public static GraphicsPath GetRoundedRectangle(int width, int height, int radius = 20)
        {
            GraphicsPath path = new GraphicsPath();

            // Validate radius to prevent issues with negative or overly large values
            radius = Math.Max(1, Math.Min(radius, Math.Min(width / 2, height / 2)));

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddLine(radius, 0, width - radius, 0);
            path.AddArc(width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddLine(width, radius, width, height - radius);
            path.AddArc(width - radius * 2, height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(width - radius, height, radius, height);
            path.AddArc(0, height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            return path;
        }


        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}
