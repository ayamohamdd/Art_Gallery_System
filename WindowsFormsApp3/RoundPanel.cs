using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WindowsFormsApp3;
namespace WindowsFormsApp3
{
    internal class RoundPanel : Panel
    {
        public int Radius { get; set; } = 10; // Adjust the radius as needed

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color color1 = Color.LightGray;
            Color color2 = Color.White;
            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(ClientRectangle.X, ClientRectangle.Y, Radius, Radius, 180, 90); // Top-left corner
            path.AddArc(ClientRectangle.Right - Radius, ClientRectangle.Y, Radius, Radius, 270, 90); // Top-right corner
            path.AddArc(ClientRectangle.Right - Radius, ClientRectangle.Bottom - Radius, Radius, Radius, 0, 90); // Bottom-right corner
            path.AddArc(ClientRectangle.X, ClientRectangle.Bottom - Radius, Radius, Radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

           
            // Fill the panel with gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, color1, color2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw the rounded rectangle border
            using (Pen pen = new Pen(Color.Navy, 2)) // Border color and width
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // Optionally, you can add properties for border color and width
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 1;
    
}
}