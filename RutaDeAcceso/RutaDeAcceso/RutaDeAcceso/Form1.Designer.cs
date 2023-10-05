namespace RutaDeAcceso
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarCarpeta = new System.Windows.Forms.Button();
            this.txtNuevaCarpeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRutas = new System.Windows.Forms.ComboBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtRutaImpresa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(23, 136);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 334);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 38);
            this.label3.TabIndex = 37;
            this.label3.Text = "Directorio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnAgregarCarpeta);
            this.panel4.Controls.Add(this.txtNuevaCarpeta);
            this.panel4.Location = new System.Drawing.Point(23, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 103);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 38);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nueva Carpeta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarCarpeta
            // 
            this.btnAgregarCarpeta.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarCarpeta.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarpeta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarpeta.Location = new System.Drawing.Point(476, 45);
            this.btnAgregarCarpeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCarpeta.Name = "btnAgregarCarpeta";
            this.btnAgregarCarpeta.Size = new System.Drawing.Size(124, 40);
            this.btnAgregarCarpeta.TabIndex = 2;
            this.btnAgregarCarpeta.Text = "Agregar";
            this.btnAgregarCarpeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCarpeta.UseVisualStyleBackColor = false;
            this.btnAgregarCarpeta.Click += new System.EventHandler(this.btnAgregarCarpeta_Click);
            // 
            // txtNuevaCarpeta
            // 
            this.txtNuevaCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaCarpeta.Location = new System.Drawing.Point(36, 55);
            this.txtNuevaCarpeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevaCarpeta.Name = "txtNuevaCarpeta";
            this.txtNuevaCarpeta.Size = new System.Drawing.Size(432, 30);
            this.txtNuevaCarpeta.TabIndex = 1;
            this.txtNuevaCarpeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNuevaCarpeta_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ruta: ";
            // 
            // cbRutas
            // 
            this.cbRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRutas.FormattingEnabled = true;
            this.cbRutas.ItemHeight = 25;
            this.cbRutas.Location = new System.Drawing.Point(27, 92);
            this.cbRutas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRutas.Name = "cbRutas";
            this.cbRutas.Size = new System.Drawing.Size(441, 33);
            this.cbRutas.TabIndex = 10;
            this.cbRutas.SelectedIndexChanged += new System.EventHandler(this.cbRutas_SelectedIndexChanged);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.Window;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(15, 92);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuta.Multiline = true;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(408, 33);
            this.txtRuta.TabIndex = 1;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
            this.txtRuta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRuta_KeyDown);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Blue;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(488, 84);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(98, 41);
            this.btnAbrir.TabIndex = 35;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // txtRutaImpresa
            // 
            this.txtRutaImpresa.BackColor = System.Drawing.Color.White;
            this.txtRutaImpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaImpresa.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtRutaImpresa.Location = new System.Drawing.Point(15, 159);
            this.txtRutaImpresa.Multiline = true;
            this.txtRutaImpresa.Name = "txtRutaImpresa";
            this.txtRutaImpresa.ReadOnly = true;
            this.txtRutaImpresa.Size = new System.Drawing.Size(571, 70);
            this.txtRutaImpresa.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.txtRuta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRutaImpresa);
            this.panel2.Controls.Add(this.btnAbrir);
            this.panel2.Controls.Add(this.cbRutas);
            this.panel2.Location = new System.Drawing.Point(357, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 334);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 493);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(993, 491);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaCarpeta;
        private System.Windows.Forms.Button btnAgregarCarpeta;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRutas;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtRutaImpresa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

