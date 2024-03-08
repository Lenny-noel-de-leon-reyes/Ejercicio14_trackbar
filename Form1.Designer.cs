namespace Ejercicio9_trackbar
{
    partial class Form1
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
            this.trk_tamaño = new System.Windows.Forms.TrackBar();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trk_tamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // trk_tamaño
            // 
            this.trk_tamaño.Location = new System.Drawing.Point(214, 139);
            this.trk_tamaño.Name = "trk_tamaño";
            this.trk_tamaño.Size = new System.Drawing.Size(437, 45);
            this.trk_tamaño.TabIndex = 0;
            this.trk_tamaño.Scroll += new System.EventHandler(this.trk_tamaño_Scroll);
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamaño.Location = new System.Drawing.Point(398, 78);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(64, 17);
            this.lblTamaño.TabIndex = 1;
            this.lblTamaño.Text = "Mire aqui";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(401, 248);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.trk_tamaño);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trk_tamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TrackBar trk_tamaño;
    }
}

