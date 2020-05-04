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
    }
}
