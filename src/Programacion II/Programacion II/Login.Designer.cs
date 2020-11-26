
namespace Programacion_II
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtnom = new System.Windows.Forms.TextBox();
            this.Txtcla = new System.Windows.Forms.TextBox();
            this.BT_Entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // Txtnom
            // 
            this.Txtnom.Location = new System.Drawing.Point(78, 171);
            this.Txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.Txtnom.Name = "Txtnom";
            this.Txtnom.Size = new System.Drawing.Size(243, 23);
            this.Txtnom.TabIndex = 3;
            // 
            // Txtcla
            // 
            this.Txtcla.Location = new System.Drawing.Point(78, 220);
            this.Txtcla.Margin = new System.Windows.Forms.Padding(4);
            this.Txtcla.Name = "Txtcla";
            this.Txtcla.Size = new System.Drawing.Size(243, 23);
            this.Txtcla.TabIndex = 4;
            this.Txtcla.UseSystemPasswordChar = true;
            // 
            // BT_Entrar
            // 
            this.BT_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BT_Entrar.FlatAppearance.BorderSize = 2;
            this.BT_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Entrar.Location = new System.Drawing.Point(21, 268);
            this.BT_Entrar.Name = "BT_Entrar";
            this.BT_Entrar.Size = new System.Drawing.Size(301, 58);
            this.BT_Entrar.TabIndex = 5;
            this.BT_Entrar.Text = "Entrar";
            this.BT_Entrar.UseVisualStyleBackColor = true;
            this.BT_Entrar.Click += new System.EventHandler(this.BT_Entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programacion_II.Properties.Resources.icons8_user_menu_male_96px;
            this.pictureBox1.Location = new System.Drawing.Point(102, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 340);
            this.Controls.Add(this.BT_Entrar);
            this.Controls.Add(this.Txtcla);
            this.Controls.Add(this.Txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtnom;
        private System.Windows.Forms.TextBox Txtcla;
        private System.Windows.Forms.Button BT_Entrar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}