using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeProspectos
{
    internal class Conexiones
    {
        //public SqlConnection Con = new SqlConnection();
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        public void conectar()
        {
            try
            {
                conexion = new SqlConnection("Data Source=LAP-WILL;Initial Catalog=pruebatecnica;Integrated Security=True");
                conexion.Open();


            }
            catch (Exception)
            {
                MessageBox.Show("no se conecto");
            }



        }

        public void closeConection()
        {
            conexion.Close();
        }

        public int abc(String query)
        {
            try
            {
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public SqlDataReader leer(String query)
        {
            cmd = new SqlCommand(query, conexion);
            dr = cmd.ExecuteReader();
            return dr;
        }

        /*public int consultaId(String query)
        {
            try
            {
                cmd = new SqlCommand(query, conexion);
                if (cmd.ExecuteScalar().ToString() == "")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                return 0;
            };

        }*/

        public void soloLetras(KeyPressEventArgs v)
        {
            if (!char.IsLetter(v.KeyChar) && !char.IsWhiteSpace(v.KeyChar) && v.KeyChar != '\b')
            {
                v.Handled = true;
            }
        }

        public void soloNumeros(KeyPressEventArgs v)
        {
            if (!char.IsDigit(v.KeyChar) && v.KeyChar != '\b')
            {
                v.Handled = true;
            }
        }

        public void soloAlfanumericos(KeyPressEventArgs v)
        {
            if (!char.IsLetterOrDigit(v.KeyChar) && v.KeyChar != '\b' && !char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = true;
            }
        }

    }
}
