namespace Ejemplo1
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 531);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 0;
            label2.Text = "Id Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 82);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 1;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "Costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 179);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 3;
            label5.Text = "% Ganancia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 222);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 4;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 268);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 5;
            label7.Text = "Stock Minimo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 323);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 6;
            label8.Text = "Stock Maximo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 380);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 7;
            label9.Text = "Existencia";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(33, 443);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 34);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 608);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}