using System.Windows.Forms;

namespace Portaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorWithAlpha1 = new System.Windows.Forms.ColorWithAlpha();
            this.colorWithAlpha2 = new System.Windows.Forms.ColorWithAlpha();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button1.ForeColor = System.Drawing.Color.Gold;
            this.Button1.Location = new System.Drawing.Point(351, 295);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(98, 38);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Entrar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_CLick);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordBox.Location = new System.Drawing.Point(201, 250);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(390, 22);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Senha";
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userBox.Location = new System.Drawing.Point(201, 187);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(390, 22);
            this.userBox.TabIndex = 2;
            this.userBox.Text = "Usuário";
            this.userBox.Enter += new System.EventHandler(this.userBox_Enter);
            this.userBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userBox_KeyDown);
            this.userBox.Leave += new System.EventHandler(this.userBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(332, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Portaria Sesc Santa Luzia v1.4";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Portaria.Properties.Resources.logo_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(624, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // colorWithAlpha1
            // 
            this.colorWithAlpha1.Alpha = 200;
            this.colorWithAlpha1.Color = System.Drawing.SystemColors.Control;
            this.colorWithAlpha1.Parent = null;
            // 
            // colorWithAlpha2
            // 
            this.colorWithAlpha2.Alpha = 3;
            this.colorWithAlpha2.Color = System.Drawing.Color.RoyalBlue;
            this.colorWithAlpha2.Parent = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private ColorWithAlpha colorWithAlpha1;
        private ColorWithAlpha colorWithAlpha2;
    }
    }


   


