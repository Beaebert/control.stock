using System.Collections.Generic;
using Control_stock_galletas.Entidades;

namespace Control_stock_galletas.Interfaces
{
    public interface IIngredienteDAO
    {
        List<Ingrediente> ObtenerTodos();
        Ingrediente ObtenerPorId(int codIngre);
        List<Ingrediente> ObtenerPorNombre(string nombre);
        List<Ingrediente> ObtenerPorGalleta(string codGalle);
        void Actualizar(Ingrediente ingrediente);
        void ActualizarStockPorNombre(string nombreIngrediente, decimal nuevoStock);
    }
}
