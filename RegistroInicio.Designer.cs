namespace RegistroDePacientes
{
    partial class RegistroInicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInicio));
            errorProvider1 = new ErrorProvider(components);
            pnlDatos0 = new Panel();
            label8 = new Label();
            cbxSexo = new ComboBox();
            button5 = new Button();
            txtEdad = new TextBox();
            label7 = new Label();
            txtCedula = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            cbxCedula = new ComboBox();
            txtSApellido = new TextBox();
            txtPApellido = new TextBox();
            txtSNombre = new TextBox();
            txtPNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGuardarDatos0 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlDatos0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pnlDatos0
            // 
            pnlDatos0.BackColor = Color.CadetBlue;
            pnlDatos0.Controls.Add(label8);
            pnlDatos0.Controls.Add(cbxSexo);
            pnlDatos0.Controls.Add(button5);
            pnlDatos0.Controls.Add(txtEdad);
            pnlDatos0.Controls.Add(label7);
            pnlDatos0.Controls.Add(txtCedula);
            pnlDatos0.Controls.Add(label6);
            pnlDatos0.Controls.Add(pictureBox2);
            pnlDatos0.Controls.Add(cbxCedula);
            pnlDatos0.Controls.Add(txtSApellido);
            pnlDatos0.Controls.Add(txtPApellido);
            pnlDatos0.Controls.Add(txtSNombre);
            pnlDatos0.Controls.Add(txtPNombre);
            pnlDatos0.Controls.Add(label5);
            pnlDatos0.Controls.Add(label4);
            pnlDatos0.Controls.Add(label3);
            pnlDatos0.Controls.Add(label2);
            pnlDatos0.Location = new Point(205, 91);
            pnlDatos0.Name = "pnlDatos0";
            pnlDatos0.Size = new Size(601, 237);
            pnlDatos0.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(354, 191);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 33;
            label8.Text = "Sexo";
            // 
            // cbxSexo
            // 
            cbxSexo.BackColor = Color.FromArgb(192, 255, 255);
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.FlatStyle = FlatStyle.Flat;
            cbxSexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbxSexo.Location = new Point(405, 187);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(123, 25);
            cbxSexo.TabIndex = 32;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DarkSlateGray;
            button5.Location = new Point(270, 338);
            button5.Name = "button5";
            button5.Size = new Size(188, 40);
            button5.TabIndex = 21;
            button5.Text = "Limpiar Datos";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(192, 255, 255);
            txtEdad.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(155, 189);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(131, 23);
            txtEdad.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(102, 191);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 30;
            label7.Text = "Edad";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(192, 255, 255);
            txtCedula.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(338, 131);
            txtCedula.MaxLength = 8;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(96, 23);
            txtCedula.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(226, 134);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 28;
            label6.Text = "Cédula";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-176, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // cbxCedula
            // 
            cbxCedula.BackColor = Color.FromArgb(192, 255, 255);
            cbxCedula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCedula.FlatStyle = FlatStyle.Flat;
            cbxCedula.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxCedula.FormattingEnabled = true;
            cbxCedula.Items.AddRange(new object[] { "V", "E" });
            cbxCedula.Location = new Point(292, 130);
            cbxCedula.Name = "cbxCedula";
            cbxCedula.Size = new Size(40, 25);
            cbxCedula.TabIndex = 27;
            // 
            // txtSApellido
            // 
            txtSApellido.BackColor = Color.FromArgb(192, 255, 255);
            txtSApellido.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSApellido.Location = new Point(455, 70);
            txtSApellido.MaxLength = 30;
            txtSApellido.Name = "txtSApellido";
            txtSApellido.Size = new Size(131, 23);
            txtSApellido.TabIndex = 26;
            // 
            // txtPApellido
            // 
            txtPApellido.BackColor = Color.FromArgb(192, 255, 255);
            txtPApellido.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPApellido.Location = new Point(455, 34);
            txtPApellido.MaxLength = 30;
            txtPApellido.Name = "txtPApellido";
            txtPApellido.Size = new Size(131, 23);
            txtPApellido.TabIndex = 25;
            // 
            // txtSNombre
            // 
            txtSNombre.BackColor = Color.FromArgb(192, 255, 255);
            txtSNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSNombre.Location = new Point(154, 70);
            txtSNombre.MaxLength = 30;
            txtSNombre.Name = "txtSNombre";
            txtSNombre.Size = new Size(131, 23);
            txtSNombre.TabIndex = 24;
            // 
            // txtPNombre
            // 
            txtPNombre.BackColor = Color.FromArgb(192, 255, 255);
            txtPNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPNombre.Location = new Point(154, 34);
            txtPNombre.MaxLength = 30;
            txtPNombre.Name = "txtPNombre";
            txtPNombre.Size = new Size(131, 23);
            txtPNombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 72);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 22;
            label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 36);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 21;
            label4.Text = "Primer Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 72);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 20;
            label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 36);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 19;
            label2.Text = "Primer Nombre";
            // 
            // btnGuardarDatos0
            // 
            btnGuardarDatos0.BackColor = Color.PaleTurquoise;
            btnGuardarDatos0.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDatos0.ForeColor = Color.DarkSlateGray;
            btnGuardarDatos0.Location = new Point(48, 429);
            btnGuardarDatos0.Name = "btnGuardarDatos0";
            btnGuardarDatos0.Size = new Size(198, 40);
            btnGuardarDatos0.TabIndex = 20;
            btnGuardarDatos0.Text = "Guardar Datos";
            btnGuardarDatos0.UseVisualStyleBackColor = false;
            btnGuardarDatos0.Click += btnGuardarDatos0_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(170, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Bold ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(403, 40);
            label1.TabIndex = 0;
            label1.Text = "Registro De Pacientes";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.PaleTurquoise;
            btnSalir.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.DarkSlateGray;
            btnSalir.Location = new Point(693, 429);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 40);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // RegistroInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(834, 511);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardarDatos0);
            Controls.Add(pnlDatos0);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistroInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro De Pacientes - Datos Personales";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            pnlDatos0.ResumeLayout(false);
            pnlDatos0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Panel pnlDatos0;
        private Label label8;
        private ComboBox cbxSexo;
        private TextBox txtEdad;
        private Label label7;
        private TextBox txtCedula;
        private Label label6;
        private ComboBox cbxCedula;
        private TextBox txtSApellido;
        private TextBox txtPApellido;
        private TextBox txtSNombre;
        private TextBox txtPNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGuardarDatos0;
        private Button button5;
        private PictureBox pictureBox2;
        private Button btnSalir;
        private PictureBox pictureBox3;
        private Label label1;
    }
}
