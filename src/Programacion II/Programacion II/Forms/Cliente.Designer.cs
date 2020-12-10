
namespace Programacion_II.Forms
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_ape = new System.Windows.Forms.TextBox();
            this.Txt_cod = new System.Windows.Forms.TextBox();
            this.Txt_ced = new System.Windows.Forms.TextBox();
            this.Txt_dir = new System.Windows.Forms.TextBox();
            this.Txt_ema = new System.Windows.Forms.TextBox();
            this.Mt_tel = new System.Windows.Forms.MaskedTextBox();
            this.Dtt_FEC = new System.Windows.Forms.DateTimePicker();
            this.Txt_nom = new System.Windows.Forms.TextBox();
            this.Cb_sex = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cb_tip = new System.Windows.Forms.ComboBox();
            this.Mt_val = new System.Windows.Forms.MaskedTextBox();
            this.Bt_can = new System.Windows.Forms.Button();
            this.Bt_mod = new System.Windows.Forms.Button();
            this.Bt_gua = new System.Windows.Forms.Button();
            this.Bt_nue = new System.Windows.Forms.Button();
            this.Bt_Atras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bt_Buscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_Atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeight = 30;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(183)))), ((int)(((byte)(241)))));
            this.DGV.Location = new System.Drawing.Point(6, 48);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(474, 462);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bt_Atras);
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Bt_Buscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 516);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cedula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Email";
            // 
            // Txt_ape
            // 
            this.Txt_ape.Location = new System.Drawing.Point(78, 82);
            this.Txt_ape.Name = "Txt_ape";
            this.Txt_ape.Size = new System.Drawing.Size(301, 20);
            this.Txt_ape.TabIndex = 2;
            // 
            // Txt_cod
            // 
            this.Txt_cod.Location = new System.Drawing.Point(78, 19);
            this.Txt_cod.Name = "Txt_cod";
            this.Txt_cod.ReadOnly = true;
            this.Txt_cod.Size = new System.Drawing.Size(301, 20);
            this.Txt_cod.TabIndex = 0;
            // 
            // Txt_ced
            // 
            this.Txt_ced.Location = new System.Drawing.Point(78, 148);
            this.Txt_ced.Name = "Txt_ced";
            this.Txt_ced.Size = new System.Drawing.Size(301, 20);
            this.Txt_ced.TabIndex = 4;
            // 
            // Txt_dir
            // 
            this.Txt_dir.Location = new System.Drawing.Point(78, 181);
            this.Txt_dir.Multiline = true;
            this.Txt_dir.Name = "Txt_dir";
            this.Txt_dir.Size = new System.Drawing.Size(301, 70);
            this.Txt_dir.TabIndex = 5;
            // 
            // Txt_ema
            // 
            this.Txt_ema.Location = new System.Drawing.Point(78, 323);
            this.Txt_ema.Name = "Txt_ema";
            this.Txt_ema.Size = new System.Drawing.Size(301, 20);
            this.Txt_ema.TabIndex = 8;
            // 
            // Mt_tel
            // 
            this.Mt_tel.Location = new System.Drawing.Point(78, 257);
            this.Mt_tel.Mask = "000-000-0000";
            this.Mt_tel.Name = "Mt_tel";
            this.Mt_tel.Size = new System.Drawing.Size(301, 20);
            this.Mt_tel.TabIndex = 6;
            // 
            // Dtt_FEC
            // 
            this.Dtt_FEC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtt_FEC.Location = new System.Drawing.Point(131, 289);
            this.Dtt_FEC.Name = "Dtt_FEC";
            this.Dtt_FEC.Size = new System.Drawing.Size(248, 20);
            this.Dtt_FEC.TabIndex = 7;
            // 
            // Txt_nom
            // 
            this.Txt_nom.Location = new System.Drawing.Point(78, 49);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(301, 20);
            this.Txt_nom.TabIndex = 1;
            // 
            // Cb_sex
            // 
            this.Cb_sex.FormattingEnabled = true;
            this.Cb_sex.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.Cb_sex.Location = new System.Drawing.Point(78, 115);
            this.Cb_sex.Name = "Cb_sex";
            this.Cb_sex.Size = new System.Drawing.Size(301, 21);
            this.Cb_sex.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tipo de Cuenta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Primer Deposito";
            // 
            // Cb_tip
            // 
            this.Cb_tip.FormattingEnabled = true;
            this.Cb_tip.Location = new System.Drawing.Point(106, 353);
            this.Cb_tip.Name = "Cb_tip";
            this.Cb_tip.Size = new System.Drawing.Size(197, 21);
            this.Cb_tip.TabIndex = 9;
            // 
            // Mt_val
            // 
            this.Mt_val.Location = new System.Drawing.Point(108, 385);
            this.Mt_val.Mask = "$ 000,000";
            this.Mt_val.Name = "Mt_val";
            this.Mt_val.Size = new System.Drawing.Size(151, 20);
            this.Mt_val.TabIndex = 10;
            // 
            // Bt_can
            // 
            this.Bt_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_can.Image = global::Programacion_II.Properties.Resources.icons8_delete_document_50px;
            this.Bt_can.Location = new System.Drawing.Point(210, 444);
            this.Bt_can.Name = "Bt_can";
            this.Bt_can.Size = new System.Drawing.Size(60, 60);
            this.Bt_can.TabIndex = 14;
            this.info.SetToolTip(this.Bt_can, "Cancelar");
            this.Bt_can.UseVisualStyleBackColor = true;
            this.Bt_can.Click += new System.EventHandler(this.Bt_can_Click);
            // 
            // Bt_mod
            // 
            this.Bt_mod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_mod.Image = global::Programacion_II.Properties.Resources.icons8_edit_property_50px;
            this.Bt_mod.Location = new System.Drawing.Point(144, 444);
            this.Bt_mod.Name = "Bt_mod";
            this.Bt_mod.Size = new System.Drawing.Size(60, 60);
            this.Bt_mod.TabIndex = 13;
            this.info.SetToolTip(this.Bt_mod, "Actializar Informacion");
            this.Bt_mod.UseVisualStyleBackColor = true;
            this.Bt_mod.Click += new System.EventHandler(this.Bt_mod_Click);
            // 
            // Bt_gua
            // 
            this.Bt_gua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_gua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_gua.Image = global::Programacion_II.Properties.Resources.icons8_save_as_50px;
            this.Bt_gua.Location = new System.Drawing.Point(78, 444);
            this.Bt_gua.Name = "Bt_gua";
            this.Bt_gua.Size = new System.Drawing.Size(60, 60);
            this.Bt_gua.TabIndex = 12;
            this.info.SetToolTip(this.Bt_gua, "Grardar Datos");
            this.Bt_gua.UseVisualStyleBackColor = true;
            this.Bt_gua.Click += new System.EventHandler(this.Bt_gua_Click);
            // 
            // Bt_nue
            // 
            this.Bt_nue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bt_nue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_nue.Image = global::Programacion_II.Properties.Resources.icons8_document_50px;
            this.Bt_nue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_nue.Location = new System.Drawing.Point(12, 444);
            this.Bt_nue.Name = "Bt_nue";
            this.Bt_nue.Size = new System.Drawing.Size(60, 60);
            this.Bt_nue.TabIndex = 11;
            this.info.SetToolTip(this.Bt_nue, "Limpiar formulario");
            this.Bt_nue.UseVisualStyleBackColor = true;
            this.Bt_nue.Click += new System.EventHandler(this.Bt_nue_Click);
            // 
            // Bt_Atras
            // 
            this.Bt_Atras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Atras.Image = global::Programacion_II.Properties.Resources.icons8_undo_50px;
            this.Bt_Atras.Location = new System.Drawing.Point(451, 13);
            this.Bt_Atras.Name = "Bt_Atras";
            this.Bt_Atras.Size = new System.Drawing.Size(29, 29);
            this.Bt_Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bt_Atras.TabIndex = 29;
            this.Bt_Atras.TabStop = false;
            this.info.SetToolTip(this.Bt_Atras, "Volver al Menu Principal");
            this.Bt_Atras.Click += new System.EventHandler(this.Bt_Atras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Programacion_II.Properties.Resources.icons8_print_50px;
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bt_Buscar
            // 
            this.Bt_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Buscar.Image = global::Programacion_II.Properties.Resources.icons8_search_50px1;
            this.Bt_Buscar.Location = new System.Drawing.Point(416, 13);
            this.Bt_Buscar.Name = "Bt_Buscar";
            this.Bt_Buscar.Size = new System.Drawing.Size(29, 29);
            this.Bt_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bt_Buscar.TabIndex = 29;
            this.Bt_Buscar.TabStop = false;
            this.info.SetToolTip(this.Bt_Buscar, "Buscar");
            this.Bt_Buscar.Click += new System.EventHandler(this.Bt_Buscar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 516);
            this.Controls.Add(this.Mt_val);
            this.Controls.Add(this.Cb_tip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cb_sex);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Bt_can);
            this.Controls.Add(this.Bt_mod);
            this.Controls.Add(this.Bt_gua);
            this.Controls.Add(this.Bt_nue);
            this.Controls.Add(this.Dtt_FEC);
            this.Controls.Add(this.Mt_tel);
            this.Controls.Add(this.Txt_ema);
            this.Controls.Add(this.Txt_dir);
            this.Controls.Add(this.Txt_ced);
            this.Controls.Add(this.Txt_cod);
            this.Controls.Add(this.Txt_ape);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_Atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bt_Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Bt_Buscar;
        private System.Windows.Forms.PictureBox Bt_Atras;
        private System.Windows.Forms.ToolTip info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_ape;
        private System.Windows.Forms.TextBox Txt_cod;
        private System.Windows.Forms.TextBox Txt_ced;
        private System.Windows.Forms.TextBox Txt_dir;
        private System.Windows.Forms.TextBox Txt_ema;
        private System.Windows.Forms.MaskedTextBox Mt_tel;
        private System.Windows.Forms.DateTimePicker Dtt_FEC;
        private System.Windows.Forms.Button Bt_nue;
        private System.Windows.Forms.Button Bt_gua;
        private System.Windows.Forms.Button Bt_mod;
        private System.Windows.Forms.Button Bt_can;
        private System.Windows.Forms.TextBox Txt_nom;
        private System.Windows.Forms.ComboBox Cb_sex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cb_tip;
        private System.Windows.Forms.MaskedTextBox Mt_val;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}