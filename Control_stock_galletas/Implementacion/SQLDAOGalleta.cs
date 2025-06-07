using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_stock_galletas.Entidades;
using Control_stock_galletas.Interfaces;
using System.Data;
using System.Data.SqlClient;


namespace Control_stock_galletas.Implementacion
{
    public class SQLDAOGalleta : IGalletaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDBGalletas"].ConnectionString;
        
        private readonly string _cadenaConexion; // Usar cadena de conexión desde configuración o inyectada

        private Galleta MapearAGalleta(SqlDataReader reader)
        {
            var galleta = new Galleta
            {
                Cod_Galle = reader["Cod_Galle"].ToString(),
                Cod_Prod = reader["Cod_Prod"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Personaje = reader["Personaje"].ToString(),
                Gusto = reader["Gusto"].ToString(),
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                Cod_Ingre_Principal = reader["Cod_Ingre"] != DBNull.Value ? Convert.ToInt32(reader["Cod_Ingre"]) : (int?)null, // Campo renombrado en BD vs Entidad
                Segundo_Ingrediente = reader["Segundo_Ingrediente"] != DBNull.Value ? Convert.ToInt32(reader["Segundo_Ingrediente"]) : (int?)null
            };
            return galleta;
        }

        public List<Galleta> ObtenerTodas()
        {
            var lista = new List<Galleta>();
            string consulta = "SELECT Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente FROM Galleta ORDER BY Nombre";

            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    try
                    {
                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(MapearAGalleta(reader));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejar/Loguear excepción
                        Console.WriteLine($"SQL Error en ObtenerTodas (Galleta): {ex.Message}");
                        throw; // O manejar de otra forma
                    }
                }
            }
            return lista;
        }

        public Galleta ObtenerPorId(string codGalle)
        {
            Galleta galleta = null;
            string consulta = "SELECT Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente FROM Galleta WHERE Cod_Galle = @CodGalle";

            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@CodGalle", codGalle);
                    try
                    {
                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                galleta = MapearAGalleta(reader);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error en ObtenerPorId (Galleta): {ex.Message}");
                        throw;
                    }
                }
            }
            return galleta;
        }

        private List<Galleta> EjecutarConsultaBusqueda(string consultaBase, string parametroNombre, string valorParametro)
        {
            var lista = new List<Galleta>();
            string consulta = $"{consultaBase} WHERE {parametroNombre} LIKE @Valor ORDER BY Nombre";

            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@Valor", $"%{valorParametro}%");
                    try
                    {
                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(MapearAGalleta(reader));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error en búsqueda (Galleta): {ex.Message}");
                        throw;
                    }
                }
            }
            return lista;
        }

        public List<Galleta> ObtenerPorNombre(string nombre)
        {
            return EjecutarConsultaBusqueda("SELECT Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente FROM Galleta", "Nombre", nombre);
        }

        public List<Galleta> ObtenerPorPersonaje(string personaje)
        {
            return EjecutarConsultaBusqueda("SELECT Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente FROM Galleta", "Personaje", personaje);
        }

        public List<Galleta> ObtenerPorGusto(string gusto)
        {
            return EjecutarConsultaBusqueda("SELECT Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente FROM Galleta", "Gusto", gusto);
        }

        public bool Agregar(Galleta galleta)
        {
            string consulta = @"
                INSERT INTO Galleta (Cod_Galle, Cod_Prod, Nombre, Personaje, Gusto, Cantidad, Cod_Ingre, Segundo_Ingrediente)
                VALUES (@Cod_Galle, @Cod_Prod, @Nombre, @Personaje, @Gusto, @Cantidad, @Cod_Ingre_Principal, @Segundo_Ingrediente)";
            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@Cod_Galle", galleta.Cod_Galle);
                    cmd.Parameters.AddWithValue("@Cod_Prod", galleta.Cod_Prod);
                    cmd.Parameters.AddWithValue("@Nombre", galleta.Nombre);
                    cmd.Parameters.AddWithValue("@Personaje", galleta.Personaje);
                    cmd.Parameters.AddWithValue("@Gusto", galleta.Gusto);
                    cmd.Parameters.AddWithValue("@Cantidad", galleta.Cantidad);
                    cmd.Parameters.AddWithValue("@Cod_Ingre_Principal", (object)galleta.Cod_Ingre_Principal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Segundo_Ingrediente", (object)galleta.Segundo_Ingrediente ?? DBNull.Value);

                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error en Agregar (Galleta): {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Actualizar(Galleta galleta)
        {
            string consulta = @"
                UPDATE Galleta SET
                    Cod_Prod = @Cod_Prod,
                    Nombre = @Nombre,
                    Personaje = @Personaje,
                    Gusto = @Gusto,
                    Cantidad = @Cantidad,
                    Cod_Ingre = @Cod_Ingre_Principal,
                    Segundo_Ingrediente = @Segundo_Ingrediente
                WHERE Cod_Galle = @Cod_Galle";
            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@Cod_Prod", galleta.Cod_Prod);
                    cmd.Parameters.AddWithValue("@Nombre", galleta.Nombre);
                    cmd.Parameters.AddWithValue("@Personaje", galleta.Personaje);
                    cmd.Parameters.AddWithValue("@Gusto", galleta.Gusto);
                    cmd.Parameters.AddWithValue("@Cantidad", galleta.Cantidad);
                    cmd.Parameters.AddWithValue("@Cod_Ingre_Principal", (object)galleta.Cod_Ingre_Principal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Segundo_Ingrediente", (object)galleta.Segundo_Ingrediente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cod_Galle", galleta.Cod_Galle); // Importante para el WHERE

                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error en Actualizar (Galleta): {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Eliminar(string codGalle)
        {
            string consulta = "DELETE FROM Galleta WHERE Cod_Galle = @CodGalle";
            using (var con = new SqlConnection(_cadenaConexion))
            {
                using (var cmd = new SqlCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@CodGalle", codGalle);
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error en Eliminar (Galleta): {ex.Message}");
                        // Considerar FK constraints si otras tablas dependen de Galleta
                        return false;
                    }
                }
            }
        }

    }
}
