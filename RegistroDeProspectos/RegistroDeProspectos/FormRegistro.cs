using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistroDeProspectos
{
    public partial class FormRegistro : Form
    {
        
        Conexiones con = new Conexiones();
        string rutaArchivo;
        string nombreArchivo;
        bool flagGuardado = false;
        string rutaProyecto;
        string rutaEjecutable;

        public class Documento
        {
            public string Nombre { get; set; }
            public string Ruta { get; set; }
        }

        List<Documento> documentos = new List<Documento>();


        public FormRegistro()
        {
            //con.conectar();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_cargaDocumento_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar Archivo PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    nombreArchivo = Path.GetFileName(rutaArchivo);

                    //lbl_nomDocumento.Text = rutaArchivo;
                    //lbl_nomDocumento.Visible = true;

                    documentos.Add(new Documento { Nombre = nombreArchivo, Ruta = rutaArchivo });
                    llenarDgvDoc();
                }
            }
        }

        public void llenarDgvDoc()
        {
            dgv_documentos.Rows.Clear();
            foreach (var documento in documentos)
            {
                string nombre = documento.Nombre;
                string ruta = documento.Ruta;
                dgv_documentos.Rows.Add(nombre);
                //Console.WriteLine($"Nombre: {nombre}, Ruta: {ruta}");
            }
        }

        private void btn_cancelarRegistro_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        public void guardarProspecto()
        {
            rutaEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            rutaProyecto = Path.GetFullPath(Path.Combine(rutaEjecutable, @"..\..\"));
            //MessageBox.Show(rutaProyecto);

            string rutaCarpeta = rutaProyecto + "DocumentosPDF";

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            con.conectar();
            int resp = con.abc("EXEC proc_registrarprospecto " +
                    "@nombre = '" + txt_nombre.Text.Trim() + "'," +
                    "@apellidoPaterno = '" + txt_primerApellido.Text.Trim() + "'," +
                    "@apellidoMaterno = '" + txt_segundoApellido.Text.Trim() + "'," +
                    "@calle = '" + txt_calle.Text.Trim() + "'," +
                    "@numCasa = " + Convert.ToInt32(txt_numCasa.Text.Trim()) + "," +
                    "@colonia = '" + txt_colonia.Text.Trim() + "'," +
                    "@codigoPostal = " + Convert.ToInt32(txt_codigoPostal.Text.Trim()) + "," +
                    "@telefono = '" + txt_telefono.Text.Trim() + "'," +
                    "@RFC = '" + txt_rfc.Text.Trim() + "';");
            if (resp == 1)
            {
                con.closeConection();
                con.conectar();
                foreach (var documento in documentos)
                {
                    string nombre = documento.Nombre;
                    string ruta = documento.Ruta;
                    int resp2 = con.abc("EXEC proc_registrarDocumento " +
                        "@nomDocumento = '" + nombre + "'," +
                        "@desRuta = '" + rutaProyecto + "DocumentosPDF/" + nombre + "';");
                    guardarArchivo(ruta, rutaProyecto + "DocumentosPDF/" + nombre);
                    //Console.WriteLine($"Nombre: {nombre}, Ruta: {ruta}");
                }
                
                MessageBox.Show("Se registro correctamente el prospecto");
                
                flagGuardado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Falló el registro del prospecto");
            }
            con.closeConection();
        }

        public void validarForm()
        {
            if (txt_nombre.Text == "" || txt_nombre.Text == null)
            {
                MessageBox.Show("Favor de ingresar el nombre del prospecto");
            }
            else if (txt_primerApellido.Text == "" || txt_primerApellido.Text == null)
            {
                MessageBox.Show("Favor de ingresar el primer apellido del prospecto");
            }
            else if (txt_calle.Text == "" || txt_calle.Text == null)
            {
                MessageBox.Show("Favor de ingresar el nombre de la calle");
            }
            else if (txt_numCasa.Text == "" || txt_numCasa.Text == null)
            {
                MessageBox.Show("Favor de ingresar el numer de la casa");
            }
            else if (txt_colonia.Text == "" || txt_colonia.Text == null)
            {
                MessageBox.Show("Favor de ingresar el nombre de la colonia");
            }
            else if (txt_codigoPostal.Text == "" || txt_codigoPostal.Text == null)
            {
                MessageBox.Show("Favor de ingresar el codigo postal");
            }
            else if (txt_telefono.Text == "" || txt_telefono.Text == null)
            {
                MessageBox.Show("Favor de ingresar el numero de telefono");
            }
            else if (txt_rfc.Text == "" || txt_rfc.Text == null)
            {
                MessageBox.Show("Favor de ingresar el RFC");
            }
            else if (documentos.Count == 0)
            {
                MessageBox.Show("Favor de seleccionar un documento");
            }
            else
            {
                guardarProspecto();
                
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_guardarRegistro_Click(object sender, EventArgs e)
        {
            validarForm();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloLetras(e);
        }

        private void txt_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloLetras(e);
        }

        private void txt_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloLetras(e);
        }

        private void txt_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloAlfanumericos(e);
        }

        private void txt_numCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloNumeros(e);
        }

        private void txt_colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloAlfanumericos(e);
        }

        private void txt_codigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloNumeros(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloNumeros(e);
        }

        private void txt_rfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.soloAlfanumericos(e);
        }

        private void FormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormListado f1 = new FormListado();
            f1.Visible = true;
            f1.llenarDGV();
        }

        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagGuardado==false)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar el registro? \n Perderá la información capturada sin guardar", "Cerrar Formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        public void guardarArchivo(string rutaOrigen, string rutaDestino)
        {
            try
            {
                File.Copy(rutaOrigen, rutaDestino, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_rfc_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txt_rfc.SelectionStart;
            txt_rfc.Text = txt_rfc.Text.ToUpper();
            txt_rfc.SelectionStart = cursorPosition;
        }
    }
}
