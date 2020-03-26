using System.Windows.Forms;

namespace noiseGenerator
{
    public partial class PictureBoxCustom : PictureBox
    {
        public PictureBoxCustom() => InitializeComponent();
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            base.OnPaint(e);
        }
    }
}
