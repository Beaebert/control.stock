using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_stock_galletas.Entidades
{
    public class Galleta
    {
        public string Cod_Galle { get; set; }    // Primary Key (PK) de Galleta
        public string Cod_Prod { get; set; }     // Foreign Key a Producto
        public string Nombre { get; set; }       // Nombre específico de la galleta
        public string Personaje { get; set; }    // Personaje específico de la galleta
        public string Gusto { get; set; }        // Gusto específico de la galleta
        public int Cantidad { get; set; }        // Stock de esta galleta

        // FKs a la tabla Ingrediente (Cod_Ingre es PK de Ingrediente)
        // Representan ingredientes destacados. 
        public int? Cod_Ingre_Principal { get; set; }
        public int? Segundo_Ingrediente { get; set; }

        public Galleta()
        {
            // Constructor por defecto
        }
    }
}
