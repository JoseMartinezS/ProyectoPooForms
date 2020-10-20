namespace ProyectoPooForms
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
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnCamioneta = new System.Windows.Forms.Button();
            this.btnCuatrimoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(278, 12);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(102, 87);
            this.btnVehiculo.TabIndex = 0;
            this.btnVehiculo.Text = "Vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnCamioneta
            // 
            this.btnCamioneta.Location = new System.Drawing.Point(278, 105);
            this.btnCamioneta.Name = "btnCamioneta";
            this.btnCamioneta.Size = new System.Drawing.Size(102, 87);
            this.btnCamioneta.TabIndex = 1;
            this.btnCamioneta.Text = "Camioneta";
            this.btnCamioneta.UseVisualStyleBackColor = true;
            this.btnCamioneta.Click += new System.EventHandler(this.btnCamioneta_Click);
            // 
            // btnCuatrimoto
            // 
            this.btnCuatrimoto.Location = new System.Drawing.Point(278, 198);
            this.btnCuatrimoto.Name = "btnCuatrimoto";
            this.btnCuatrimoto.Size = new System.Drawing.Size(102, 87);
            this.btnCuatrimoto.TabIndex = 2;
            this.btnCuatrimoto.Text = "Lobo";
            this.btnCuatrimoto.UseVisualStyleBackColor = true;
            this.btnCuatrimoto.Click += new System.EventHandler(this.btnCuatrimoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 319);
            this.Controls.Add(this.btnCuatrimoto);
            this.Controls.Add(this.btnCamioneta);
            this.Controls.Add(this.btnVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnCamioneta;
        private System.Windows.Forms.Button btnCuatrimoto;
    }
}

