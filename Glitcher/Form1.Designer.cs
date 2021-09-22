
namespace Glitcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Glitch_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.AlphaTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 451);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.AlphaTrackBar);
            this.panel3.Controls.Add(this.Save_Button);
            this.panel3.Controls.Add(this.Load_Button);
            this.panel3.Controls.Add(this.Glitch_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(648, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 451);
            this.panel3.TabIndex = 0;
            // 
            // Load_Button
            // 
            this.Load_Button.AutoSize = true;
            this.Load_Button.BackColor = System.Drawing.Color.White;
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.ForeColor = System.Drawing.Color.Black;
            this.Load_Button.Location = new System.Drawing.Point(5, 92);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(146, 74);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Glitch_Button
            // 
            this.Glitch_Button.AutoSize = true;
            this.Glitch_Button.BackColor = System.Drawing.Color.White;
            this.Glitch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Glitch_Button.Font = new System.Drawing.Font("Montserrat ExtraLight", 8.249999F);
            this.Glitch_Button.ForeColor = System.Drawing.Color.Black;
            this.Glitch_Button.Location = new System.Drawing.Point(5, 12);
            this.Glitch_Button.Name = "Glitch_Button";
            this.Glitch_Button.Size = new System.Drawing.Size(146, 74);
            this.Glitch_Button.TabIndex = 0;
            this.Glitch_Button.Text = "Glitch";
            this.Glitch_Button.UseVisualStyleBackColor = false;
            this.Glitch_Button.Click += new System.EventHandler(this.Glitch_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.AutoSize = true;
            this.Save_Button.BackColor = System.Drawing.Color.White;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Montserrat ExtraLight", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Button.ForeColor = System.Drawing.Color.Black;
            this.Save_Button.Location = new System.Drawing.Point(5, 172);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(146, 74);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Maroon;
            this.Picture.Image = global::Glitcher.Properties.Resources.Screenshot_3;
            this.Picture.InitialImage = global::Glitcher.Properties.Resources.Screenshot_3;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(451, 451);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // AlphaTrackBar
            // 
            this.AlphaTrackBar.LargeChange = 1;
            this.AlphaTrackBar.Location = new System.Drawing.Point(5, 394);
            this.AlphaTrackBar.Maximum = 255;
            this.AlphaTrackBar.Minimum = 20;
            this.AlphaTrackBar.Name = "AlphaTrackBar";
            this.AlphaTrackBar.Size = new System.Drawing.Size(146, 45);
            this.AlphaTrackBar.TabIndex = 2;
            this.AlphaTrackBar.Value = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alpha : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "Form1";
            this.Text = "Glitcher";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Glitch_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar AlphaTrackBar;
    }
}

