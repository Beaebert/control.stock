namespace Control_stock_galletas.Ventanas
{
    partial class StockGalletas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockGalletas));
            dgvGalletas = new DataGridView();
            label1 = new Label();
            btnBuscarGalleta = new Button();
            button1 = new Button();
            BotonGalleVolver = new Button();
            cmbCriterioBusquedaGalleta = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGalletas).BeginInit();
            SuspendLayout();
            // 
            // dgvGalletas
            // 
            dgvGalletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGalletas.Location = new Point(49, 72);
            dgvGalletas.Name = "dgvGalletas";
            dgvGalletas.Size = new Size(688, 245);
            dgvGalletas.TabIndex = 1;
            dgvGalletas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 2;
            label1.Text = "Lista de Galletas";
            // 
            // btnBuscarGalleta
            // 
            btnBuscarGalleta.Font = new Font("Cascadia Code", 12F);
            btnBuscarGalleta.ImeMode = ImeMode.NoControl;
            btnBuscarGalleta.Location = new Point(49, 391);
            btnBuscarGalleta.Name = "btnBuscarGalleta";
            btnBuscarGalleta.Size = new Size(223, 45);
            btnBuscarGalleta.TabIndex = 3;
            btnBuscarGalleta.Text = "Buscar";
            btnBuscarGalleta.UseVisualStyleBackColor = true;
            btnBuscarGalleta.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Cascadia Code", 12F);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(366, 391);
            button1.Name = "button1";
            button1.Size = new Size(223, 45);
            button1.TabIndex = 4;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // BotonGalleVolver
            // 
            BotonGalleVolver.Font = new Font("Cascadia Code", 12F);
            BotonGalleVolver.ImeMode = ImeMode.NoControl;
            BotonGalleVolver.Location = new Point(697, 391);
            BotonGalleVolver.Name = "BotonGalleVolver";
            BotonGalleVolver.Size = new Size(223, 45);
            BotonGalleVolver.TabIndex = 5;
            BotonGalleVolver.Text = "Volver";
            BotonGalleVolver.UseVisualStyleBackColor = true;
            BotonGalleVolver.UseWaitCursor = true;
            BotonGalleVolver.Click += BotonGalleVolver_Click;
            // 
            // cmbCriterioBusquedaGalleta
            // 
            cmbCriterioBusquedaGalleta.FormattingEnabled = true;
            cmbCriterioBusquedaGalleta.Items.AddRange(new object[] { "Nombre", "Personaje", "Gusto", "Cod_Ingre", "Cod_Galle", "Todos" });
            cmbCriterioBusquedaGalleta.Location = new Point(49, 362);
            cmbCriterioBusquedaGalleta.Name = "cmbCriterioBusquedaGalleta";
            cmbCriterioBusquedaGalleta.Size = new Size(223, 23);
            cmbCriterioBusquedaGalleta.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 320);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 9;
            label2.Text = "Eligir cómo buscar, por:";
            // 
            // StockGalletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(954, 462);
            Controls.Add(label2);
            Controls.Add(cmbCriterioBusquedaGalleta);
            Controls.Add(BotonGalleVolver);
            Controls.Add(button1);
            Controls.Add(btnBuscarGalleta);
            Controls.Add(label1);
            Controls.Add(dgvGalletas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StockGalletas";
            Text = "StockGalletas";
            ((System.ComponentModel.ISupportInitialize)dgvGalletas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvGalletas;
        private Label label1;
        private Button btnBuscarGalleta;
        private Button button1;
        private Button BotonGalleVolver;
        private ComboBox cmbCriterioBusquedaGalleta;
        private Label label2;
    }
}