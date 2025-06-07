namespace Control_stock_galletas.Ventanas
{
    partial class StockIngredientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIngredientes));
            dgvIngredientes = new DataGridView();
            label1 = new Label();
            btnBuscarIngredientes = new Button();
            btnConfirmarCambios = new Button();
            BotonIngrediVolver = new Button();
            cmbCriterioBusquedaIngre = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            cmbNombreIngrediente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(40, 65);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.Size = new Size(799, 230);
            dgvIngredientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista de Ingredientes";
            // 
            // btnBuscarIngredientes
            // 
            btnBuscarIngredientes.Font = new Font("Cascadia Code", 12F);
            btnBuscarIngredientes.Location = new Point(66, 410);
            btnBuscarIngredientes.Name = "btnBuscarIngredientes";
            btnBuscarIngredientes.Size = new Size(223, 45);
            btnBuscarIngredientes.TabIndex = 4;
            btnBuscarIngredientes.Text = "Buscar";
            btnBuscarIngredientes.UseVisualStyleBackColor = true;
            btnBuscarIngredientes.Click += btnBuscarIngredientes_Click;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Font = new Font("Cascadia Code", 12F);
            btnConfirmarCambios.Location = new Point(387, 410);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(223, 45);
            btnConfirmarCambios.TabIndex = 5;
            btnConfirmarCambios.Text = "Confirmar Cambios";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            // 
            // BotonIngrediVolver
            // 
            BotonIngrediVolver.Font = new Font("Cascadia Code", 12F);
            BotonIngrediVolver.Location = new Point(690, 410);
            BotonIngrediVolver.Name = "BotonIngrediVolver";
            BotonIngrediVolver.Size = new Size(223, 45);
            BotonIngrediVolver.TabIndex = 6;
            BotonIngrediVolver.Text = "Volver";
            BotonIngrediVolver.UseVisualStyleBackColor = true;
            BotonIngrediVolver.Click += BotonIngrediVolver_Click;
            // 
            // cmbCriterioBusquedaIngre
            // 
            cmbCriterioBusquedaIngre.FormattingEnabled = true;
            cmbCriterioBusquedaIngre.Items.AddRange(new object[] { "Nombre", "Cod_Ingre", "Cod_Galle" });
            cmbCriterioBusquedaIngre.Location = new Point(66, 359);
            cmbCriterioBusquedaIngre.Name = "cmbCriterioBusquedaIngre";
            cmbCriterioBusquedaIngre.Size = new Size(223, 23);
            cmbCriterioBusquedaIngre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 320);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 7;
            label2.Text = "Elige cómo buscar, por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 320);
            label3.Name = "label3";
            label3.Size = new Size(235, 23);
            label3.TabIndex = 8;
            label3.Text = "Elige cómo cambiar la cantidad  por:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(549, 359);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // cmbNombreIngrediente
            // 
            cmbNombreIngrediente.DisplayMember = "Nombre";
            cmbNombreIngrediente.FormattingEnabled = true;
            cmbNombreIngrediente.Location = new Point(351, 359);
            cmbNombreIngrediente.Name = "cmbNombreIngrediente";
            cmbNombreIngrediente.Size = new Size(192, 23);
            cmbNombreIngrediente.TabIndex = 10;
            // 
            // StockIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(954, 480);
            Controls.Add(cmbNombreIngrediente);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCriterioBusquedaIngre);
            Controls.Add(BotonIngrediVolver);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(btnBuscarIngredientes);
            Controls.Add(label1);
            Controls.Add(dgvIngredientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StockIngredientes";
            Text = "StockIngredientes";
            Load += StockIngredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarIngredientes;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.Button BotonIngrediVolver;
        private System.Windows.Forms.ComboBox cmbCriterioBusquedaIngre;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbNombreIngrediente;
    }
}