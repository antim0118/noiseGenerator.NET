namespace noiseGenerator
{
    partial class FormGenerator
    {
        private System.ComponentModel.IContainer components = null;
		
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.panel_settings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_generatedms = new System.Windows.Forms.Label();
            this.panel_pic = new System.Windows.Forms.Panel();
            this.numericUpDown_seed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_c1 = new System.Windows.Forms.Button();
            this.button_c2 = new System.Windows.Forms.Button();
            this.pictureBox_main = new noiseGenerator.PictureBoxCustom();
            this.button_save = new System.Windows.Forms.Button();
            this.button_generate_seed = new System.Windows.Forms.Button();
            this.panel_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.panel_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_settings
            // 
            this.panel_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_settings.Controls.Add(this.button_generate_seed);
            this.panel_settings.Controls.Add(this.button_save);
            this.panel_settings.Controls.Add(this.button_c2);
            this.panel_settings.Controls.Add(this.button_c1);
            this.panel_settings.Controls.Add(this.numericUpDown_seed);
            this.panel_settings.Controls.Add(this.label3);
            this.panel_settings.Controls.Add(this.label2);
            this.panel_settings.Controls.Add(this.numericUpDown_height);
            this.panel_settings.Controls.Add(this.numericUpDown_width);
            this.panel_settings.Controls.Add(this.label1);
            this.panel_settings.Controls.Add(this.label_generatedms);
            this.panel_settings.Location = new System.Drawing.Point(6, 6);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(150, 449);
            this.panel_settings.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numericUpDown_height.Location = new System.Drawing.Point(85, 22);
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(55, 16);
            this.numericUpDown_height.TabIndex = 3;
            this.numericUpDown_height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numericUpDown_width.Location = new System.Drawing.Point(8, 22);
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(55, 16);
            this.numericUpDown_width.TabIndex = 2;
            this.numericUpDown_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_width.ValueChanged += new System.EventHandler(this.numericUpDown_width_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size (WxH):";
            // 
            // label_generatedms
            // 
            this.label_generatedms.Location = new System.Drawing.Point(5, 425);
            this.label_generatedms.Name = "label_generatedms";
            this.label_generatedms.Size = new System.Drawing.Size(140, 17);
            this.label_generatedms.TabIndex = 0;
            this.label_generatedms.Text = "Gen. in: 0ms";
            this.label_generatedms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_pic
            // 
            this.panel_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pic.Controls.Add(this.pictureBox_main);
            this.panel_pic.Location = new System.Drawing.Point(162, 6);
            this.panel_pic.Name = "panel_pic";
            this.panel_pic.Size = new System.Drawing.Size(632, 449);
            this.panel_pic.TabIndex = 1;
            // 
            // numericUpDown_seed
            // 
            this.numericUpDown_seed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_seed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_seed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numericUpDown_seed.Location = new System.Drawing.Point(8, 67);
            this.numericUpDown_seed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_seed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_seed.Name = "numericUpDown_seed";
            this.numericUpDown_seed.Size = new System.Drawing.Size(108, 16);
            this.numericUpDown_seed.TabIndex = 6;
            this.numericUpDown_seed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_seed.ValueChanged += new System.EventHandler(this.numericUpDown_seed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seed:";
            // 
            // button_c1
            // 
            this.button_c1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c1.Location = new System.Drawing.Point(8, 99);
            this.button_c1.Name = "button_c1";
            this.button_c1.Size = new System.Drawing.Size(132, 23);
            this.button_c1.TabIndex = 7;
            this.button_c1.Text = "Color #1";
            this.button_c1.UseVisualStyleBackColor = true;
            this.button_c1.Click += new System.EventHandler(this.button_c1_Click);
            // 
            // button_c2
            // 
            this.button_c2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_c2.Location = new System.Drawing.Point(8, 121);
            this.button_c2.Name = "button_c2";
            this.button_c2.Size = new System.Drawing.Size(132, 23);
            this.button_c2.TabIndex = 8;
            this.button_c2.Text = "Color #2";
            this.button_c2.UseVisualStyleBackColor = true;
            this.button_c2.Click += new System.EventHandler(this.button_c2_Click);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_main.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(630, 447);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_main.TabIndex = 0;
            this.pictureBox_main.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(8, 401);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(132, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_generate_seed
            // 
            this.button_generate_seed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate_seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate_seed.Location = new System.Drawing.Point(122, 66);
            this.button_generate_seed.Name = "button_generate_seed";
            this.button_generate_seed.Size = new System.Drawing.Size(18, 18);
            this.button_generate_seed.TabIndex = 10;
            this.button_generate_seed.Text = "G";
            this.button_generate_seed.UseVisualStyleBackColor = true;
            this.button_generate_seed.Click += new System.EventHandler(this.button_generate_seed_Click);
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.panel_pic);
            this.Controls.Add(this.panel_settings);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGenerator";
            this.Text = "Noise Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.panel_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Panel panel_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_generatedms;
        private System.Windows.Forms.NumericUpDown numericUpDown_seed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_c2;
        private System.Windows.Forms.Button button_c1;
        private PictureBoxCustom pictureBox_main;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_generate_seed;
    }
}

