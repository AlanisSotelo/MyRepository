namespace EntregaEstudiantes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCarnet = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtProyecto = new TextBox();
            dtFechaEntrega = new DateTimePicker();
            txtCalificacion = new TextBox();
            dtFechaLim = new DateTimePicker();
            btnIngresar = new Button();
            btnListar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnListarTodo = new Button();
            btnEntrgasTardias = new Button();
            dgElementos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgElementos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Location = new Point(63, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 3;
            label2.Text = "Carnet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Location = new Point(205, 96);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Location = new Point(336, 96);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MintCream;
            label5.Location = new Point(475, 96);
            label5.Name = "label5";
            label5.Size = new Size(101, 30);
            label5.TabIndex = 6;
            label5.Text = "Proyecto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MintCream;
            label6.Location = new Point(682, 96);
            label6.Name = "label6";
            label6.Size = new Size(138, 30);
            label6.TabIndex = 7;
            label6.Text = "Fecha Límite";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MintCream;
            label7.Location = new Point(957, 96);
            label7.Name = "label7";
            label7.Size = new Size(178, 30);
            label7.TabIndex = 8;
            label7.Text = "Fecha Entregado";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MintCream;
            label8.Location = new Point(1216, 96);
            label8.Name = "label8";
            label8.Size = new Size(62, 30);
            label8.TabIndex = 9;
            label8.Text = "Nota";
            label8.Click += label8_Click;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(38, 143);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(138, 37);
            txtCarnet.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 37);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(327, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(118, 37);
            txtApellido.TabIndex = 12;
            // 
            // txtProyecto
            // 
            txtProyecto.Location = new Point(465, 143);
            txtProyecto.Name = "txtProyecto";
            txtProyecto.Size = new Size(127, 37);
            txtProyecto.TabIndex = 13;
            // 
            // dtFechaEntrega
            // 
            dtFechaEntrega.Location = new Point(909, 143);
            dtFechaEntrega.Name = "dtFechaEntrega";
            dtFechaEntrega.Size = new Size(286, 37);
            dtFechaEntrega.TabIndex = 15;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(1216, 141);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(72, 37);
            txtCalificacion.TabIndex = 16;
            // 
            // dtFechaLim
            // 
            dtFechaLim.Location = new Point(617, 143);
            dtFechaLim.Name = "dtFechaLim";
            dtFechaLim.Size = new Size(286, 37);
            dtFechaLim.TabIndex = 17;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 255, 192);
            btnIngresar.ForeColor = Color.DarkGreen;
            btnIngresar.Location = new Point(38, 213);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(182, 58);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(192, 255, 192);
            btnListar.ForeColor = Color.DarkGreen;
            btnListar.Location = new Point(465, 217);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(179, 54);
            btnListar.TabIndex = 19;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.ForeColor = Color.DarkGreen;
            btnModificar.Location = new Point(251, 215);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(182, 58);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.ForeColor = Color.Crimson;
            btnEliminar.Location = new Point(1106, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(182, 56);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListarTodo
            // 
            btnListarTodo.BackColor = Color.FromArgb(192, 255, 192);
            btnListarTodo.ForeColor = Color.DarkGreen;
            btnListarTodo.Location = new Point(682, 215);
            btnListarTodo.Name = "btnListarTodo";
            btnListarTodo.Size = new Size(179, 54);
            btnListarTodo.TabIndex = 22;
            btnListarTodo.Text = "Listar Todo";
            btnListarTodo.UseVisualStyleBackColor = false;
            btnListarTodo.Click += btnListarTodo_Click;
            // 
            // btnEntrgasTardias
            // 
            btnEntrgasTardias.BackColor = Color.FromArgb(192, 255, 192);
            btnEntrgasTardias.ForeColor = Color.DarkGreen;
            btnEntrgasTardias.Location = new Point(890, 213);
            btnEntrgasTardias.Name = "btnEntrgasTardias";
            btnEntrgasTardias.Size = new Size(188, 54);
            btnEntrgasTardias.TabIndex = 23;
            btnEntrgasTardias.Text = "Entregas Tardías";
            btnEntrgasTardias.UseVisualStyleBackColor = false;
            btnEntrgasTardias.Click += btnEntrgasTardias_Click;
            // 
            // dgElementos
            // 
            dgElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgElementos.Location = new Point(38, 310);
            dgElementos.Name = "dgElementos";
            dgElementos.RowHeadersWidth = 62;
            dgElementos.RowTemplate.Height = 33;
            dgElementos.Size = new Size(1250, 203);
            dgElementos.TabIndex = 24;
            dgElementos.CellClick += dgElementos_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1319, 574);
            Controls.Add(dgElementos);
            Controls.Add(btnEntrgasTardias);
            Controls.Add(btnListarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnListar);
            Controls.Add(btnIngresar);
            Controls.Add(dtFechaLim);
            Controls.Add(txtCalificacion);
            Controls.Add(dtFechaEntrega);
            Controls.Add(txtProyecto);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCarnet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "klb";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgElementos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCarnet;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtProyecto;
        private DateTimePicker dtFechaEntrega;
        private TextBox txtCalificacion;
        private DateTimePicker dtFechaLim;
        private Button btnIngresar;
        private Button btnListar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnListarTodo;
        private Button button1;
        private Button btnEntrgasTardias;
        private DataGridView dgElementos;
    }
}