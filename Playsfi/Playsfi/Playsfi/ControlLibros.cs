using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playsfi
{
    public partial class ControlLibros : Form
    {
        //controles/variables comunes
        int idU;//esta variable recoge el id de usuario que le pasan en el constructor y se lo pasará a todos los métodos que lo necesiten
        string cadena = "Data Source=C06PC29\\SQLEXPRESS;Initial Catalog=playsfi;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public ControlLibros(int idUser)
        {
            InitializeComponent();
            con = new SqlConnection(cadena);
            con.Open();
            idU = idUser;

            //llenar tablas
            llenarTablaLibros();
            llenarDescatalogados();
            llenarFavs();

            //llenar los txt del user
            llenarCamposUser();

            //llenar los comboBox de título y autor
            llenarComboTitulo();
            llenaAutor();
            llenarComboFavs();
        }

        private void llenarComboTitulo()
        {
            // Limpiamos los elementos previos de los ComboBox
            cmbTituloBorrar.Items.Clear();
            cmbTituloFav.Items.Clear();
            cmbTituloModificar.Items.Clear();
            cmbTituloBusca.Items.Clear();

            // Consulta para obtener los títulos de los libros
            string consulta = "SELECT titulo FROM Libros WHERE user_id = @idU";
            cmd = new SqlCommand(consulta, con);
            cmd.Parameters.AddWithValue("@idU", idU);
            SqlDataReader lector = cmd.ExecuteReader();

            // Iteramos sobre los resultados de la consulta
            while (lector.Read())
            {
                // Agregamos cada título al ComboBox
                string titulo = lector["titulo"].ToString();
                cmbTituloBorrar.Items.Add(titulo);
                cmbTituloFav.Items.Add(titulo);
                cmbTituloModificar.Items.Add(titulo);
                cmbTituloBusca.Items.Add(titulo);
            }
            lector.Close();

        }


        //métodos de botones        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Para evitar errores cierro y abro la conexión al principio de los métodos
            con.Close();
            con.Open();

            //el id libro es el número siguiente al último de la bd
            string query = "SELECT ISNULL(MAX(libro_id),0) FROM Libros";
            cmd = new SqlCommand(query, con);
            //recoger el valor de la consulta
            int nextId = Convert.ToInt32(cmd.ExecuteScalar()) +1;//lo casteamos

            //almacenar datos
            int? isbn = null;
            isbn = int.Parse(txtIsbn.Text);
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string categoria = txtCategoria.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(categoria) || isbn == null)
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
                //comando de inserción
                string insert = "INSERT INTO Libros VALUES ("+ nextId + ", "+idU+", "+isbn+", '"+titulo+"', '"+autor+"', '"+categoria+"')";
                //insertamos
                cmd = new SqlCommand(insert, con);

                //comprobamos inserción
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Inserción realizada correctamente, tabla actualizada", "Acción: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarTablaLibros();
                    llenarComboTitulo();
                    llenaAutor();
                }
                else {
                    MessageBox.Show("Inserción NO realizada correctamente, tabla no actualizada", "Acción:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        private void btnSeVa_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            //recogiendo el título del libro que se va a borrar
            string titulo = cmbTituloBorrar.Text.Trim();

            //actualizamos tabla descatalogados insertando el libro descatalogado con todos sus datos
            //recoger los datos
            
            //Para el id saca el siguiente al mayor de la tabla
            string idSiguiente = "SELECT ISNULL(MAX(borrado_id),0) FROM Descatalogados";
            cmd = new SqlCommand(idSiguiente, con);
            int nextId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                

            //titulo ya está recogido y id de usuario tambien
            DateTime hoy = DateTime.Now;//la fecha de´el día actual que es el día que se borra
            string razon = txtRazon.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(razon))
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
            //realizar la inserción
                string insert = "INSERT INTO Descatalogados VALUES (@idBorrado, @idUsuario, @titulo, @fecha, @razon)";
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@idBorrado", nextId);
                cmd.Parameters.AddWithValue("@idUsuario", idU);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@fecha", hoy);
                cmd.Parameters.AddWithValue("@razon", razon);

                // Ejecutar la consulta de inserción
                cmd.ExecuteNonQuery();
                //actualizar tabla
                llenarDescatalogados();

                //consulta para borrar el libro con ese título
                string borrado = "DELETE FROM Libros WHERE titulo='" + titulo + "'";

                //borramos
                cmd = new SqlCommand(borrado, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Borrado realizado correctamente, tablas libros y descatalogados actualizadas", "Acción: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //actualizar tabla libros
                llenarTablaLibros();
                //actualizar el combo box
                llenarComboTitulo();
                llenaAutor();
            }
                
            
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //aquí añadimos libros a la tabla favoritos
            //recogo el título y la nota
            string titulo = cmbTituloFav.Text.Trim();
            int? nota = null;
            nota = Convert.ToInt32(txtNota.Text.Trim());

            //otros datos de favoritos
            //el id de favorito es el id de libro, lo recojo consultandole a la tabla libros
            string idFav = "SELECT libro_id FROM Libros WHERE titulo = @titulo";
            cmd = new SqlCommand(idFav, con);
            cmd.Parameters.AddWithValue("@titulo",titulo);
            int nextId = Convert.ToInt32(cmd.ExecuteScalar());

            DateTime hoy = DateTime.Now;//la fecha de el día actual

            if (string.IsNullOrEmpty(titulo) || nota == null)
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
                //añado el libro a la tabla favoritos
                string insert = "INSERT INTO Favoritos VALUES (@favId, @titulo, @fecha, @nota, @userId)";
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@favId", nextId);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@fecha", hoy);
                cmd.Parameters.AddWithValue("@nota",nota);
                cmd.Parameters.AddWithValue("@userId",idU);

                //ejecutar inserción
                cmd.ExecuteNonQuery();

                //actualizar tabla
                llenarFavs();

                //actualizar combo box
                llenarComboFavs();
            } 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //aquí modificaremos un campo del libro según el que esté lleno
            //recojo los datos
            string titulo = cmbTituloModificar.Text.Trim();
            int isbn = Convert.ToInt32(txtIsbnCambio.Text.Trim());
            string autor = txtAutorCambio.Text.Trim();
            string categoria = txtCategoriaCambio.Text.Trim();

            //identifico los campos llenos
            
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("No has insertado el título", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }//hago los updates necesarios
            else if (isbn>0 && !string.IsNullOrEmpty(titulo))
            {
                string cambioTipo1 = "UPDATE Libros SET isbn = @isbn WHERE titulo = @titulo";
                cmd = new SqlCommand(cambioTipo1, con);
                cmd.Parameters.AddWithValue("@isbn",isbn);
                cmd.Parameters.AddWithValue("@titulo",titulo);
            }
            else if (!string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(titulo))
            {
                string cambioTipo2 = "UPDATE Libros SET autor = @autor WHERE titulo = @titulo";
                cmd = new SqlCommand(cambioTipo2, con);
                cmd.Parameters.AddWithValue("@autor", autor);
                cmd.Parameters.AddWithValue("@titulo", titulo);
            }
            else if (!string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(titulo))
            {
                string cambioTipo3 = "UPDATE Libros SET categoría = @categoria WHERE titulo = @titulo";
                cmd = new SqlCommand(cambioTipo3, con);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                
            }

            //ejecutar update
            cmd.ExecuteNonQuery ();
            //actualizar tabla libros
            llenarTablaLibros();
            MessageBox.Show("Actualiización realizada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //actualizar combo box
            llenaAutor();
            llenarComboTitulo();

        }

        private void btnTodosCambian_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //aquí modificamos todos los campos 
            //recojo los datos
            string titulo = cmbTituloModificar.Text.Trim();
            int isbn = Convert.ToInt32(txtIsbnCambio.Text.Trim());
            string autor = txtAutorCambio.Text.Trim();
            string categoria = txtCategoriaCambio.Text.Trim();

            //identifico los campos llenos
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("No has insertado el título", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else {
                if (string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(categoria))
                {
                    MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else { 
                    //hago el update
                    string cambioTotal = "UPDATE Libros SET isbn = @isbn, autor = @autor, categoría = @categoria WHERE titulo = @titulo";
                    cmd = new SqlCommand(cambioTotal, con);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@titulo", titulo);

                    //aviso
                    MessageBox.Show("Actualiización realizada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //ejecutar update
                    cmd.ExecuteNonQuery();

                    //actualizar tabla libros
                    llenarTablaLibros();

                    //actualizar combo box
                    llenaAutor();
                    llenarComboTitulo();
                }
                
            }

            
        }

        private void btnUnCampo_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //aquí modificaremos un campo del usuario según el que esté lleno
            //recojo los datos
            string nombre = txtNomUser.Text.Trim();
            string ape = txtApeUser.Text.Trim();
            string dni = txtDniUser.Text.Trim();
            string edad = txtEdadUser.Text.Trim();

            //identifico los campos llenos y hago los updates necesarios
            if (!string.IsNullOrEmpty(dni)) 
            {
                string cambioDni = "UPDATE Usuario SET dni = @dni WHERE id_user=@idU";
                cmd= new SqlCommand(cambioDni, con);
                cmd.Parameters.AddWithValue("@dni",dni);
                cmd.Parameters.AddWithValue("@idU", idU);
            }
            else if (!string.IsNullOrEmpty(ape))
            {
                string cambioApe = "UPDATE Usuario SET apellidos = @ape WHERE id_user=@idU";
                cmd = new SqlCommand(cambioApe, con);
                cmd.Parameters.AddWithValue("@ape", ape);
                cmd.Parameters.AddWithValue("@idU", idU);
            }
            else if (!string.IsNullOrEmpty(nombre)) 
            {
                string cambioNom = "UPDATE Usuario SET nombre = @nom WHERE id_user=@idU";
                cmd = new SqlCommand(cambioNom, con);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@idU", idU);
            }
            else if (!string.IsNullOrEmpty(edad)) 
            {
                string cambioEdad = "UPDATE Usuario SET edad = @edad WHERE id_user=@idU";
                cmd = new SqlCommand(cambioEdad, con);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@idU", idU);
            }
            //ejecutar update
            cmd.ExecuteNonQuery();
            //aviso
            MessageBox.Show("Actualiización realizada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void llenarCamposUser() {
            //esté método llena los txt del usuario con los datos de esté recogidos por consultas
            //hacemos las consultas
            string nombreConsulta = "SELECT nombre FROM Usuario WHERE id_user = @idU";
            string apellidosConsulta = "SELECT apellidos FROM Usuario WHERE id_user = @idU";
            string edadConsulta = "SELECT edad FROM Usuario WHERE id_user = @idU";
            string dniConsulta = "SELECT dni FROM Usuario WHERE id_user = @idU";
           
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idU", idU);

            // ejecuto las consultas y obtengo los datos
            cmd.CommandText = nombreConsulta;
            string nombre = cmd.ExecuteScalar() as String;

            cmd.CommandText = apellidosConsulta;
            string apellidos = cmd.ExecuteScalar() as String;

            cmd.CommandText = edadConsulta;
            int edad = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = dniConsulta;
            string dni = cmd.ExecuteScalar() as String;

            // Mostrar los resultados en los TextBox
            txtNomUser.Text = nombre;
            txtApeUser.Text = apellidos;
            txtEdadUser.Text = edad.ToString();
            txtDniUser.Text = dni;
        }

        private void btnTCampos_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //aquí modificamos todos los campos del usuario
            //recojo los datos
            string nombre = txtNomUser.Text.Trim();
            string ape = txtApeUser.Text.Trim();
            string dni = txtDniUser.Text.Trim();
            int edad = Convert.ToInt32(txtEdadUser.Text.Trim());

            //hago el update
            string update = "UPDATE Usuario SET dni = @dni, apellidos = @ape, nombre = @nom, edad = @edad WHERE id_user=@idU";
            cmd = new SqlCommand(update, con);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@ape", ape);
            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@edad", edad);
            cmd.Parameters.AddWithValue("@idU", idU);
            cmd.ExecuteNonQuery();

            //aviso
            MessageBox.Show("Actualiización realizada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //para llenar las tablas no uso los métodos del data grid view
        //ya que necesitaré realizar está acción cuando se inicie la pantalla
        //y cada vez que se actualice cada tabla
        private void llenarTablaLibros()
        { 
            // Consulta SQL para obtener los libros del usuario
            string query = "SELECT * FROM Libros WHERE user_id =" + idU;
            cmd = new SqlCommand(query, con);

            // Crear un adaptador de datos y un DataSet para llenar los datos en el DataGridView
            adapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();
            adapter.Fill(dataSet);

            // Asignar el DataSet al DataGridView
            dtgLibros.DataSource = dataSet.Tables[0];
        }

        
        private void llenarDescatalogados() {
            //consulta para obtener los descatalogados de ese usuario
            string query = "SELECT * FROM Descatalogados WHERE usuario_id =" + idU;
            cmd = new SqlCommand(query, con);

            // Crear un adaptador de datos y un DataSet para llenar los datos en el DataGridView
            adapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();
            adapter.Fill(dataSet);

            // Asignar el DataSet al DataGridView
            dtgBorrados.DataSource = dataSet.Tables[0];
        }

        private void llenarFavs() {
            //consulta para obtener los favoritos de ese usuario
            string favs = "SELECT * FROM Favoritos WHERE usuario_id = @idU";
            cmd = new SqlCommand(favs, con);
            cmd.Parameters.AddWithValue("@idU", idU);

            //un adaptador y un data set para llenar la tbala 
            adapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();
            adapter.Fill(dataSet);

            //metemos el dataSet al dataGrid
            dtgFavs.DataSource = dataSet.Tables[0];
        }

        private void informeDeFavorítosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes i = new Informes();
            i.Show();
            i.informeFavs();
        }

        private void informePorCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes i = new Informes();
            i.Show();
            i.informeCats();
        }

        private void informeDeDescatalogádosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes i = new Informes();
            i.Show();
            i.informeDescat();
        }

        private void btnBuscaTtulo_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //recoge el título
            string titul = cmbTituloBusca.Text.Trim();

            if (string.IsNullOrEmpty(titul))
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { 
                //realiza la consulta 
                string busca = "SELECT * FROM Libros WHERE titulo = @titulo";
                cmd = new SqlCommand(busca, con);
                cmd.Parameters.AddWithValue("@titulo",titul);
                cmd.ExecuteNonQuery();

                //muestra el resultado en el text box
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    // Borra el texto existente en el cuadro de texto
                    txtBusqueda.Text = "";

                    // Itera a través de los resultados y muéstralos en el cuadro de texto
                    while (reader.Read()) {
                        //recojo los datos de la consulta
                        string libroId = reader["libro_id"].ToString();
                        string idUser = reader["user_id"].ToString();    
                        string isbn = reader["isbn"].ToString();
                        string tituloLibro = reader["titulo"].ToString();
                        string autor = reader["autor"].ToString();
                        string cat = reader["categoría"].ToString();

                        // Construye una cadena con los detalles del libro
                        string detallesLibro = $"El libro con título: {tituloLibro}, " + 
                            $"Tiene el id: {libroId}, " + 
                            $"El usuario que lo tiene registrado es: {idUser}, " + 
                            $"Su isbn es: {isbn}"+ 
                            $"El autor es: {autor}" +
                            $"Y sú categoría es: {cat}";

                        // Agrega los detalles al cuadro de texto, separados por una nueva línea
                        txtBusqueda.Text += detallesLibro + Environment.NewLine;
                        
                    }
                    reader.Close();

                }
            }

            
        }

        public void llenaAutor() {
            con.Close();
            con.Open();
            // Limpiamos los elementos previos del ComboBox
            cmbAutores.Items.Clear();

            // Consulta para obtener los títulos de los autores
            string query = "SELECT autor FROM Libros WHERE user_id=@idU";
            cmd= new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idU",idU);
            SqlDataReader reader = cmd.ExecuteReader();

            // Iteramos sobre los resultados de la consulta
            while (reader.Read())
            {
                //recojo el autor y lo añado al cmb
                string autor = reader["autor"].ToString() ;
                cmbAutores.Items.Add(autor);
            }
            reader.Close();

        }

        public void llenarComboFavs() { 
            con.Close(); 
            con.Open();
            // Limpiamos los elementos previos del ComboBox
            cmbBusca.Items.Clear();

            // Consulta para obtener los títulos favs
            string query = "SELECT titulo FROM Favoritos WHERE usuario_id=@idU";
            cmd= new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idU", idU);
            SqlDataReader reader = cmd.ExecuteReader();

            //iteramos sobre los resultados
            while (reader.Read()) {
                //recojo el título y lo añado
                string titulo = reader["titulo"].ToString();
                cmbBusca.Items.Add(titulo);
            }
            reader.Close();
        }

        private void btnBuscaAutor_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //recoge el autor
            string autor = cmbAutores.Text.Trim();


            if (string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //realiza la consulta
                string busca = "SELECT * FROM Libros WHERE autor = @autor";
                cmd = new SqlCommand(busca, con);
                cmd.Parameters.AddWithValue("@autor", autor);
                cmd.ExecuteNonQuery();

                //muestra el resultado
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    // Borra el texto existente en el cuadro de texto
                    txtBusqueda.Text = " ";
                    // Itera a través de los resultados y muéstralos en el cuadro de texto
                    while (lector.Read())
                    {
                        //recojo los datos de la consulta
                        string libroId = lector["libro_id"].ToString();
                        string userId = lector["user_id"].ToString();
                        string isbn = lector["isbn"].ToString();
                        string titulo = lector["titulo"].ToString();
                        string auto = lector["autor"].ToString();
                        string cate = lector["categoría"].ToString();

                        // Construye una cadena con los detalles del libro
                        string cadena = $"El o los libros del autor {auto} son: {titulo} " +
                            $"El id del libro es: {libroId}" +
                            $"Lo tienen los usuarios con id: {userId}" +
                            $"Su isbn es: {isbn}" +
                            $"Su categoría es: {cate}";

                        // Agrega los detalles al cuadro de texto, separados por una nueva línea
                        txtBusqueda.Text += cadena + Environment.NewLine;
                    }
                    lector.Close();
                }
            }

                
        }

        private void btnBuscaFav_Click(object sender, EventArgs e)
        {
            string busca = cmbBusca.Text.Trim();

            // Verificar si el cuadro de búsqueda está vacío
            if (string.IsNullOrEmpty(busca)) {
                // Si está vacío, mostrar todas las filas
                dtgFavs.ClearSelection();
                return;
            }

            // Iterar a través de las filas del DataGridView para buscar el texto
            foreach (DataGridViewRow row in dtgFavs.Rows) {
                // Verificar si la celda "Titulo" existe y no es null
                if (row.Cells["titulo"].Value != null)
                {
                    // Comparar el valor de la columna "titulo" con el texto de búsqueda
                    string titul = row.Cells["titulo"].Value.ToString().ToLower();//error
                    if (titul.Contains(busca))
                    {
                        // Si el titulo contiene el texto de búsqueda, seleccionar la fila
                        row.Selected = true;
                    }
                    else
                    {
                        // De lo contrario, deseleccionar la fila
                        row.Selected = false;
                    }
                }
                    
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string ruta = "G:\\23-24\\interfaces\\Proyecto\\GuiaUsuarioPlaysfi.chm";
            // Verifica si la ruta existe antes de intentar abrirla
            if (System.IO.Directory.Exists(ruta))
            {
                try
                {
                    Process.Start(ruta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la ruta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
