using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_stock_galletas.Ventanas; //Para poder acceder al formulario del menú principal
using Control_stock_galletas.Interfaces;
using Control_stock_galletas.Implementacion;
using Control_stock_galletas.Entidades;

namespace Control_stock_galletas.Ventanas
{
    public partial class StockIngredientes : Form
    {
        // Agregar una referencia al formulario del menú principal
        private MenuGalletas menuGalletas;

        private readonly IIngredienteDAO _ingredienteDAO = new SQLDAOIngrediente();

        private TextBox txtValorBusquedaIngre; // Declaración del control faltante

        public StockIngredientes(MenuGalletas menuGalletas)
        {
            InitializeComponent();
            this.menuGalletas = menuGalletas; // Inicializar la referencia al formulario del menú principal
            txtValorBusquedaIngre = new TextBox(); // Inicialización del control
            CargarTodosLosIngredientes();
            this.Load += new System.EventHandler(this.StockIngredientes_Load);
        }

        public StockIngredientes()
        {
        }

        private void BotonIngrediVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario, el metodo siguiente muestra nuevamente el formulario del menú principal
        }

        private void StockIngredientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Usar la referencia de objeto 'menuGalletas' en lugar de 'MenuGalletas'
            if (menuGalletas != null && !menuGalletas.IsDisposed)
            {
                menuGalletas.Show(); // Muestra el formulario del menú principal
            }
        }

        private void StockIngredientes_Load(object sender, EventArgs e)
        {
            CargarTodosLosIngredientes();
        }

        private void CargarTodosLosIngredientes()
        {
            try
            {
                dgvIngredientes.DataSource = null;
                var lista = _ingredienteDAO.ObtenerTodos();
                dgvIngredientes.DataSource = lista;
                // Puedes ajustar los encabezados de columna aquí si lo deseas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ingredientes: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarIngredientes_Click(object sender, EventArgs e)
        {
            string criterio = cmbCriterioBusquedaIngre.SelectedItem?.ToString();
            string valor = txtValorBusquedaIngre.Text.Trim();

            try
            {
                List<Ingrediente> resultadoBusqueda = new List<Ingrediente>();
                switch (criterio)
                {
                    case "Nombre":
                        resultadoBusqueda = _ingredienteDAO.ObtenerPorNombre(valor);
                        break;
                    case "Código Ingrediente": // Busca por PK de la tabla Ingrediente (Cod_Ingre)
                        if (int.TryParse(valor, out int codIngre))
                        {
                            Ingrediente ing = _ingredienteDAO.ObtenerPorId(codIngre);
                            if (ing != null) resultadoBusqueda.Add(ing);
                        }
                        else
                        {
                            MessageBox.Show("El código de ingrediente debe ser un número entero válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "Código Galleta": // Busca todas las filas de Ingrediente asociadas a este Cod_Galle
                        resultadoBusqueda = _ingredienteDAO.ObtenerPorGalleta(valor);
                        break;
                }

                dgvIngredientes.DataSource = null;
                if (resultadoBusqueda != null && resultadoBusqueda.Any())
                {
                    dgvIngredientes.DataSource = resultadoBusqueda;
                    // Si la búsqueda es por "Código Ingrediente" o "Código Galleta",
                    // es probable que devuelva filas "raw", así que ajustamos columnas para esa vista.
                    if (criterio == "Código Ingrediente" || criterio == "Código Galleta")
                    {
                        AjustarColumnasDgvRaw();
                    }
                    else // Si es por nombre, podríamos querer la vista consolidada (más complejo aquí) o raw.
                    {
                        AjustarColumnasDgvRaw(); // Por simplicidad, mostramos raw.
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias para su búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposEdicionStock();
        }

        private void btnMostrarTodosIngredientes_Click(object sender, EventArgs e)
        {
            CargarVistaConsolidadaIngredientes();
            LimpiarCamposBusqueda();
            LimpiarCamposEdicionStock();
        }

        private void LimpiarCamposEdicionStock()
        {
            //txtCantidadIngrediente.Value = 0;
            // txtIngredienteSeleccionado.Clear();
        }

        private void LimpiarCamposBusqueda()
        {
            // txtValorBusquedaIngre.Clear();
            // cmbCriterioBusquedaIngre.SelectedIndex = -1;
        }

        private void AjustarColumnasDgvRaw()
        {
            // Por ejemplo: dgvIngredientes.AutoResizeColumns();
        }

        private void CargarVistaConsolidadaIngredientes()
        {
            CargarTodosLosIngredientes();
        }
    }
}
