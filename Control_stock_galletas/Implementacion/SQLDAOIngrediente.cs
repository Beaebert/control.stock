using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Control_stock_galletas.Entidades;
using Control_stock_galletas.Interfaces;

namespace Control_stock_galletas.Implementacion
{
    public class SQLDAOIngrediente : IIngredienteDAO
    {
        private readonly string _cadenaConexion;

        public SQLDAOIngrediente()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionDBGalletas"].ConnectionString;
        }

        public List<Ingrediente> ObtenerTodos()
        {
            var lista = new List<Ingrediente>();
            string consulta = "SELECT Cod_Ingre, Nombre, Stock, Unidad FROM Ingrediente";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAIngrediente(reader));
                    }
                }
            }
            return lista;
        }

        public Ingrediente ObtenerPorId(int codIngre)
        {
            Ingrediente ingrediente = null;
            string consulta = "SELECT Cod_Ingre, Nombre, Stock, Unidad FROM Ingrediente WHERE Cod_Ingre = @CodIngre";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@CodIngre", codIngre);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ingrediente = MapearAIngrediente(reader);
                    }
                }
            }
            return ingrediente;
        }

        public List<Ingrediente> ObtenerPorNombre(string nombre)
        {
            var lista = new List<Ingrediente>();
            string consulta = "SELECT Cod_Ingre, Nombre, Stock, Unidad FROM Ingrediente WHERE Nombre LIKE @Nombre";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", $"%{nombre}%");
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAIngrediente(reader));
                    }
                }
            }
            return lista;
        }

        public List<Ingrediente> ObtenerPorGalleta(string codGalle)
        {
            var lista = new List<Ingrediente>();
            string consulta = @"
                SELECT i.Cod_Ingre, i.Nombre, i.Stock, i.Unidad
                FROM Ingrediente i
                INNER JOIN Galleta g ON i.Cod_Ingre = g.Cod_Ingre OR i.Cod_Ingre = g.Segundo_Ingrediente
                WHERE g.Cod_Galle = @CodGalle";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@CodGalle", codGalle);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearAIngrediente(reader));
                    }
                }
            }
            return lista;
        }

        public void Actualizar(Ingrediente ingrediente)
        {
            string consulta = "UPDATE Ingrediente SET Nombre = @Nombre, Stock = @Stock WHERE Cod_Ingre = @CodIngre";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", ingrediente.Nombre);
                cmd.Parameters.AddWithValue("@Stock", ingrediente.Cantidad);
                cmd.Parameters.AddWithValue("@CodIngre", ingrediente.Cod_Ingre);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarStockPorNombre(string nombreIngrediente, decimal nuevoStock)
        {
            string consulta = "UPDATE Ingrediente SET Stock = @Stock WHERE Nombre = @Nombre";
            using (var con = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Stock", nuevoStock);
                cmd.Parameters.AddWithValue("@Nombre", nombreIngrediente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private Ingrediente MapearAIngrediente(SqlDataReader reader)
        {
            return new Ingrediente
            {
                Cod_Ingre = reader["Cod_Ingre"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Cantidad = Convert.ToInt32(reader["Stock"]),
                Cod_Galle = null // O asigna el valor adecuado si corresponde
            };
        }
    }
}
