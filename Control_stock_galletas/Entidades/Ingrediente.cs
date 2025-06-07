using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_stock_galletas.Entidades
{
    public class Ingrediente
    {
        public string Cod_Ingre { get; set; }    // Primary Key (PK) de Ingrediente
        public string Nombre { get; set; }       // Nombre del Ingrediente
        public int Cantidad { get; set; }        // Stock del Ingrediente
        public string Cod_Galle { get; set; }    // Foreign Key a Galleta (Cod_Galle es PK de Galleta)

        public Ingrediente()
        {
            // Constructor por defecto
        }
    }
}
