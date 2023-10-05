namespace Consulta
{
    partial class FrmConsultas
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtCarnet = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lbEdad = new Label();
            lbApellido = new Label();
            lbNombre = new Label();
            lbCarnet = new Label();
            label7 = new Label();
            label6 = new Label();
            btnSiguiente = new Button();
            btnFinalizar = new Button();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lbEstudiante = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Agregar Estudiante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtCarnet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(307, 65);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(214, 32);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(125, 61);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(150, 31);
            txtCarnet.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 2;
            label3.Text = "Datos del Estudiante Atendido";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbEdad);
            groupBox2.Controls.Add(lbApellido);
            groupBox2.Controls.Add(lbNombre);
            groupBox2.Controls.Add(lbCarnet);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnSiguiente);
            groupBox2.Controls.Add(btnFinalizar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(42, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 276);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(141, 165);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(52, 25);
            lbEdad.TabIndex = 12;
            lbEdad.Text = "Edad";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(141, 123);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(78, 25);
            lbApellido.TabIndex = 11;
            lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(141, 85);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(78, 25);
            lbNombre.TabIndex = 10;
            lbNombre.Text = "Nombre";
            // 
            // lbCarnet
            // 
            lbCarnet.AutoSize = true;
            lbCarnet.Location = new Point(141, 47);
            lbCarnet.Name = "lbCarnet";
            lbCarnet.Size = new Size(63, 25);
            lbCarnet.TabIndex = 9;
            lbCarnet.Text = "Carnet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 165);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 8;
            label7.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 123);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 7;
            label6.Text = "Apellido";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(263, 235);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(258, 35);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Mostrar Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(18, 235);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(231, 37);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar Atencion";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 85);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 47);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Carnet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 4;
            label8.Text = "Cola de Estudiantes";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbEstudiante);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(603, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(270, 402);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lbEstudiante
            // 
            lbEstudiante.FormattingEnabled = true;
            lbEstudiante.ItemHeight = 25;
            lbEstudiante.Location = new Point(21, 48);
            lbEstudiante.Name = "lbEstudiante";
            lbEstudiante.Size = new Size(238, 329);
            lbEstudiante.TabIndex = 5;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 501);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmConsultas";
            Text = "FrmConsultas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtCarnet;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label lbNombre;
        private Label lbCarnet;
        private Label label7;
        private Label label6;
        private Button btnSiguiente;
        private Button btnFinalizar;
        private Label label5;
        private Label label4;
        private Label lbEdad;
        private Label lbApellido;
        private Label label8;
        private GroupBox groupBox3;
        private ListBox lbEstudiante;
    }
}