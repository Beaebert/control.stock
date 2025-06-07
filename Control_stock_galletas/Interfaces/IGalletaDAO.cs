using Control_stock_galletas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_stock_galletas.Interfaces
{
    public interface IGalletaDAO
    {
        List<Galleta> ObtenerTodas();
        Galleta ObtenerPorId(string codGalle);
        List<Galleta> ObtenerPorNombre(string nombre);
        List<Galleta> ObtenerPorPersonaje(string personaje);
        List<Galleta> ObtenerPorGusto(string gusto);
        bool Agregar(Galleta galleta);
        bool Actualizar(Galleta galleta);
        bool Eliminar(string codGalle);
    }
}