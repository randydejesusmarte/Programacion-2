
namespace Programacion_II
{
    partial class Menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            this.BtDeposito = new System.Windows.Forms.Button();
            this.BtRetiro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btlogout = new System.Windows.Forms.Button();
            this.Btacercad = new System.Windows.Forms.Button();
            this.BtPrestamo = new System.Windows.Forms.Button();
            this.BtUsuario = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtDeposito
            // 
            this.BtDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeposito.Location = new System.Drawing.Point(3, 3);
            this.BtDeposito.Name = "BtDeposito";
            this.BtDeposito.Size = new System.Drawing.Size(198, 171);
            this.BtDeposito.TabIndex = 0;
            this.BtDeposito.Text = "Depósito";
            this.BtDeposito.UseVisualStyleBackColor = true;
            this.BtDeposito.Click += new System.EventHandler(this.BtDeposito_Click);
            // 
            // BtRetiro
            // 
            this.BtRetiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRetiro.Location = new System.Drawing.Point(207, 3);
            this.BtRetiro.Name = "BtRetiro";
            this.BtRetiro.Size = new System.Drawing.Size(198, 171);
            this.BtRetiro.TabIndex = 1;
            this.BtRetiro.Text = "Retiro";
            this.BtRetiro.UseVisualStyleBackColor = true;
            this.BtRetiro.Click += new System.EventHandler(this.BtRetiro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.Btlogout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btacercad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtDeposito, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtRetiro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtPrestamo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtUsuario, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 355);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Btlogout
            // 
            this.Btlogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btlogout.Location = new System.Drawing.Point(411, 180);
            this.Btlogout.Name = "Btlogout";
            this.Btlogout.Size = new System.Drawing.Size(178, 172);
            this.Btlogout.TabIndex = 5;
            this.Btlogout.Text = "Cerrar seccion";
            this.Btlogout.UseVisualStyleBackColor = true;
            this.Btlogout.Click += new System.EventHandler(this.Btlogout_Click);
            // 
            // Btacercad
            // 
            this.Btacercad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btacercad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btacercad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btacercad.Location = new System.Drawing.Point(207, 180);
            this.Btacercad.Name = "Btacercad";
            this.Btacercad.Size = new System.Drawing.Size(198, 172);
            this.Btacercad.TabIndex = 4;
            this.Btacercad.Text = "Acerca de";
            this.Btacercad.UseVisualStyleBackColor = true;
            this.Btacercad.Click += new System.EventHandler(this.Btacercad_Click);
            // 
            // BtPrestamo
            // 
            this.BtPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrestamo.Location = new System.Drawing.Point(411, 3);
            this.BtPrestamo.Name = "BtPrestamo";
            this.BtPrestamo.Size = new System.Drawing.Size(178, 171);
            this.BtPrestamo.TabIndex = 2;
            this.BtPrestamo.Text = "Prestamo";
            this.BtPrestamo.UseVisualStyleBackColor = true;
            this.BtPrestamo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtUsuario
            // 
            this.BtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtUsuario.Location = new System.Drawing.Point(3, 180);
            this.BtUsuario.Name = "BtUsuario";
            this.BtUsuario.Size = new System.Drawing.Size(198, 172);
            this.BtUsuario.TabIndex = 3;
            this.BtUsuario.Text = "Usuario";
            this.BtUsuario.UseVisualStyleBackColor = true;
            this.BtUsuario.Click += new System.EventHandler(this.BtUsuario_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_principal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtDeposito;
        private System.Windows.Forms.Button BtRetiro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtPrestamo;
        private System.Windows.Forms.Button BtUsuario;
        private System.Windows.Forms.Button Btlogout;
        private System.Windows.Forms.Button Btacercad;
    }
}