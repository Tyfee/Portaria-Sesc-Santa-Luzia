namespace Portaria
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.colorWithAlpha3 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha4 = new System.Windows.Forms.ColorWithAlpha();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alphaGradientPanel2 = new System.Windows.Forms.AlphaGradientPanel();
            this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.alphaGradientPanel1.SuspendLayout();
            this.alphaGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(593, 252);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(253, 161);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Purple;
            this.alphaGradientPanel1.Border = true;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha3);
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha4);
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.Controls.Add(this.label3);
            this.alphaGradientPanel1.Controls.Add(this.label1);
            this.alphaGradientPanel1.CornerRadius = 20;
            this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel1.Gradient = true;
            this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel1.GradientOffset = 1F;
            this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel1.Grayscale = false;
            this.alphaGradientPanel1.Image = null;
            this.alphaGradientPanel1.ImageAlpha = 75;
            this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
            this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel1.Location = new System.Drawing.Point(171, 12);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = true;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(200, 161);
            this.alphaGradientPanel1.TabIndex = 3;
            this.alphaGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.alphaGradientPanel1_Paint);
            // 
            // colorWithAlpha3
            // 
            this.colorWithAlpha3.Alpha = 255;
            this.colorWithAlpha3.Color = System.Drawing.Color.Blue;
            this.colorWithAlpha3.Parent = this.alphaGradientPanel1;
            // 
            // colorWithAlpha4
            // 
            this.colorWithAlpha4.Alpha = 255;
            this.colorWithAlpha4.Color = System.Drawing.Color.DarkBlue;
            this.colorWithAlpha4.Parent = this.alphaGradientPanel1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entradas (Hoje)";
            // 
            // alphaGradientPanel2
            // 
            this.alphaGradientPanel2.BackColor = System.Drawing.Color.Green;
            this.alphaGradientPanel2.Border = true;
            this.alphaGradientPanel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha1);
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha2);
            this.alphaGradientPanel2.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel2.Controls.Add(this.label4);
            this.alphaGradientPanel2.Controls.Add(this.label2);
            this.alphaGradientPanel2.CornerRadius = 20;
            this.alphaGradientPanel2.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel2.Gradient = true;
            this.alphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel2.GradientOffset = 1F;
            this.alphaGradientPanel2.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel2.Grayscale = false;
            this.alphaGradientPanel2.Image = null;
            this.alphaGradientPanel2.ImageAlpha = 75;
            this.alphaGradientPanel2.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel2.ImagePosition = System.Windows.Forms.ImagePosition.BottomRight;
            this.alphaGradientPanel2.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel2.Location = new System.Drawing.Point(398, 12);
            this.alphaGradientPanel2.Name = "alphaGradientPanel2";
            this.alphaGradientPanel2.Rounded = true;
            this.alphaGradientPanel2.Size = new System.Drawing.Size(200, 161);
            this.alphaGradientPanel2.TabIndex = 4;
            // 
            // colorWithAlpha1
            // 
            this.colorWithAlpha1.Alpha = 255;
            this.colorWithAlpha1.Color = System.Drawing.Color.Green;
            this.colorWithAlpha1.Parent = this.alphaGradientPanel2;
            // 
            // colorWithAlpha2
            // 
            this.colorWithAlpha2.Alpha = 255;
            this.colorWithAlpha2.Color = System.Drawing.Color.DarkGreen;
            this.colorWithAlpha2.Parent = this.alphaGradientPanel2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 55);
            this.label4.TabIndex = 2;
            this.label4.Text = "32";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Média Semanal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(528, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Visitas por dia da semana";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Portaria.Properties.Resources.logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(676, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(12, 224);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(484, 217);
            this.formsPlot1.TabIndex = 16;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alphaGradientPanel2);
            this.Controls.Add(this.alphaGradientPanel1);
            this.Controls.Add(this.pieChart1);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Estatísticas Gerais";
            this.alphaGradientPanel1.ResumeLayout(false);
            this.alphaGradientPanel1.PerformLayout();
            this.alphaGradientPanel2.ResumeLayout(false);
            this.alphaGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel2;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha3;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha4;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha1;
        private System.Windows.Forms.ColorWithAlpha colorWithAlpha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ScottPlot.FormsPlot formsPlot1;
    }
}