namespace Sistema_Taller_Mecanico
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
            lblTitulo = new Label();
            dataGridView1 = new DataGridView();
            lblFiltro = new Label();
            btnSeleccionar = new Button();
            btnAgregarAuto = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            lblAutoMarca = new Label();
            lblMotor = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            lblObservacion = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(303, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(89, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Taller Mecanico";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 298);
            dataGridView1.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(12, 80);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(239, 15);
            lblFiltro.TabIndex = 2;
            lblFiltro.Text = "Buscar Auto (Patente o Nombre Del Cliente)";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(644, 138);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(179, 23);
            btnSeleccionar.TabIndex = 3;
            btnSeleccionar.Text = "Dar de alta Auto (Reparado)";
            btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAuto
            // 
            btnAgregarAuto.Location = new Point(644, 284);
            btnAgregarAuto.Name = "btnAgregarAuto";
            btnAgregarAuto.Size = new Size(179, 23);
            btnAgregarAuto.TabIndex = 4;
            btnAgregarAuto.Text = "Agregar Auto (Reparacion)";
            btnAgregarAuto.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltro.Location = new Point(399, 80);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(199, 23);
            txtFiltro.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1198, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 6;
            label1.Text = "Datos Del Cliente/Auto";
            // 
            // lblAutoMarca
            // 
            lblAutoMarca.AutoSize = true;
            lblAutoMarca.Location = new Point(1051, 281);
            lblAutoMarca.Name = "lblAutoMarca";
            lblAutoMarca.Size = new Size(71, 15);
            lblAutoMarca.TabIndex = 11;
            lblAutoMarca.Text = "Auto/Marca";
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(1051, 543);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(126, 15);
            lblMotor.TabIndex = 13;
            lblMotor.Text = "Motor (Tipo de Motor)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1226, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1226, 535);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1226, 441);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1226, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1226, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1226, 208);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1226, 139);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 20;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(1051, 80);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(70, 15);
            lblDni.TabIndex = 21;
            lblDni.Text = "Documento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(1051, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 15);
            lblNombre.TabIndex = 22;
            lblNombre.Text = "Nombre/Apellido";
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(1064, 615);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(125, 15);
            lblObservacion.TabIndex = 23;
            lblObservacion.Text = "Detalle Arreglar (Auto)";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1226, 596);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(248, 96);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1556, 672);
            Controls.Add(richTextBox1);
            Controls.Add(lblObservacion);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblMotor);
            Controls.Add(lblAutoMarca);
            Controls.Add(label1);
            Controls.Add(txtFiltro);
            Controls.Add(btnAgregarAuto);
            Controls.Add(btnSeleccionar);
            Controls.Add(lblFiltro);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Ficha Del Dia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridView1;
        private Label lblFiltro;
        private Button btnSeleccionar;
        private Button btnAgregarAuto;
        private TextBox txtFiltro;
        private Label label1;
        private Label lblDni;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAutoMarca;
        private Label label7;
        private Label lblMotor;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label lblNombre;
        private Label lblObservacion;
        private RichTextBox richTextBox1;
    }
}
