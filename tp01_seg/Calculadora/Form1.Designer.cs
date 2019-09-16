namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBinario = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.CmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.TxtNumeroDos = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOperar
            // 
            this.BtnOperar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnOperar, "BtnOperar");
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            resources.ApplyResources(this.BtnLimpiar, "BtnLimpiar");
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBinario
            // 
            resources.ApplyResources(this.BtnBinario, "BtnBinario");
            this.BtnBinario.Name = "BtnBinario";
            this.BtnBinario.UseVisualStyleBackColor = true;
            this.BtnBinario.Click += new System.EventHandler(this.BtnBinario_Click);
            // 
            // BtnDecimal
            // 
            resources.ApplyResources(this.BtnDecimal, "BtnDecimal");
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // CmbOperadores
            // 
            resources.ApplyResources(this.CmbOperadores, "CmbOperadores");
            this.CmbOperadores.FormattingEnabled = true;
            this.CmbOperadores.Name = "CmbOperadores";
            // 
            // txtNumeroUno
            // 
            resources.ApplyResources(this.txtNumeroUno, "txtNumeroUno");
            this.txtNumeroUno.Name = "txtNumeroUno";
            // 
            // TxtNumeroDos
            // 
            resources.ApplyResources(this.TxtNumeroDos, "TxtNumeroDos");
            this.TxtNumeroDos.Name = "TxtNumeroDos";
            // 
            // LblResultado
            // 
            resources.ApplyResources(this.LblResultado, "LblResultado");
            this.LblResultado.Name = "LblResultado";
            // 
            // Calculadora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.CmbOperadores);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.BtnBinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBinario;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.ComboBox CmbOperadores;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox TxtNumeroDos;
        private System.Windows.Forms.Label LblResultado;
    }
}

