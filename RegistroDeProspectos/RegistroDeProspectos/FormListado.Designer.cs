namespace RegistroDeProspectos
{
    partial class FormListado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_abrirForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_prospectos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Evaluar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prospectos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_abrirForm
            // 
            this.btn_abrirForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_abrirForm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirForm.Location = new System.Drawing.Point(838, 28);
            this.btn_abrirForm.Name = "btn_abrirForm";
            this.btn_abrirForm.Size = new System.Drawing.Size(168, 47);
            this.btn_abrirForm.TabIndex = 0;
            this.btn_abrirForm.Text = "Registrar Prospecto";
            this.btn_abrirForm.UseVisualStyleBackColor = false;
            this.btn_abrirForm.Click += new System.EventHandler(this.btn_abrirForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de prospectos";
            // 
            // dgv_prospectos
            // 
            this.dgv_prospectos.AllowUserToAddRows = false;
            this.dgv_prospectos.AllowUserToResizeColumns = false;
            this.dgv_prospectos.AllowUserToResizeRows = false;
            this.dgv_prospectos.ColumnHeadersHeight = 29;
            this.dgv_prospectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_prospectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.primerApellido,
            this.segundoApellido,
            this.Estatus,
            this.Detalles,
            this.Evaluar});
            this.dgv_prospectos.Location = new System.Drawing.Point(31, 142);
            this.dgv_prospectos.Name = "dgv_prospectos";
            this.dgv_prospectos.RowHeadersWidth = 51;
            this.dgv_prospectos.RowTemplate.Height = 24;
            this.dgv_prospectos.ShowEditingIcon = false;
            this.dgv_prospectos.Size = new System.Drawing.Size(991, 307);
            this.dgv_prospectos.TabIndex = 2;
            this.dgv_prospectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prospectos_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 200F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.Width = 125;
            // 
            // primerApellido
            // 
            this.primerApellido.HeaderText = "Primer Apellido";
            this.primerApellido.MinimumWidth = 6;
            this.primerApellido.Name = "primerApellido";
            this.primerApellido.ReadOnly = true;
            this.primerApellido.Width = 125;
            // 
            // segundoApellido
            // 
            this.segundoApellido.HeaderText = "Segundo Apellido";
            this.segundoApellido.MinimumWidth = 6;
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.ReadOnly = true;
            this.segundoApellido.Width = 125;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estatus.Width = 80;
            // 
            // Detalles
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Detalles.Text = "Detalles";
            this.Detalles.Width = 80;
            // 
            // Evaluar
            // 
            this.Evaluar.HeaderText = "Evaluar";
            this.Evaluar.MinimumWidth = 6;
            this.Evaluar.Name = "Evaluar";
            this.Evaluar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Evaluar.Text = "Evaluar";
            this.Evaluar.Width = 80;
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1058, 497);
            this.Controls.Add(this.dgv_prospectos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abrirForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Listado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListado_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListado_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prospectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abrirForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_prospectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.DataGridViewButtonColumn Evaluar;
    }
}

