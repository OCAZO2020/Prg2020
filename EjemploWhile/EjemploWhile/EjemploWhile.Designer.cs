namespace EjemploWhile
{
    partial class EjemploWhile
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
            this.bt_click = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btDerecha = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_click
            // 
            this.bt_click.Location = new System.Drawing.Point(168, 45);
            this.bt_click.Name = "bt_click";
            this.bt_click.Size = new System.Drawing.Size(75, 23);
            this.bt_click.TabIndex = 0;
            this.bt_click.Text = "Izquierda";
            this.bt_click.UseVisualStyleBackColor = true;
            this.bt_click.Click += new System.EventHandler(this.bt_click_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Purple;
            this.lbl.Location = new System.Drawing.Point(0, 225);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(15, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btDerecha
            // 
            this.btDerecha.Location = new System.Drawing.Point(304, 45);
            this.btDerecha.Name = "btDerecha";
            this.btDerecha.Size = new System.Drawing.Size(75, 23);
            this.btDerecha.TabIndex = 2;
            this.btDerecha.Text = "Derecha";
            this.btDerecha.UseVisualStyleBackColor = true;
            this.btDerecha.Click += new System.EventHandler(this.btDerecha_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(616, 225);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(15, 15);
            this.lbl2.TabIndex = 3;
            // 
            // EjemploWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 312);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btDerecha);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.bt_click);
            this.Name = "EjemploWhile";
            this.Text = "EjemploWhile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_click;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btDerecha;
        private System.Windows.Forms.Label lbl2;
    }
}

