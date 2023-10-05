namespace Consulta
{
    partial class FrmEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCarnet = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            dtFecha = new DateTimePicker();
            txtApellido = new TextBox();
            label6 = new Label();
            dgListado = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListado).BeginInit();
            SuspendLayout();
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(272, 44);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(165, 31);
            txtCarnet.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(280, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 31);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 2;
            label1.Text = "Agregar Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 3;
            label2.Text = "Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 111);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 175);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 5;
            label4.Text = "Apelido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 232);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 6;
            label5.Text = "Fecha Nac";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(dtFecha);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCarnet);
            groupBox1.Location = new Point(11, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 360);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(416, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 47);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(272, 226);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(419, 31);
            dtFecha.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(289, 169);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(279, 31);
            txtApellido.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 412);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 8;
            label6.Text = "listado de estudiantes";
            // 
            // dgListado
            // 
            dgListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListado.Location = new Point(48, 453);
            dgListado.Name = "dgListado";
            dgListado.RowHeadersWidth = 62;
            dgListado.RowTemplate.Height = 33;
            dgListado.Size = new Size(817, 160);
            dgListado.TabIndex = 9;
            // 
            // FrmEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 653);
            Controls.Add(dgListado);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmEstudiante";
            Text = "FrmEstudiante";
            Load += FrmEstudiante_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarnet;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtApellido;
        private Button btnGuardar;
        private DateTimePicker dtFecha;
        private Label label6;
        private DataGridView dgListado;
    }
}