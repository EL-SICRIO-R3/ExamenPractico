using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeProspectos
{
    public partial class FormEvaluacion : Form
    {
        Conexiones con = new Conexiones();
        SqlDataReader dr;
        string rutaDoc;
        bool aprobado;
        int idProspecto;
        bool flagGuardado=false;
        string estatus = "";
        public FormEvaluacion()
        {
            InitializeComponent();
        }

        private void FormEvaluacion_Load(object sender, EventArgs e)
        {
            aprobado = true;
            cb_autorizar.Checked = true;
            estatus = "Autorizado";
            txt_observacionesRechazo.Enabled = false;
        }

        public void llenarDatos(int id)
        {
            con.conectar();
            dr = con.leer("EXEC proc_obtenerprospectoporid @id=" + id + ";");
            if (dr.Read())
            {
                lbl_nombre.Text = Convert.ToString(dr["nom_prospecto"]).Trim();
                lbl_primerApellido.Text = Convert.ToString(dr["des_apellidoPaterno"]).Trim();
                lbl_segundoApelido.Text = Convert.ToString(dr["des_apellidoMaterno"]).Trim();
                lbl_calle.Text = Convert.ToString(dr["nom_calle"]).Trim();
                lbl_numCasa.Text = Convert.ToString(dr["num_casa"]).Trim();
                lbl_colonia.Text = Convert.ToString(dr["nom_colonia"]).Trim();
                lbl_codigoPostal.Text = Convert.ToString(dr["num_codigoPostal"]).Trim();
                lbl_telefono.Text = Convert.ToString(dr["num_telefono"]).Trim();
                lbl_rfc.Text = Convert.ToString(dr["des_rfc"]).Trim();
                lbl_estatus.Text = Convert.ToString(dr["des_estatus"]).Trim();
                idProspecto = id;

            }
            dr.Close();
            con.closeConection();
        }
        public void llenarDgvDocumentos(int id)
        {
            con.conectar();
            dr = con.leer("EXEC proc_obtenerdocumentosporprospecto @id=" + id + ";");
            dgv_documentos.Rows.Clear();
            while (dr.Read() == true)
            {
                dgv_documentos.Rows.Add(dr["nom_documento"], dr["des_ruta"]);
            }
            dr.Close();
            con.closeConection();
        }
        public async void mostrarDoc(string ruta)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string url = "file:///" + ruta;
                    System.Diagnostics.Process.Start(url);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar visualizar el documento, verifique que el documento siggue en" +
                    "la ruta registrada");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rutaDoc != null && rutaDoc != "")
            {
                mostrarDoc(rutaDoc);
            }
        }

        private void cb_autorizar_CheckedChanged(object sender, EventArgs e)
        {
            aprobado = true;
            estatus = "Autorizado";
            txt_observacionesRechazo.Enabled = false;
        }

        private void cb_rechazar_CheckedChanged(object sender, EventArgs e)
        {
            aprobado = false;
            estatus = "Rechazado";
            txt_observacionesRechazo.Enabled = true;
        }

        private void btn_guardarRegistro_Click(object sender, EventArgs e)
        {
            guardarEvaluacion();
        }

        public void guardarEvaluacion()
        {
            if (aprobado)
            {
                con.conectar();
                int resp = con.abc("EXEC proc_actualizarestatus " +
                        "@iduProspecto = " + idProspecto + "," +
                        "@estatus= '" + estatus + "';");
                if (resp == 1)
                {
                    MessageBox.Show("Se registro correctamente la evaluación");
                    flagGuardado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falló el registro de la evaluación");
                }
                con.closeConection();
            }
            else
            {
                if (txt_observacionesRechazo.Text == "" || txt_observacionesRechazo.Text == null)
                {
                    MessageBox.Show("Favor de llenar el campo de observaciones de rechazo");
                }
                else
                {
                    con.conectar();
                    int resp = con.abc("EXEC proc_guardarobservaciones " +
                            "@observaciones = '" + txt_observacionesRechazo.Text.Trim() + "'," +
                            "@iduProspecto = " + idProspecto + "," +
                            "@estatus= '"+estatus+"';");
                    if (resp == 1)
                    {
                        MessageBox.Show("Se registro correctamente la evaluación");
                        flagGuardado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falló el registro de la evaluación");
                    }
                    con.closeConection();
                }

            }
        }

        private void FormEvaluacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormListado f1 = new FormListado();
            f1.Visible = true;
            f1.llenarDGV();
        }

        private void FormEvaluacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagGuardado == false)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar la evaluación ? \n Perderá la información capturada sin guardar", "Cerrar Ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_cancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_documentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_documentos.Columns["Archivo"].Index)
            {
                mostrarDoc(Convert.ToString(dgv_documentos.Rows[e.RowIndex].Cells["Ruta"].Value).Trim());
            }
        }
    }
}
