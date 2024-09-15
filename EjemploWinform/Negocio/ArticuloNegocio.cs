using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private List<Articulo> lista = new List<Articulo>();
        private List<Categoria> listaCategorias = new List<Categoria>();
        private List<Marca> listaMarcas = new List<Marca>();
        private SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;

        public ArticuloNegocio()
        {
            conexion = new SqlConnection("Server=localhost; Database=CATALOGO_P3_DB; User Id=sa; Password=Qqmelo#13");
            comando = new SqlCommand();
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setearConsulta("SELECT A.Id as IdArticulo, Codigo, Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca,C.Descripcion as Categoria, Precio, ImagenUrl, M.Id, C.Id \r\nFROM ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    if (!Convert.IsDBNull(datos.Lector["Marca"]))
                    {
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    }

                    aux.Categoria = new Categoria();
                    if (!Convert.IsDBNull(datos.Lector["Categoria"]))
                    {
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    


                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!Convert.IsDBNull(datos.Lector["ImagenUrl"]))
                    {
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    }
                   

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> ListarCodigoArticulo()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio, ImagenUrl FROM ARTICULOS A, MARCAS M , CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND I.IdArticulo = A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    aux.Precio = (decimal)lector["Precio"];


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void agregarArticulo(Articulo nuevoArticulo)
        {

            try
            {
                setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");

                setearParametro("@Codigo", nuevoArticulo.Codigo);
                setearParametro("@Nombre", nuevoArticulo.Nombre);
                setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                setearParametro("@Precio", nuevoArticulo.Precio);


                conexion.Close();
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarImagen(Articulo nuevoArticulo)
        {

            Articulo articulo = new Articulo();
            articulo = ListarArticulos().Last();

            try
            {


                int idArticulo = articulo.Id;
                setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                setearParametro("@IdArticulo", idArticulo);
                setearParametro("@ImagenUrl", nuevoArticulo.Imagen);

                conexion.Close();
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        public List<Articulo> listaParaImagenes()
        {
            List<Articulo> listaArticulos = ListarArticulos();

            if (listaArticulos != null && listaArticulos.Count > 0)
            {
                Dictionary<string, Articulo> diccionarioArticulos = new Dictionary<string, Articulo>();

                foreach (var articulo in listaArticulos)
                {
                    if (!diccionarioArticulos.ContainsKey(articulo.Codigo))
                    {
                        diccionarioArticulos.Add(articulo.Codigo, articulo);
                        articulo.Imagenes = new List<string>();
                    }
                    diccionarioArticulos[articulo.Codigo].Imagenes.Add(articulo.Imagen);
                }

                List<Articulo> listaParaDgv = diccionarioArticulos.Values.ToList();
                return listaParaDgv;
            }
            else
            {
                return new List<Articulo>();
            }
        }

        public void eliminarArticulo(int id)
        {
            try
            {
                AccesoDB datos = new AccesoDB();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarArticulo(Articulo articulo)
        {

            try
            {
                setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion WHERE Id = @Id");
                setearParametro("@Id", articulo.Id);
                setearParametro("@Codigo", articulo.Codigo);
                setearParametro("@Nombre", articulo.Nombre);
                setearParametro("@Descripcion", articulo.Descripcion);
                setearParametro("@Precio", articulo.Precio);
                conexion.Close();
                ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarCategoriaArticulo(Articulo articulo)
        {
            try
            {
                setearConsulta("UPDATE ARTICULOS SET IdCategoria = @IdCategoria WHERE Id = @IdArticulo");
                setearParametro("@IdArticulo", articulo.Id);
                setearParametro("@IdCategoria", articulo.Categoria.Id);
                conexion.Close();
                ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarMarcaArticulo(Articulo articulo)
        {
            try
            {
                setearConsulta("UPDATE ARTICULOS SET IdMarca = @IdMarca WHERE Id = @IdArticulo");
                setearParametro("@IdArt", articulo.Id);
                setearParametro("@IdMarca", articulo.Marca.Id);
                conexion.Close();
                ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarImagenArticulo(Articulo articulo)
        {
            try
            {
                setearConsulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl WHERE Id = (SELECT TOP 1 Id FROM IMAGENES WHERE IdArticulo = @IdA)");
                setearParametro("@IdA", articulo.Id);
                setearParametro("@ImagenUrl", articulo.Imagen);
                conexion.Close();
                ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
