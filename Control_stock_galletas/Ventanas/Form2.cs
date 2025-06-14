﻿using Control_stock_galletas.Entidades;
using Control_stock_galletas.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_stock_galletas.Implementacion;
using Control_stock_galletas.Ventanas;

namespace Control_stock_galletas.Ventanas
{
    public partial class StockGalletas : Form
    {
        private readonly IGalletaDAO _galletaDAO;
        private Galleta? _galletaSeleccionada;
        private MenuGalletas _menuPrincipalForm;
        //Declaracion de controles
        private System.Windows.Forms.TextBox txtValorBusquedaGalleta;
        private System.Windows.Forms.TextBox txtCodIngrePrincipalGalle;
        private System.Windows.Forms.TextBox txtCodGalle; 
        private System.Windows.Forms.TextBox txtNombreGalle; 
        private System.Windows.Forms.TextBox txtPersonajeGalle; 
        private System.Windows.Forms.TextBox txtGustoGalle; 
        private System.Windows.Forms.TextBox txtCodProdGalle; 
        private System.Windows.Forms.TextBox txtCodIngreSecundarioGalle; 
        private System.Windows.Forms.Button btnModificarGalleta; 
        private System.Windows.Forms.Button btnEliminarGalleta; // Declaración del control

        // Permite inyección de dependencias para facilitar pruebas y flexibilidad
        public StockGalletas(MenuGalletas menuPrincipal, IGalletaDAO galletaDAO = null)
        {
            InitializeComponent();
            _galletaDAO = galletaDAO ?? new SQLDAOGalleta();
            _menuPrincipalForm = menuPrincipal;

            ControlesAdicionalesGalleta(); 
            LimpiarCamposEdicionGalleta();
        }
        private void InitializeComponent()
        {
            if (this.DesignMode)
            {
                return;
            }

            this.txtValorBusquedaGalleta = new System.Windows.Forms.TextBox();
            this.txtCodIngrePrincipalGalle = new System.Windows.Forms.TextBox();
            this.txtCodGalle = new System.Windows.Forms.TextBox();
            this.txtNombreGalle = new System.Windows.Forms.TextBox();
            this.txtPersonajeGalle = new System.Windows.Forms.TextBox();
            this.txtGustoGalle = new System.Windows.Forms.TextBox();
            this.txtCodProdGalle = new System.Windows.Forms.TextBox();
            this.txtCodIngreSecundarioGalle = new System.Windows.Forms.TextBox();
            this.btnModificarGalleta = new System.Windows.Forms.Button();
            this.btnEliminarGalleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorBusquedaGalleta
            // 
            this.txtValorBusquedaGalleta.Location = new System.Drawing.Point(150, 50); // Ajusta la posición según tu diseño
            this.txtValorBusquedaGalleta.Name = "txtValorBusquedaGalleta";
            this.txtValorBusquedaGalleta.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.txtValorBusquedaGalleta.TabIndex = 1;
            this.Controls.Add(this.txtValorBusquedaGalleta);
            // 
            // txtCodIngrePrincipalGalle
            // 
            this.txtCodIngrePrincipalGalle.Location = new System.Drawing.Point(150, 100); // Ajusta la posición según tu diseño
            this.txtCodIngrePrincipalGalle.Name = "txtCodIngrePrincipalGalle";
            this.txtCodIngrePrincipalGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.txtCodIngrePrincipalGalle.TabIndex = 2;
            this.Controls.Add(this.txtCodIngrePrincipalGalle);
            // 
            // txtCodGalle
            // 
            this.txtCodGalle.Location = new System.Drawing.Point(150, 150); // Ajusta la posición según tu diseño
            this.txtCodGalle.Name = "txtCodGalle";
            this.txtCodGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtCodGalle); // Agrega el control al formulario
            // 
            // txtNombreGalle
            // 
            this.txtNombreGalle.Location = new System.Drawing.Point(150, 200); // Ajusta la posición según tu diseño
            this.txtNombreGalle.Name = "txtNombreGalle";
            this.txtNombreGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtNombreGalle); // Agrega el control al formulario
            // 
            // txtPersonajeGalle
            // 
            this.txtPersonajeGalle.Location = new System.Drawing.Point(150, 250); // Ajusta la posición según tu diseño
            this.txtPersonajeGalle.Name = "txtPersonajeGalle";
            this.txtPersonajeGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtPersonajeGalle); // Agrega el control al formulario
            // 
            // txtGustoGalle
            // 
            this.txtGustoGalle.Location = new System.Drawing.Point(150, 300); // Ajusta la posición según tu diseño
            this.txtGustoGalle.Name = "txtGustoGalle";
            this.txtGustoGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtGustoGalle); // Agrega el control al formulario
            // 
            // txtCodProdGalle
            // 
            this.txtCodProdGalle.Location = new System.Drawing.Point(150, 350); // Ajusta la posición según tu diseño
            this.txtCodProdGalle.Name = "txtCodProdGalle";
            this.txtCodProdGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtCodProdGalle); // Agrega el control al formulario
            // 
            // txtCodIngreSecundarioGalle
            // 
            this.txtCodIngreSecundarioGalle.Location = new System.Drawing.Point(150, 400); // Ajusta la posición según tu diseño
            this.txtCodIngreSecundarioGalle.Name = "txtCodIngreSecundarioGalle";
            this.txtCodIngreSecundarioGalle.Size = new System.Drawing.Size(200, 20); // Ajusta el tamaño según tu diseño
            this.Controls.Add(this.txtCodIngreSecundarioGalle); // Agrega el control al formulario
            // 
            // btnModificarGalleta
            // 
            this.btnModificarGalleta.Location = new System.Drawing.Point(150, 450); // Ajusta la posición según tu diseño
            this.btnModificarGalleta.Name = "btnModificarGalleta";
            this.btnModificarGalleta.Size = new System.Drawing.Size(100, 30); // Ajusta el tamaño según tu diseño
            this.btnModificarGalleta.TabIndex = 3;
            this.btnModificarGalleta.Text = "Modificar";
            this.btnModificarGalleta.UseVisualStyleBackColor = true;
            this.btnModificarGalleta.Click += new System.EventHandler(this.btnModificarGalleta_Click);
            this.Controls.Add(this.btnModificarGalleta); // Agrega el control al formulario
            // 
            // btnEliminarGalleta
            // 
            this.btnEliminarGalleta.Location = new System.Drawing.Point(150, 500); // Ajusta la posición según tu diseño
            this.btnEliminarGalleta.Name = "btnEliminarGalleta";
            this.btnEliminarGalleta.Size = new System.Drawing.Size(100, 30); // Ajusta el tamaño según tu diseño
            this.btnEliminarGalleta.TabIndex = 4;
            this.btnEliminarGalleta.Text = "Eliminar";
            this.btnEliminarGalleta.UseVisualStyleBackColor = true;
            this.btnEliminarGalleta.Click += new System.EventHandler(this.btnEliminarGalleta_Click);
            this.Controls.Add(this.btnEliminarGalleta); // Agrega el control al formulario
            this.ResumeLayout(false);
        }
        public StockGalletas() : this(null, null) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonGalleVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockIngredientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_menuPrincipalForm != null && !_menuPrincipalForm.IsDisposed)
            {
                _menuPrincipalForm.Show();
            }
        }

        private void ControlesAdicionalesGalleta()
        {
            dgvGalletas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGalletas.MultiSelect = false;
            dgvGalletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGalletas.AllowUserToAddRows = false;
            dgvGalletas.AllowUserToDeleteRows = false;
            dgvGalletas.ReadOnly = true;
            dgvGalletas.CellClick += dgvGalletas_CellClick;

            cmbCriterioBusquedaGalleta.Items.Clear();
            cmbCriterioBusquedaGalleta.Items.Add("Nombre");
            cmbCriterioBusquedaGalleta.Items.Add("Personaje");
            cmbCriterioBusquedaGalleta.Items.Add("Gusto");
            if (cmbCriterioBusquedaGalleta.Items.Count > 0)
                cmbCriterioBusquedaGalleta.SelectedIndex = 0;

            numCantidadGalle.Minimum = 0;
            numCantidadGalle.Maximum = 100000;

            btnBuscarGalleta.Click += btnBuscarGalleta_Click;
        }

        private void StockGalletas_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                CargarTodasLasGalletas();
            }
        }

        private void CargarTodasLasGalletas()
        {
            try
            {
                dgvGalletas.DataSource = null;
                List<Galleta> listaGalletas = _galletaDAO.ObtenerTodas();
                dgvGalletas.DataSource = listaGalletas;
                AjustarColumnasDgvGalletas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las galletas: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposEdicionGalleta();
        }

        private void AjustarColumnasDgvGalletas()
        {
            if (dgvGalletas.Columns.Contains("Cod_Galle"))
                dgvGalletas.Columns["Cod_Galle"].HeaderText = "Código Galleta";
            if (dgvGalletas.Columns.Contains("Nombre"))
                dgvGalletas.Columns["Nombre"].HeaderText = "Nombre";
        }

        private void btnBuscarGalleta_Click(object sender, EventArgs e)
        {
            string? criterio = cmbCriterioBusquedaGalleta.SelectedItem?.ToString();
            string valor = txtValorBusquedaGalleta.Text.Trim();

            if (string.IsNullOrEmpty(criterio) || string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show("Seleccione un criterio y escriba un valor para buscar.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Galleta> resultado = null;
                switch (criterio)
                {
                    case "Nombre":
                        resultado = _galletaDAO.ObtenerPorNombre(valor);
                        break;
                    case "Personaje":
                        resultado = _galletaDAO.ObtenerPorPersonaje(valor);
                        break;
                    case "Gusto":
                        resultado = _galletaDAO.ObtenerPorGusto(valor);
                        break;
                }

                dgvGalletas.DataSource = null;
                if (resultado != null && resultado.Any())
                {
                    dgvGalletas.DataSource = resultado;
                    AjustarColumnasDgvGalletas();
                }
                else
                {
                    MessageBox.Show("No se encontraron galletas con ese criterio.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar galletas: " + ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtValorBusquedaGalleta.Clear();
                if (cmbCriterioBusquedaGalleta.Items.Count > 0)
                    cmbCriterioBusquedaGalleta.SelectedIndex = 0;
                LimpiarCamposEdicionGalleta();
            }
        }

        private void dgvGalletas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGalletas.Rows[e.RowIndex].DataBoundItem is Galleta galleta)
            {
                _galletaSeleccionada = galleta;
                txtCodGalle.Text = galleta.Cod_Galle;
                txtNombreGalle.Text = galleta.Nombre;
                txtPersonajeGalle.Text = galleta.Personaje;
                txtGustoGalle.Text = galleta.Gusto;
                numCantidadGalle.Value = galleta.Cantidad;
                txtCodProdGalle.Text = galleta.Cod_Prod;
                txtCodIngrePrincipalGalle.Text = galleta.Cod_Ingre_Principal?.ToString() ?? "";
                txtCodIngreSecundarioGalle.Text = galleta.Segundo_Ingrediente?.ToString() ?? "";

                btnModificarGalleta.Enabled = true;
                btnEliminarGalleta.Enabled = true;
                txtCodGalle.ReadOnly = true;
            }
        }

        private void LimpiarCamposEdicionGalleta()
        {
            _galletaSeleccionada = null; 
            txtCodGalle.Clear();
            txtNombreGalle.Clear();
            txtPersonajeGalle.Clear();
            txtGustoGalle.Clear();
            numCantidadGalle.Value = numCantidadGalle.Minimum;
            txtCodProdGalle.Clear();
            txtCodIngrePrincipalGalle.Clear();
            txtCodIngreSecundarioGalle.Clear();

            btnModificarGalleta.Enabled = false;
            btnEliminarGalleta.Enabled = false;
            txtCodGalle.ReadOnly = false;
            dgvGalletas.ClearSelection();
        }

        private void btnLimpiarCamposGalleta_Click(object sender, EventArgs e)
        {
            LimpiarCamposEdicionGalleta();
        }

        private bool ValidarCamposGalleta(bool esNuevo)
        {
            if (esNuevo && string.IsNullOrWhiteSpace(txtCodGalle.Text))
            {
                MessageBox.Show("El Código de Galleta es obligatorio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodGalle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreGalle.Text))
            {
                MessageBox.Show("El Nombre de la galleta es obligatorio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreGalle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodProdGalle.Text))
            {
                MessageBox.Show("El Código de Producto base es obligatorio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProdGalle.Focus();
                return false;
            }
            return true;
        }

        private void btnAgregarGalleta_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposGalleta(true)) return;

            var nuevaGalleta = new Galleta
            {
                Cod_Galle = txtCodGalle.Text.Trim(),
                Nombre = txtNombreGalle.Text.Trim(),
                Personaje = txtPersonajeGalle.Text.Trim(),
                Gusto = txtGustoGalle.Text.Trim(),
                Cantidad = (int)numCantidadGalle.Value,
                Cod_Prod = txtCodProdGalle.Text.Trim(),
                Cod_Ingre_Principal = int.TryParse(txtCodIngrePrincipalGalle.Text.Trim(), out int cip) ? cip : (int?)null,
                Segundo_Ingrediente = int.TryParse(txtCodIngreSecundarioGalle.Text.Trim(), out int cis) ? cis : (int?)null
            };

            try
            {
                if (_galletaDAO.Agregar(nuevaGalleta))
                {
                    MessageBox.Show("Galleta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodasLasGalletas();
                    LimpiarCamposEdicionGalleta();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la galleta. Verifique si el código ya existe o revise los logs.", "Fallo al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la galleta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarGalleta_Click(object sender, EventArgs e)
        {
            if (_galletaSeleccionada == null || string.IsNullOrWhiteSpace(txtCodGalle.Text))
            {
                MessageBox.Show("Seleccione una galleta de la lista para modificar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCamposGalleta(false)) return;

            var galletaModificada = new Galleta
            {
                Cod_Galle = txtCodGalle.Text.Trim(),
                Nombre = txtNombreGalle.Text.Trim(),
                Personaje = txtPersonajeGalle.Text.Trim(),
                Gusto = txtGustoGalle.Text.Trim(),
                Cantidad = (int)numCantidadGalle.Value,
                Cod_Prod = txtCodProdGalle.Text.Trim(),
                Cod_Ingre_Principal = int.TryParse(txtCodIngrePrincipalGalle.Text.Trim(), out int cip) ? cip : (int?)null,
                Segundo_Ingrediente = int.TryParse(txtCodIngreSecundarioGalle.Text.Trim(), out int cis) ? cis : (int?)null
            };

            try
            {
                if (_galletaDAO.Actualizar(galletaModificada))
                {
                    MessageBox.Show("Galleta modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodasLasGalletas();
                    LimpiarCamposEdicionGalleta();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la galleta.", "Fallo al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la galleta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarGalleta_Click(object sender, EventArgs e)
        {
            if (_galletaSeleccionada == null || string.IsNullOrWhiteSpace(txtCodGalle.Text))
            {
                MessageBox.Show("Seleccione una galleta de la lista para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar la galleta '{_galletaSeleccionada.Nombre}' (Código: {_galletaSeleccionada.Cod_Galle})?",
                                                       "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (_galletaDAO.Eliminar(_galletaSeleccionada.Cod_Galle))
                    {
                        MessageBox.Show("Galleta eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTodasLasGalletas();
                        LimpiarCamposEdicionGalleta();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la galleta.", "Fallo al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la galleta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolverMenuGalletas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockGalletas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_menuPrincipalForm != null && !_menuPrincipalForm.IsDisposed)
            {
                _menuPrincipalForm.Show();
            }
        }
    }
}
