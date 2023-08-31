namespace WindowsFormsApp1
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
            this.Tmr1 = new System.Windows.Forms.Timer(this.components);
            this.Enemigo2 = new System.Windows.Forms.PictureBox();
            this.Enemigo3 = new System.Windows.Forms.PictureBox();
            this.Enemigo1 = new System.Windows.Forms.PictureBox();
            this.nave1 = new System.Windows.Forms.PictureBox();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nave1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr1
            // 
            this.Tmr1.Enabled = true;
            this.Tmr1.Tick += new System.EventHandler(this.tmr1);
            // 
            // Enemigo2
            // 
            this.Enemigo2.Image = global::WindowsFormsApp1.Properties.Resources.enemigo2;
            this.Enemigo2.Location = new System.Drawing.Point(153, 22);
            this.Enemigo2.Name = "Enemigo2";
            this.Enemigo2.Size = new System.Drawing.Size(100, 50);
            this.Enemigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemigo2.TabIndex = 3;
            this.Enemigo2.TabStop = false;
            // 
            // Enemigo3
            // 
            this.Enemigo3.Image = global::WindowsFormsApp1.Properties.Resources.enemigo3;
            this.Enemigo3.Location = new System.Drawing.Point(294, 22);
            this.Enemigo3.Name = "Enemigo3";
            this.Enemigo3.Size = new System.Drawing.Size(100, 50);
            this.Enemigo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemigo3.TabIndex = 2;
            this.Enemigo3.TabStop = false;
            // 
            // Enemigo1
            // 
            this.Enemigo1.Image = global::WindowsFormsApp1.Properties.Resources.enemigo1;
            this.Enemigo1.Location = new System.Drawing.Point(12, 22);
            this.Enemigo1.Name = "Enemigo1";
            this.Enemigo1.Size = new System.Drawing.Size(100, 50);
            this.Enemigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemigo1.TabIndex = 1;
            this.Enemigo1.TabStop = false;
            // 
            // nave1
            // 
            this.nave1.Image = global::WindowsFormsApp1.Properties.Resources.nave;
            this.nave1.Location = new System.Drawing.Point(12, 354);
            this.nave1.Name = "nave1";
            this.nave1.Size = new System.Drawing.Size(210, 84);
            this.nave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nave1.TabIndex = 0;
            this.nave1.TabStop = false;
            // 
            // tmr2
            // 
            this.tmr2.Enabled = true;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // tmr3
            // 
            this.tmr3.Enabled = true;
            this.tmr3.Tick += new System.EventHandler(this.tmr3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enemigo2);
            this.Controls.Add(this.Enemigo3);
            this.Controls.Add(this.Enemigo1);
            this.Controls.Add(this.nave1);
            this.Name = "Form1";
            this.Text = "SpaceInvaders";
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemigo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nave1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer Tmr1;
        private System.Windows.Forms.PictureBox nave1;
        private System.Windows.Forms.PictureBox Enemigo1;
        private System.Windows.Forms.PictureBox Enemigo3;
        private System.Windows.Forms.PictureBox Enemigo2;
        public System.Windows.Forms.Timer tmr2;
        public System.Windows.Forms.Timer tmr3;
    }
}

