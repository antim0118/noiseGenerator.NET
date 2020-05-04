using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace noiseGenerator
{
    public partial class EditColorsForm : Form
    {
        public List<Color> colors;
        public EditColorsForm(Color[] colors)
        {
            this.colors = colors.ToList();
            InitializeComponent();
        }

        private void EditColorsForm_Load(object sender, EventArgs e)
        {
            for (int c = 0; c < colors.Count; c++)
            {
                Color color = colors[c];
                Button b = CloneButton(button_color_sample);
                b.BackColor = color;
                b.ForeColor = colorIsBright(color) ? Color.FromArgb(66, 66, 66) : Color.FromArgb(222, 222, 222);
                b.FlatAppearance.MouseDownBackColor = Color.FromArgb(255 - color.R / 2, 255 - color.G / 2, 255 - color.B / 2);
                b.Click += ColorButton_Click;
                b.Text += (c + 1);
                b.Visible = true;
            }
        }

        Button lastpressed;
        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (lastpressed != null)
                lastpressed.Font = new Font(lastpressed.Font, FontStyle.Regular);
            lastpressed = (Button)sender;
            lastpressed.Font = new Font(lastpressed.Font, FontStyle.Bold);
        }

        bool colorIsBright(Color c) => (c.R + c.G + c.B) / 3 > 128;

        public static Button CloneButton(Button controlToClone)
        {
            PropertyInfo[] controlProperties = typeof(Button).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Button b = Activator.CreateInstance<Button>();
            foreach (PropertyInfo propInfo in controlProperties)
                if (propInfo.CanWrite && propInfo.Name != "WindowTarget")
                    propInfo.SetValue(b, propInfo.GetValue(controlToClone, null), null);
            return b;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (colors.Count >= 10) return;
            using (ColorDialog colorDialog = new ColorDialog())
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog.Color;
                    Button b = CloneButton(button_color_sample);
                    b.BackColor = color;
                    b.ForeColor = colorIsBright(color) ? Color.FromArgb(66, 66, 66) : Color.FromArgb(222, 222, 222);
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(255 - color.R / 2, 255 - color.G / 2, 255 - color.B / 2);
                    b.Click += ColorButton_Click;
                    b.Text += (colors.Count + 1);
                    b.Visible = true;
                    colors.Add(color);
                }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (lastpressed == null || colors.Count <= 1) return;
            colors.Remove(lastpressed.BackColor);
            lastpressed.Dispose();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (lastpressed == null) return;
            Color lastcolor = lastpressed.BackColor;
            using (ColorDialog colorDialog = new ColorDialog { Color = lastcolor })
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog.Color;
                    lastpressed.BackColor = color;
                    lastpressed.ForeColor = colorIsBright(color) ? Color.FromArgb(66, 66, 66) : Color.FromArgb(222, 222, 222);
                    colors[colors.IndexOf(lastcolor)] = color;
                }
        }
    }
}
