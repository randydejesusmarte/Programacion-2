namespace Programacion_II
{
    partial class Deposito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Mt_val = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_mon = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Mt_mon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_tip = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Mt_num = new System.Windows.Forms.MaskedTextBox();
            this.Mt_ced = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_can = new System.Windows.Forms.Button();
            this.Bt_mod = new System.Windows.Forms.Button();
            this.Bt_gua = new System.Windows.Forms.Button();
            this.Bt_nue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tx_nom = new System.Windows.Forms.TextBox();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.Tiempo = new System.Windows.Forms.Label();
            this.Mensage = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 39);
            this.label9.TabIndex = 9;
            this.label9.Text = "Depósito a la Cuenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.Mt_val);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cb_mon);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Mt_mon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cb_tip);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Mt_num);
            this.groupBox1.Controls.Add(this.Mt_ced);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bt_can);
            this.groupBox1.Controls.Add(this.Bt_mod);
            this.groupBox1.Controls.Add(this.Bt_gua);
            this.groupBox1.Controls.Add(this.Bt_nue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tx_nom);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 231);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(150, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 19;
            this.txt_id.Text = "No. 00000001";
            // 
            // Mt_val
            // 
            this.Mt_val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mt_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mt_val.HidePromptOnLeave = true;
            this.Mt_val.Location = new System.Drawing.Point(658, 195);
            this.Mt_val.Mask = "$999,999.00";
            this.Mt_val.Name = "Mt_val";
            this.Mt_val.Size = new System.Drawing.Size(92, 22);
            this.Mt_val.TabIndex = 11;
            this.Mt_val.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Contenido de Cuenta:";
            // 
            // Cb_mon
            // 
            this.Cb_mon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_mon.FormattingEnabled = true;
            this.Cb_mon.Items.AddRange(new object[] {
            "Peso----$",
            "Dollar---$",
            "Euro ----€",
            "Libra----£"});
            this.Cb_mon.Location = new System.Drawing.Point(588, 73);
            this.Cb_mon.Name = "Cb_mon";
            this.Cb_mon.Size = new System.Drawing.Size(141, 21);
            this.Cb_mon.TabIndex = 5;
            this.Cb_mon.Text = "Moneda";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Monto a Depósitar";
            // 
            // Mt_mon
            // 
            this.Mt_mon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mt_mon.HidePromptOnLeave = true;
            this.Mt_mon.Location = new System.Drawing.Point(588, 47);
            this.Mt_mon.Mask = "$999,999.00";
            this.Mt_mon.Name = "Mt_mon";
            this.Mt_mon.Size = new System.Drawing.Size(141, 20);
            this.Mt_mon.TabIndex = 4;
            this.Mt_mon.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Moneda";
            // 
            // Cb_tip
            // 
            this.Cb_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_tip.FormattingEnabled = true;
            this.Cb_tip.Items.AddRange(new object[] {
            "---Seleccione el Tipo de Cuenta---",
            "Cuenta corrientes",
            "Cuenta  de ahorro",
            "Cuenta nómina",
            "Cuenta bancarias para empresas y negocios"});
            this.Cb_tip.Location = new System.Drawing.Point(101, 79);
            this.Cb_tip.Name = "Cb_tip";
            this.Cb_tip.Size = new System.Drawing.Size(200, 21);
            this.Cb_tip.TabIndex = 2;
            this.Cb_tip.Text = "---Seleccione el Tipo de Cuenta---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Tipo de Cuenta";
            // 
            // Mt_num
            // 
            this.Mt_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mt_num.Location = new System.Drawing.Point(163, 51);
            this.Mt_num.Mask = "0000-000-000-00-00000";
            this.Mt_num.Name = "Mt_num";
            this.Mt_num.Size = new System.Drawing.Size(126, 20);
            this.Mt_num.TabIndex = 1;
            // 
            // Mt_ced
            // 
            this.Mt_ced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mt_ced.Location = new System.Drawing.Point(546, 98);
            this.Mt_ced.Mask = "000-0000000-0";
            this.Mt_ced.Name = "Mt_ced";
            this.Mt_ced.Size = new System.Drawing.Size(183, 20);
            this.Mt_ced.TabIndex = 6;
            this.Mt_ced.Text = "40246135555";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Numero de Cuenta: No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Deposito:";
            // 
            // Bt_can
            // 
            this.Bt_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_can.AutoSize = true;
            this.Bt_can.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_can.Image = global::Programacion_II.Properties.Resources.icons8_delete_document_50px;
            this.Bt_can.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_can.Location = new System.Drawing.Point(199, 173);
            this.Bt_can.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_can.Name = "Bt_can";
            this.Bt_can.Size = new System.Drawing.Size(58, 58);
            this.Bt_can.TabIndex = 10;
            this.Bt_can.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mensage.SetToolTip(this.Bt_can, "Borrar Depósito");
            this.Bt_can.UseVisualStyleBackColor = true;
            this.Bt_can.Click += new System.EventHandler(this.Bt_can_Click);
            // 
            // Bt_mod
            // 
            this.Bt_mod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_mod.AutoSize = true;
            this.Bt_mod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_mod.Image = ((System.Drawing.Image)(resources.GetObject("Bt_mod.Image")));
            this.Bt_mod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_mod.Location = new System.Drawing.Point(135, 173);
            this.Bt_mod.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_mod.Name = "Bt_mod";
            this.Bt_mod.Size = new System.Drawing.Size(58, 58);
            this.Bt_mod.TabIndex = 9;
            this.Bt_mod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mensage.SetToolTip(this.Bt_mod, "Modificar Depósito");
            this.Bt_mod.UseVisualStyleBackColor = true;
            this.Bt_mod.Click += new System.EventHandler(this.Bt_mod_Click);
            // 
            // Bt_gua
            // 
            this.Bt_gua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_gua.AutoSize = true;
            this.Bt_gua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_gua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_gua.Image = global::Programacion_II.Properties.Resources.icons8_save_as_50px;
            this.Bt_gua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_gua.Location = new System.Drawing.Point(71, 173);
            this.Bt_gua.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_gua.Name = "Bt_gua";
            this.Bt_gua.Size = new System.Drawing.Size(58, 58);
            this.Bt_gua.TabIndex = 8;
            this.Bt_gua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mensage.SetToolTip(this.Bt_gua, "Guardar Depósito");
            this.Bt_gua.UseVisualStyleBackColor = true;
            this.Bt_gua.Click += new System.EventHandler(this.Bt_gua_Click);
            // 
            // Bt_nue
            // 
            this.Bt_nue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_nue.AutoSize = true;
            this.Bt_nue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_nue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_nue.Image = ((System.Drawing.Image)(resources.GetObject("Bt_nue.Image")));
            this.Bt_nue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_nue.Location = new System.Drawing.Point(7, 173);
            this.Bt_nue.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_nue.Name = "Bt_nue";
            this.Bt_nue.Size = new System.Drawing.Size(58, 58);
            this.Bt_nue.TabIndex = 7;
            this.Bt_nue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mensage.SetToolTip(this.Bt_nue, "Nuevo Depósito");
            this.Bt_nue.UseVisualStyleBackColor = true;
            this.Bt_nue.Click += new System.EventHandler(this.Bt_nue_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del Beneficiario ";
            // 
            // Tx_nom
            // 
            this.Tx_nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx_nom.Location = new System.Drawing.Point(147, 107);
            this.Tx_nom.Margin = new System.Windows.Forms.Padding(4);
            this.Tx_nom.Name = "Tx_nom";
            this.Tx_nom.Size = new System.Drawing.Size(263, 20);
            this.Tx_nom.TabIndex = 3;
            // 
            // Tempo
            // 
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // Tiempo
            // 
            this.Tiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tiempo.AutoSize = true;
            this.Tiempo.Location = new System.Drawing.Point(726, 8);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(0, 13);
            this.Tiempo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Oficina:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "5165";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "C/ Espallat, Bella Vista, Santiago, RD.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(138, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sucursal:";
            // 
            // Atras
            // 
            this.Atras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Image = global::Programacion_II.Properties.Resources.icons8_undo_50px;
            this.Atras.Location = new System.Drawing.Point(760, 33);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(59, 53);
            this.Atras.TabIndex = 18;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Programacion_II.Properties.Resources.blank_user_profile__1_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 337);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depósito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Mt_ced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_can;
        private System.Windows.Forms.Button Bt_mod;
        private System.Windows.Forms.Button Bt_gua;
        private System.Windows.Forms.Button Bt_nue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tx_nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip Mensage;
        private System.Windows.Forms.ComboBox Cb_tip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox Mt_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Cb_mon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox Mt_mon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.MaskedTextBox Mt_val;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
    }
}

