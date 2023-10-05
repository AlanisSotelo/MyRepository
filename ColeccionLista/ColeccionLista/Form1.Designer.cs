namespace ColeccionLista
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnImprimir = new Button();
            txtId = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtTelefonos = new TextBox();
            txtSalarios = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnSalarios = new Button();
            dgvPersonas = new DataGridView();
            btnTotal = new Button();
            btnSuma = new Button();
            btnPromedio = new Button();
            lblTotal = new Label();
            lblSuma = new Label();
            lblPromedio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 73);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(222, 73);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(398, 73);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(583, 73);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefonos";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(48, 211);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(169, 43);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(48, 132);
            txtId.Name = "txtId";
            txtId.Size = new Size(149, 34);
            txtId.TabIndex = 5;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(222, 132);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(152, 34);
            txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(398, 132);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(166, 34);
            txtApellidos.TabIndex = 7;
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(583, 132);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(152, 34);
            txtTelefonos.TabIndex = 8;
            // 
            // txtSalarios
            // 
            txtSalarios.Location = new Point(764, 132);
            txtSalarios.Name = "txtSalarios";
            txtSalarios.Size = new Size(152, 34);
            txtSalarios.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(764, 73);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 9;
            label5.Text = "Salario";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(238, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(169, 43);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(427, 211);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(169, 43);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalarios
            // 
            btnSalarios.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalarios.Location = new Point(603, 211);
            btnSalarios.Name = "btnSalarios";
            btnSalarios.Size = new Size(301, 43);
            btnSalarios.TabIndex = 13;
            btnSalarios.Text = "Salarios mayores a 1000";
            btnSalarios.UseVisualStyleBackColor = true;
            btnSalarios.Click += btnSalarios_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(62, 301);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.RowTemplate.Height = 33;
            dgvPersonas.Size = new Size(695, 293);
            dgvPersonas.TabIndex = 14;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTotal.Location = new Point(803, 316);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(169, 43);
            btnTotal.TabIndex = 15;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.Location = new Point(803, 403);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(169, 43);
            btnSuma.TabIndex = 16;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPromedio.Location = new Point(803, 491);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(169, 43);
            btnPromedio.TabIndex = 17;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(1013, 318);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 25);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "0.00";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuma.Location = new Point(1013, 411);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(46, 25);
            lblSuma.TabIndex = 19;
            lblSuma.Text = "0.00";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPromedio.Location = new Point(1013, 498);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(46, 25);
            lblPromedio.TabIndex = 20;
            lblPromedio.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 645);
            Controls.Add(lblPromedio);
            Controls.Add(lblSuma);
            Controls.Add(lblTotal);
            Controls.Add(btnPromedio);
            Controls.Add(btnSuma);
            Controls.Add(btnTotal);
            Controls.Add(dgvPersonas);
            Controls.Add(btnSalarios);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(txtSalarios);
            Controls.Add(label5);
            Controls.Add(txtTelefonos);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtId);
            Controls.Add(btnImprimir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnImprimir;
        private TextBox txtId;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtTelefonos;
        private TextBox txtSalarios;
        private Label label5;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnSalarios;
        private DataGridView dgvPersonas;
        private Button btnTotal;
        private Button btnSuma;
        private Button btnPromedio;
        private Label lblTotal;
        private Label lblSuma;
        private Label lblPromedio;
    }
}