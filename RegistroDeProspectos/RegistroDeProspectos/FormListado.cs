using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeProspectos
{
    public partial class FormListado : Form
    {
        SqlDataReader dr;
        Conexiones con = new Conexiones();
        
        public FormListado()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarDGV();
            
        }



        

        public void llenarDGV()
        {
            con.conectar();
            dr = con.leer("EXEC proc_obtenerprospectoslistado;");
            dgv_prospectos.Rows.Clear();
            while (dr.Read() == true)
            {
                dgv_prospectos.Rows.Add(dr["idu_prospecto"],dr["nom_prospecto"], dr["des_apellidoPaterno"], dr["des_apellidoMaterno"], dr["des_estatus"],"Detalles","Evaluar");
            }
            dr.Close();
            con.closeConection();
        }



        private void btn_abrirForm_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
            this.Visible=false;
        }

        private void dgv_prospectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_prospectos.Columns["Evaluar"].Index)
            {
                if (Convert.ToString(dgv_prospectos.Rows[e.RowIndex].Cells["Estatus"].Value).Trim() == "Enviado")
                {
                    FormEvaluacion fe = new FormEvaluacion();
                    fe.Show();
                    this.Visible = false;
                    fe.llenarDatos(Convert.ToInt32(dgv_prospectos.Rows[e.RowIndex].Cells["ID"].Value));
                    fe.llenarDgvDocumentos(Convert.ToInt32(dgv_prospectos.Rows[e.RowIndex].Cells["ID"].Value));

                }
                else
                {
                    MessageBox.Show("Este prospecto ya fué evalueado");
                }
                
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_prospectos.Columns["Detalles"].Index)
            {
                FormDetalles fd = new FormDetalles();
                fd.Show();
                fd.llenarDatos(Convert.ToInt32(dgv_prospectos.Rows[e.RowIndex].Cells["ID"].Value));
                fd.llenarDgvDocumentos(Convert.ToInt32(dgv_prospectos.Rows[e.RowIndex].Cells["ID"].Value));

            }
        }

        private void FormListado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación? ", "Cerrar Formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormListado_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
