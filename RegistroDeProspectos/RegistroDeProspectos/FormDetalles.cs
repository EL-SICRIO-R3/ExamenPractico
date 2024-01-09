using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RegistroDeProspectos
{
    public partial class FormDetalles : Form
    {
        Conexiones con = new Conexiones();
        SqlDataReader dr;
        string rutaDoc;
        public FormDetalles()
        {
            InitializeComponent();

        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
           
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (rutaDoc != null && rutaDoc != "")
            {
                mostrarDoc(rutaDoc);
            }
        }

        public void llenarDatos(int id)
        { 
            con.conectar();
            dr = con.leer("EXEC proc_obtenerprospectoporid @id="+id+";");
            if (dr.Read())
            {
                lbl_nombre.Text = Convert.ToString(dr["nom_prospecto"]);
                lbl_primerApellido.Text= Convert.ToString(dr["des_apellidoPaterno"]);
                lbl_segundoApelido.Text = Convert.ToString(dr["des_apellidoMaterno"]);
                lbl_calle.Text = Convert.ToString(dr["nom_calle"]);
                lbl_numCasa.Text = Convert.ToString(dr["num_casa"]);
                lbl_colonia.Text = Convert.ToString(dr["nom_colonia"]);
                lbl_codigoPostal.Text = Convert.ToString(dr["num_codigoPostal"]);
                lbl_telefono.Text = Convert.ToString(dr["num_telefono"]);
                lbl_rfc.Text = Convert.ToString(dr["des_rfc"]);
                lbl_estatus.Text = Convert.ToString(dr["des_estatus"]);
                if(Convert.ToString(dr["des_observacion"]) != null && Convert.ToString(dr["des_observacion"]) != "")
                {
                    lbl_observacionesRechazo.Text = Convert.ToString(dr["des_observacion"]);
                }

            }
            dr.Close();
            con.closeConection();
        }

        public void llenarDgvDocumentos(int id)
        {
            con.conectar();
            dr = con.leer("EXEC proc_obtenerdocumentosporprospecto @id="+id+";");
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
                MessageBox.Show("Ocurrió un error al intentar visualizar el documento, verifique que el documento sigue en " +
                    "la ruta registrada");
            }
        }

        private void lbl_observacionesRechazo_Click(object sender, EventArgs e)
        {

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
