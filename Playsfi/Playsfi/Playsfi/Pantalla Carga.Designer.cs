namespace Playsfi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgCarga = new System.Windows.Forms.ImageList(this.components);
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.pbFotos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCarga
            // 
            this.imgCarga.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCarga.ImageStream")));
            this.imgCarga.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCarga.Images.SetKeyName(0, "cuatro.jpg");
            this.imgCarga.Images.SetKeyName(1, "dos.jpg");
            this.imgCarga.Images.SetKeyName(2, "tres.jpg");
            this.imgCarga.Images.SetKeyName(3, "uno.jpg");
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(49, 279);
            this.pgbBarra.Margin = new System.Windows.Forms.Padding(2);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(458, 25);
            this.pgbBarra.TabIndex = 0;
            // 
            // pbFotos
            // 
            this.pbFotos.Location = new System.Drawing.Point(49, 42);
            this.pbFotos.Margin = new System.Windows.Forms.Padding(2);
            this.pbFotos.Name = "pbFotos";
            this.pbFotos.Size = new System.Drawing.Size(458, 204);
            this.pbFotos.TabIndex = 1;
            this.pbFotos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(322, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "PlaysFi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFotos);
            this.Controls.Add(this.pgbBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgCarga;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.PictureBox pbFotos;
        private System.Windows.Forms.Label label1;
    }
}

