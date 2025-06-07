namespace Control_stock_galletas.Ventanas
{
    partial class StockGalletas // El modificador 'partial' debe estar fuera de las llaves
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private System.Windows.Forms.DataGridView dgvGalletas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarGalleta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotonGalleVolver;
        private System.Windows.Forms.ComboBox cmbCriterioBusquedaGalleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCantidadGalle;

        /// Limpiar los recursos que se estén usando.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.dgvGalletas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarGalleta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonGalleVolver = new System.Windows.Forms.Button();
            this.cmbCriterioBusquedaGalleta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCantidadGalle = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)(this.dgvGalletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadGalle)).BeginInit();
            this.SuspendLayout();

            // numCantidadGalle
            this.numCantidadGalle.Location = new System.Drawing.Point(150, 100);
            this.numCantidadGalle.Name = "numCantidadGalle";
            this.numCantidadGalle.Size = new System.Drawing.Size(120, 20);
            this.numCantidadGalle.TabIndex = 1;
            this.numCantidadGalle.Minimum = 0;
            this.numCantidadGalle.Maximum = 100000;

            // Agregar controles al formulario
            this.Controls.Add(this.numCantidadGalle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvGalletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadGalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}