namespace Control_stock_galletas
{
    partial class MenuGalletas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGalletas));
            label1 = new Label();
            BotonMenuGalle = new Button();
            BotonMenuIngredi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.FlatStyle = FlatStyle.Flat;
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // BotonMenuGalle
            // 
            resources.ApplyResources(BotonMenuGalle, "BotonMenuGalle");
            BotonMenuGalle.Name = "BotonMenuGalle";
            BotonMenuGalle.UseVisualStyleBackColor = true;
            BotonMenuGalle.UseWaitCursor = true;
            BotonMenuGalle.Click += button1_Click;
            // 
            // BotonMenuIngredi
            // 
            resources.ApplyResources(BotonMenuIngredi, "BotonMenuIngredi");
            BotonMenuIngredi.Name = "BotonMenuIngredi";
            BotonMenuIngredi.UseVisualStyleBackColor = true;
            BotonMenuIngredi.UseWaitCursor = true;
            BotonMenuIngredi.Click += button2_Click;
            // 
            // MenuGalletas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            Controls.Add(BotonMenuIngredi);
            Controls.Add(BotonMenuGalle);
            Controls.Add(label1);
            Name = "MenuGalletas";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BotonMenuGalle;
        private Button BotonMenuIngredi;
    }
}
