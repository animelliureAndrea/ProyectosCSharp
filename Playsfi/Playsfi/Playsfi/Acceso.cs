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

namespace Playsfi
{
    public partial class Acceso : Form
    {
        //cadena de conexión
        //cadena de conexion en casa = Data Source=FCMPORT2-WIN10;Initial Catalog=playsfi;Integrated Security=True
        //cadena de conexion en clase = Data Source=C06PC29\SQLEXPRESS;Initial Catalog=playsfi;Integrated Security=True
        string cadena = "Data Source=C06PC29\\SQLEXPRESS;Initial Catalog=playsfi;Integrated Security=True";
        //creamos el objeto conexión 
        SqlConnection conn;

        public Acceso()
        {
            InitializeComponent();
        }


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(cadena);

            //obtener nombre introducido
            string dni = txtDni.Text.Trim();

            //comprobar que no esté vacío
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Introduce un DNI para poder continuar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //abrimos la conexión
            conn.Open();

            //objeto comando
            SqlCommand comando = new SqlCommand();
            //consulta sql
            //comando.Parameters.AddWithValue("@dni", dni);
            comando.CommandText = "select * from Usuario where dni = '"+dni+"'";

            //asocio la conexion al comando
            comando.Connection = conn;
            
            //ejecutar la consulta y obtengo el número de registros afectados
            SqlDataReader resultado = comando.ExecuteReader();
            if (resultado.HasRows)
            {
                // Obtener el ID del usuario
                int idUser = ObtenerIdUser(resultado);
                // Si hay resultados, accedemos al control de libros pasando el ID del usuario
                ControlLibros cl = new ControlLibros(idUser);
                cl.Show();
                this.Close();
            }
            else {
                // si no, accedemos al registro de usuarios
                Registro r = new Registro();
                r.Show();
                this.Close();
            }
            conn.Close(); 
        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cadena);
        }

        // Método para obtener el ID del usuario a partir del SqlDataReader
        private int ObtenerIdUser(SqlDataReader resultado) {
            int idUsuario = -1;//valor por defecto
            if (resultado.HasRows)
            {
                // Leer el primer registro (suponiendo que solo habrá uno)
                if (resultado.Read())
                {
                    idUsuario = resultado.GetInt32(resultado.GetOrdinal("id_user"));
                }
            }
            return idUsuario;
        }
    }
}
