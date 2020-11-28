
namespace Programacion_II.Forms
{
    partial class ControlUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_ret = new System.Windows.Forms.RadioButton();
            this.Rb_dep = new System.Windows.Forms.RadioButton();
            this.Rb_adm = new System.Windows.Forms.RadioButton();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Txt_nom = new System.Windows.Forms.TextBox();
            this.Txt_ape = new System.Windows.Forms.TextBox();
            this.Txt_cla = new System.Windows.Forms.TextBox();
            this.Txt_ema = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ccl = new System.Windows.Forms.TextBox();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Bt_guardar = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.Bt_modificar = new System.Windows.Forms.Button();
            this.Bt_nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Rb_ret);
            this.groupBox1.Controls.Add(this.Rb_dep);
            this.groupBox1.Controls.Add(this.Rb_adm);
            this.groupBox1.Location = new System.Drawing.Point(26, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario";
            // 
            // Rb_ret
            // 
            this.Rb_ret.AutoSize = true;
            this.Rb_ret.Location = new System.Drawing.Point(231, 39);
            this.Rb_ret.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_ret.Name = "Rb_ret";
            this.Rb_ret.Size = new System.Drawing.Size(68, 20);
            this.Rb_ret.TabIndex = 8;
            this.Rb_ret.Text = "Retiro";
            this.Rb_ret.UseVisualStyleBackColor = true;
            // 
            // Rb_dep
            // 
            this.Rb_dep.AutoSize = true;
            this.Rb_dep.Location = new System.Drawing.Point(134, 39);
            this.Rb_dep.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_dep.Name = "Rb_dep";
            this.Rb_dep.Size = new System.Drawing.Size(89, 20);
            this.Rb_dep.TabIndex = 7;
            this.Rb_dep.Text = "Depocito";
            this.Rb_dep.UseVisualStyleBackColor = true;
            // 
            // Rb_adm
            // 
            this.Rb_adm.AutoSize = true;
            this.Rb_adm.Checked = true;
            this.Rb_adm.Location = new System.Drawing.Point(4, 39);
            this.Rb_adm.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_adm.Name = "Rb_adm";
            this.Rb_adm.Size = new System.Drawing.Size(122, 20);
            this.Rb_adm.TabIndex = 6;
            this.Rb_adm.TabStop = true;
            this.Rb_adm.Text = "Administrador";
            this.Rb_adm.UseVisualStyleBackColor = true;
            // 
            // Txt_id
            // 
            this.Txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_id.Location = new System.Drawing.Point(57, 24);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.ReadOnly = true;
            this.Txt_id.Size = new System.Drawing.Size(100, 22);
            this.Txt_id.TabIndex = 13;
            // 
            // Txt_nom
            // 
            this.Txt_nom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_nom.Location = new System.Drawing.Point(97, 66);
            this.Txt_nom.MaxLength = 50;
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(232, 22);
            this.Txt_nom.TabIndex = 1;
            // 
            // Txt_ape
            // 
            this.Txt_ape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_ape.Location = new System.Drawing.Point(100, 108);
            this.Txt_ape.MaxLength = 50;
            this.Txt_ape.Name = "Txt_ape";
            this.Txt_ape.Size = new System.Drawing.Size(229, 22);
            this.Txt_ape.TabIndex = 2;
            // 
            // Txt_cla
            // 
            this.Txt_cla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_cla.Location = new System.Drawing.Point(97, 150);
            this.Txt_cla.MaxLength = 16;
            this.Txt_cla.Name = "Txt_cla";
            this.Txt_cla.Size = new System.Drawing.Size(232, 22);
            this.Txt_cla.TabIndex = 3;
            // 
            // Txt_ema
            // 
            this.Txt_ema.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_ema.Location = new System.Drawing.Point(81, 234);
            this.Txt_ema.Name = "Txt_ema";
            this.Txt_ema.Size = new System.Drawing.Size(248, 22);
            this.Txt_ema.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Confirmar Clave";
            // 
            // Txt_ccl
            // 
            this.Txt_ccl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_ccl.Location = new System.Drawing.Point(147, 192);
            this.Txt_ccl.MaxLength = 16;
            this.Txt_ccl.Name = "Txt_ccl";
            this.Txt_ccl.Size = new System.Drawing.Size(182, 22);
            this.Txt_ccl.TabIndex = 4;
            // 
            // Bt_cancelar
            // 
            this.Bt_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_cancelar.AutoSize = true;
            this.Bt_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_cancelar.Image = global::Programacion_II.Properties.Resources.icons8_delete_document_50px;
            this.Bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_cancelar.Location = new System.Drawing.Point(247, 377);
            this.Bt_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_cancelar.Name = "Bt_cancelar";
            this.Bt_cancelar.Size = new System.Drawing.Size(58, 58);
            this.Bt_cancelar.TabIndex = 12;
            this.Bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Info.SetToolTip(this.Bt_cancelar, "Cancelar ");
            this.Bt_cancelar.UseVisualStyleBackColor = true;
            this.Bt_cancelar.Click += new System.EventHandler(this.Bt_cancelar_Click);
            // 
            // Bt_guardar
            // 
            this.Bt_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_guardar.AutoSize = true;
            this.Bt_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_guardar.Image = global::Programacion_II.Properties.Resources.icons8_save_as_50px;
            this.Bt_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_guardar.Location = new System.Drawing.Point(115, 377);
            this.Bt_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_guardar.Name = "Bt_guardar";
            this.Bt_guardar.Size = new System.Drawing.Size(58, 58);
            this.Bt_guardar.TabIndex = 10;
            this.Bt_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Info.SetToolTip(this.Bt_guardar, "Guardado del Usuario");
            this.Bt_guardar.UseVisualStyleBackColor = true;
            this.Bt_guardar.Click += new System.EventHandler(this.Bt_guardar_Click);
            // 
            // Info
            // 
            this.Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Bt_modificar
            // 
            this.Bt_modificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_modificar.AutoSize = true;
            this.Bt_modificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Bt_modificar.Image")));
            this.Bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_modificar.Location = new System.Drawing.Point(181, 377);
            this.Bt_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_modificar.Name = "Bt_modificar";
            this.Bt_modificar.Size = new System.Drawing.Size(58, 58);
            this.Bt_modificar.TabIndex = 11;
            this.Bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Info.SetToolTip(this.Bt_modificar, "Actualizar Datos del Usuario");
            this.Bt_modificar.UseVisualStyleBackColor = true;
            this.Bt_modificar.Click += new System.EventHandler(this.Bt_modificar_Click);
            // 
            // Bt_nuevo
            // 
            this.Bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_nuevo.AutoSize = true;
            this.Bt_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Bt_nuevo.Image")));
            this.Bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_nuevo.Location = new System.Drawing.Point(49, 377);
            this.Bt_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_nuevo.Name = "Bt_nuevo";
            this.Bt_nuevo.Size = new System.Drawing.Size(58, 58);
            this.Bt_nuevo.TabIndex = 9;
            this.Bt_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Info.SetToolTip(this.Bt_nuevo, "Limpiar Formulario");
            this.Bt_nuevo.UseVisualStyleBackColor = true;
            this.Bt_nuevo.Click += new System.EventHandler(this.Bt_nuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(353, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 448);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(393, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bt_modificar);
            this.Controls.Add(this.Bt_nuevo);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Bt_guardar);
            this.Controls.Add(this.Txt_ema);
            this.Controls.Add(this.Txt_ccl);
            this.Controls.Add(this.Txt_cla);
            this.Controls.Add(this.Txt_ape);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_ret;
        private System.Windows.Forms.RadioButton Rb_dep;
        private System.Windows.Forms.RadioButton Rb_adm;
        private System.Windows.Forms.TextBox Txt_nom;
        private System.Windows.Forms.TextBox Txt_ape;
        private System.Windows.Forms.TextBox Txt_cla;
        private System.Windows.Forms.TextBox Txt_ema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ccl;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Button Bt_guardar;
        private System.Windows.Forms.ToolTip Info;
        public System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Button Bt_modificar;
        private System.Windows.Forms.Button Bt_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}