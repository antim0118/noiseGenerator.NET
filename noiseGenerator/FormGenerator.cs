using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace noiseGenerator
{
    public partial class FormGenerator : Form
    {
        private bool formIsLoaded = false;
        private Color[] colors;
        public FormGenerator() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            //sum width/height of all screens
            int w = 0, h = 0;
            foreach (Screen s in Screen.AllScreens)
            {
                w += s.Bounds.Width;
                h += s.Bounds.Height;
            }

            //set width and height, and limit in settings
            numericUpDown_width.Maximum = w;
            numericUpDown_height.Maximum = h;
            numericUpDown_width.Value = w;
            numericUpDown_height.Value = h;

            numericUpDown_width.Value = 16;
            numericUpDown_height.Value = 9;

            //set color buttons
            colors = new Color[2] { Color.White, Color.Gray };

            //everythng is ready, lets generate
            formIsLoaded = true;
            GenerateNoise();
        }

        private void numericUpDown_width_ValueChanged(object sender, EventArgs e) => GenerateNoise();
        private void numericUpDown_height_ValueChanged(object sender, EventArgs e) => GenerateNoise();
        private void numericUpDown_seed_ValueChanged(object sender, EventArgs e) => GenerateNoise();

        private void button_colors_Click(object sender, EventArgs e)
        {
            EditColorsForm ecf = new EditColorsForm(colors);
            if (ecf.ShowDialog() == DialogResult.OK)
                colors = ecf.colors.ToArray();
            button_colors.Text = $"Set colors ({colors.Length})";
            GenerateNoise();
        }

        #region working with bitmaps (incl. button_save_click function)
        private void button_save_Click(object sender, EventArgs e)
        {
            if (temp_bmp == null)
            {
                MessageBox.Show("Error: temp_bmp is null!");
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Bitmap|*.bmp" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageCodecInfo codec = GetEncoder(ImageFormat.Bmp);
                    Encoder enc = Encoder.Quality;
                    EncoderParameters prs = new EncoderParameters(1);
                    EncoderParameter pr = new EncoderParameter(enc, 100L);
                    prs.Param[0] = pr;
                    temp_bmp.Save(sfd.FileName, codec, prs);
                }
            }
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }

        Bitmap temp_bmp;
        void GenerateNoise()
        {
            if (!formIsLoaded) return;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (temp_bmp != null)
                temp_bmp.Dispose();

            Random rand = new Random((int)numericUpDown_seed.Value);
            int w = (int)numericUpDown_width.Value, h = (int)numericUpDown_height.Value;

            Bitmap bmp = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    bmp.SetPixel(x, y, colors[rand.Next(colors.Length)]);
                }

            pictureBox_main.Image = bmp;
            temp_bmp = bmp;

            sw.Stop();
            label_generatedms.Text = $"Gen. in: {sw.ElapsedMilliseconds}ms";
            GC.Collect();
        }
        #endregion

        private void button_generate_seed_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            numericUpDown_seed.Value = rand.Next(int.MaxValue);
        }

        private void button_upscale_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Color c0 = colors[0], c1 = colors[1];
            int mult = 3;

            Bitmap tbmp = new Bitmap(pictureBox_main.Image);
            int w = tbmp.Width, h = tbmp.Height;
            Bitmap bmp = new Bitmap(w * mult, h * mult, PixelFormat.Format24bppRgb);
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    Color p = tbmp.GetPixel(x, y);
                    for (int ox = 0; ox <= mult-1; ox++)
                        for (int oy = 0; oy <= mult-1; oy++)
                        {
                            bmp.SetPixel((x * mult) + ox, (y * mult) + oy, p);
                        }
                }

            tbmp = new Bitmap(bmp);
            w *= mult;
            h *= mult;
            bmp = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    Color p = tbmp.GetPixel(x, y);
                    bool isSecondaryColor = false;
                    for (int col = 1; col < colors.Length; col++)
                        if (p.ToArgb() == colors[col].ToArgb())
                            isSecondaryColor = true;

                    if (isSecondaryColor && (x - 1 >= 0 && y - 1 >= 0 && x + 1 < tbmp.Width && y + 1 < tbmp.Height) &&
                       (tbmp.LeftUpperCornerNotEqualsColor(x, y, p) || tbmp.LeftBottomCornerNotEqualsColor(x, y, p) ||
                       tbmp.RightUpperCornerNotEqualsColor(x, y, p) || tbmp.RightBottomCornerNotEqualsColor(x, y, p)))
                        bmp.SetPixel(x, y, c0);
                    else
                        //bmp.SetPixel(x, y, Color.Red);
                        bmp.SetPixel(x, y, p);
                }

            if (temp_bmp != null)
                temp_bmp.Dispose();
            if (tbmp != null)
                tbmp.Dispose();

            pictureBox_main.Image = bmp;
            temp_bmp = bmp;

            sw.Stop();
            label_2x_debuginfo.Text = $"-New resoulution: {pictureBox_main.Image.Width}x{pictureBox_main.Image.Height}\n-Elapsed: {sw.Elapsed.TotalMilliseconds.ToString("0.00")}ms";
        }
    }
}
