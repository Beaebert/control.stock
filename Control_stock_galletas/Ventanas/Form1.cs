using Control_stock_galletas.Ventanas;
using System;

namespace Control_stock_galletas
{
    public partial class MenuGalletas : Form
    {
        public MenuGalletas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recordar crear instancia de la clase StockGalletas y con ShowDialog llamarla
            // ShowDialog para bloquear el uso de la ventana anterior Menu
            StockGalletas formStockGalletas = new StockGalletas();
            formStockGalletas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StockIngredientes formStockIngredientes = new StockIngredientes();
            formStockIngredientes.ShowDialog();
        }


    }
}

