namespace WinFormsApp1
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
            txtNota1 = new TextBox();
            txtPromedioAula = new TextBox();
            lstNota1 = new ListBox();
            ntnNuevo = new Button();
            btnAgregar = new Button();
            btnQuitar = new Button();
            label4 = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lstNota2 = new ListBox();
            lstNota3 = new ListBox();
            lstAlumno = new ListBox();
            label5 = new Label();
            label6 = new Label();
            lstPromedio = new ListBox();
            txtAlumno = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 34);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO NOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 105);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Alumno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 105);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota 1";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(203, 141);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(80, 23);
            txtNota1.TabIndex = 4;
            // 
            // txtPromedioAula
            // 
            txtPromedioAula.Location = new Point(533, 397);
            txtPromedioAula.Name = "txtPromedioAula";
            txtPromedioAula.Size = new Size(100, 23);
            txtPromedioAula.TabIndex = 5;
            // 
            // lstNota1
            // 
            lstNota1.FormattingEnabled = true;
            lstNota1.ItemHeight = 15;
            lstNota1.Location = new Point(203, 197);
            lstNota1.Name = "lstNota1";
            lstNota1.Size = new Size(93, 94);
            lstNota1.TabIndex = 7;
            lstNota1.SelectedIndexChanged += lstNota1_SelectedIndexChanged;
            // 
            // ntnNuevo
            // 
            ntnNuevo.Location = new Point(79, 309);
            ntnNuevo.Name = "ntnNuevo";
            ntnNuevo.Size = new Size(85, 40);
            ntnNuevo.TabIndex = 8;
            ntnNuevo.Text = "Nuevo";
            ntnNuevo.UseVisualStyleBackColor = true;
            ntnNuevo.Click += ntnNuevo_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(223, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 40);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(366, 309);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(85, 40);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 400);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "Promedio Aula";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(320, 141);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(80, 23);
            txtNota2.TabIndex = 12;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(432, 141);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(80, 23);
            txtNota3.TabIndex = 13;
            // 
            // lstNota2
            // 
            lstNota2.FormattingEnabled = true;
            lstNota2.ItemHeight = 15;
            lstNota2.Location = new Point(320, 197);
            lstNota2.Name = "lstNota2";
            lstNota2.Size = new Size(91, 94);
            lstNota2.TabIndex = 14;
            lstNota2.SelectedIndexChanged += lstNota2_SelectedIndexChanged;
            // 
            // lstNota3
            // 
            lstNota3.FormattingEnabled = true;
            lstNota3.ItemHeight = 15;
            lstNota3.Location = new Point(432, 197);
            lstNota3.Name = "lstNota3";
            lstNota3.Size = new Size(91, 94);
            lstNota3.TabIndex = 15;
            lstNota3.SelectedIndexChanged += lstNota3_SelectedIndexChanged;
            // 
            // lstAlumno
            // 
            lstAlumno.FormattingEnabled = true;
            lstAlumno.ItemHeight = 15;
            lstAlumno.Location = new Point(44, 197);
            lstAlumno.Name = "lstAlumno";
            lstAlumno.Size = new Size(120, 94);
            lstAlumno.TabIndex = 17;
            lstAlumno.SelectedIndexChanged += lstAlumno_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 105);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 18;
            label5.Text = "Nota 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 105);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 19;
            label6.Text = "Nota 3";
            // 
            // lstPromedio
            // 
            lstPromedio.FormattingEnabled = true;
            lstPromedio.ItemHeight = 15;
            lstPromedio.Location = new Point(542, 197);
            lstPromedio.Name = "lstPromedio";
            lstPromedio.Size = new Size(91, 94);
            lstPromedio.TabIndex = 20;
            lstPromedio.SelectedIndexChanged += lstPromedio_SelectedIndexChanged;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(44, 141);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(120, 23);
            txtAlumno.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 149);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 23;
            label7.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 467);
            Controls.Add(label7);
            Controls.Add(txtAlumno);
            Controls.Add(lstPromedio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lstAlumno);
            Controls.Add(lstNota3);
            Controls.Add(lstNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(label4);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(ntnNuevo);
            Controls.Add(lstNota1);
            Controls.Add(txtPromedioAula);
            Controls.Add(txtNota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNota1;
        private TextBox txtPromedioAula;
        private ListBox lstNota1;
        private Button ntnNuevo;
        private Button btnAgregar;
        private Button btnQuitar;
        private Label label4;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private ListBox lstNota2;
        private ListBox lstNota3;
        private ListBox lstAlumno;
        private Label label5;
        private Label label6;
        private ListBox lstPromedio;
        private TextBox txtAlumno;
        private Label label7;
    }
}
