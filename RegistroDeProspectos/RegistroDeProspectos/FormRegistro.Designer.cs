namespace RegistroDeProspectos
{
    partial class FormRegistro
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_primerApellido = new System.Windows.Forms.TextBox();
            this.txt_segundoApellido = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_numCasa = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_codigoPostal = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cargaDocumento = new System.Windows.Forms.Button();
            this.lbl_nomDocumento = new System.Windows.Forms.Label();
            this.btn_guardarRegistro = new System.Windows.Forms.Button();
            this.btn_cancelarRegistro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_documentos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(77, 96);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(213, 30);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_primerApellido
            // 
            this.txt_primerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_primerApellido.Location = new System.Drawing.Point(77, 157);
            this.txt_primerApellido.MaxLength = 30;
            this.txt_primerApellido.Name = "txt_primerApellido";
            this.txt_primerApellido.Size = new System.Drawing.Size(213, 30);
            this.txt_primerApellido.TabIndex = 1;
            this.txt_primerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_primerApellido_KeyPress);
            // 
            // txt_segundoApellido
            // 
            this.txt_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_segundoApellido.Location = new System.Drawing.Point(77, 226);
            this.txt_segundoApellido.MaxLength = 30;
            this.txt_segundoApellido.Name = "txt_segundoApellido";
            this.txt_segundoApellido.Size = new System.Drawing.Size(213, 30);
            this.txt_segundoApellido.TabIndex = 2;
            this.txt_segundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_segundoApellido_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.Location = new System.Drawing.Point(77, 287);
            this.txt_calle.MaxLength = 50;
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(387, 30);
            this.txt_calle.TabIndex = 3;
            this.txt_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // txt_numCasa
            // 
            this.txt_numCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numCasa.Location = new System.Drawing.Point(485, 287);
            this.txt_numCasa.MaxLength = 6;
            this.txt_numCasa.Name = "txt_numCasa";
            this.txt_numCasa.Size = new System.Drawing.Size(213, 30);
            this.txt_numCasa.TabIndex = 4;
            this.txt_numCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numCasa_KeyPress);
            // 
            // txt_colonia
            // 
            this.txt_colonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colonia.Location = new System.Drawing.Point(77, 352);
            this.txt_colonia.MaxLength = 50;
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(387, 30);
            this.txt_colonia.TabIndex = 5;
            this.txt_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_colonia_KeyPress);
            // 
            // txt_codigoPostal
            // 
            this.txt_codigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoPostal.Location = new System.Drawing.Point(485, 352);
            this.txt_codigoPostal.MaxLength = 5;
            this.txt_codigoPostal.Name = "txt_codigoPostal";
            this.txt_codigoPostal.Size = new System.Drawing.Size(213, 30);
            this.txt_codigoPostal.TabIndex = 6;
            this.txt_codigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoPostal_KeyPress);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(77, 412);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(213, 30);
            this.txt_telefono.TabIndex = 7;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_rfc
            // 
            this.txt_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.Location = new System.Drawing.Point(485, 412);
            this.txt_rfc.MaxLength = 13;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(213, 30);
            this.txt_rfc.TabIndex = 8;
            this.txt_rfc.TextChanged += new System.EventHandler(this.txt_rfc_TextChanged);
            this.txt_rfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rfc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Primer apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Segundo apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "No. Casa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Colonia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "RFC";
            // 
            // btn_cargaDocumento
            // 
            this.btn_cargaDocumento.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cargaDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargaDocumento.Location = new System.Drawing.Point(568, 36);
            this.btn_cargaDocumento.Name = "btn_cargaDocumento";
            this.btn_cargaDocumento.Size = new System.Drawing.Size(204, 58);
            this.btn_cargaDocumento.TabIndex = 18;
            this.btn_cargaDocumento.Text = "Cargar Documento";
            this.btn_cargaDocumento.UseVisualStyleBackColor = false;
            this.btn_cargaDocumento.Click += new System.EventHandler(this.btn_cargaDocumento_Click);
            // 
            // lbl_nomDocumento
            // 
            this.lbl_nomDocumento.AutoSize = true;
            this.lbl_nomDocumento.Location = new System.Drawing.Point(421, 29);
            this.lbl_nomDocumento.Name = "lbl_nomDocumento";
            this.lbl_nomDocumento.Size = new System.Drawing.Size(0, 16);
            this.lbl_nomDocumento.TabIndex = 19;
            this.lbl_nomDocumento.Visible = false;
            // 
            // btn_guardarRegistro
            // 
            this.btn_guardarRegistro.BackColor = System.Drawing.Color.LightGreen;
            this.btn_guardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarRegistro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_guardarRegistro.Location = new System.Drawing.Point(727, 471);
            this.btn_guardarRegistro.Name = "btn_guardarRegistro";
            this.btn_guardarRegistro.Size = new System.Drawing.Size(99, 35);
            this.btn_guardarRegistro.TabIndex = 20;
            this.btn_guardarRegistro.Text = "Guardar";
            this.btn_guardarRegistro.UseVisualStyleBackColor = false;
            this.btn_guardarRegistro.Click += new System.EventHandler(this.btn_guardarRegistro_Click);
            // 
            // btn_cancelarRegistro
            // 
            this.btn_cancelarRegistro.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cancelarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarRegistro.Location = new System.Drawing.Point(610, 471);
            this.btn_cancelarRegistro.Name = "btn_cancelarRegistro";
            this.btn_cancelarRegistro.Size = new System.Drawing.Size(99, 35);
            this.btn_cancelarRegistro.TabIndex = 21;
            this.btn_cancelarRegistro.Text = "Cancelar";
            this.btn_cancelarRegistro.UseVisualStyleBackColor = false;
            this.btn_cancelarRegistro.Click += new System.EventHandler(this.btn_cancelarRegistro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 38);
            this.label10.TabIndex = 22;
            this.label10.Text = "Registro de prospectos";
            // 
            // dgv_documentos
            // 
            this.dgv_documentos.AllowUserToAddRows = false;
            this.dgv_documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_documentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo});
            this.dgv_documentos.Location = new System.Drawing.Point(486, 116);
            this.dgv_documentos.Name = "dgv_documentos";
            this.dgv_documentos.RowHeadersWidth = 51;
            this.dgv_documentos.RowTemplate.Height = 24;
            this.dgv_documentos.Size = new System.Drawing.Size(350, 140);
            this.dgv_documentos.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Documentos Cargados";
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Documento";
            this.Archivo.MinimumWidth = 6;
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            this.Archivo.Width = 200;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_documentos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_cancelarRegistro);
            this.Controls.Add(this.btn_guardarRegistro);
            this.Controls.Add(this.lbl_nomDocumento);
            this.Controls.Add(this.btn_cargaDocumento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_codigoPostal);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(this.txt_numCasa);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_segundoApellido);
            this.Controls.Add(this.txt_primerApellido);
            this.Controls.Add(this.txt_nombre);
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro de prospectos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistro_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_documentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_primerApellido;
        private System.Windows.Forms.TextBox txt_segundoApellido;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_numCasa;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_codigoPostal;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cargaDocumento;
        private System.Windows.Forms.Label lbl_nomDocumento;
        private System.Windows.Forms.Button btn_guardarRegistro;
        private System.Windows.Forms.Button btn_cancelarRegistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_documentos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
    }
}