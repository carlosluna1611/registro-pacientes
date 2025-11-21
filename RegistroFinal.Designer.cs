namespace RegistroDePacientes
{
    partial class RegistroFinal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFinal));
            errorProvider1 = new ErrorProvider(components);
            btnGuardarDatos1 = new Button();
            pnlDatosEspecificos0 = new Panel();
            cbxTelefono = new ComboBox();
            txtDireccion = new TextBox();
            label9 = new Label();
            txtTelefono = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbxPais = new ComboBox();
            txtCorreo = new TextBox();
            label15 = new Label();
            label1 = new Label();
            pnlDatosEspecificos1 = new Panel();
            label2 = new Label();
            chbxMedicamento = new CheckBox();
            txtMedicamento = new TextBox();
            label5 = new Label();
            btnRegresar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlDatosEspecificos0.SuspendLayout();
            pnlDatosEspecificos1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnGuardarDatos1
            // 
            btnGuardarDatos1.BackColor = Color.PaleTurquoise;
            btnGuardarDatos1.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDatos1.ForeColor = Color.DarkSlateGray;
            btnGuardarDatos1.Location = new Point(45, 429);
            btnGuardarDatos1.Name = "btnGuardarDatos1";
            btnGuardarDatos1.Size = new Size(198, 40);
            btnGuardarDatos1.TabIndex = 27;
            btnGuardarDatos1.Text = "Guardar Datos";
            btnGuardarDatos1.UseVisualStyleBackColor = false;
            btnGuardarDatos1.Click += btnGuardarDatos1_Click;
            // 
            // pnlDatosEspecificos0
            // 
            pnlDatosEspecificos0.BackColor = Color.CadetBlue;
            pnlDatosEspecificos0.Controls.Add(cbxTelefono);
            pnlDatosEspecificos0.Controls.Add(txtDireccion);
            pnlDatosEspecificos0.Controls.Add(label9);
            pnlDatosEspecificos0.Controls.Add(txtTelefono);
            pnlDatosEspecificos0.Controls.Add(label10);
            pnlDatosEspecificos0.Controls.Add(label11);
            pnlDatosEspecificos0.Controls.Add(cbxPais);
            pnlDatosEspecificos0.Controls.Add(txtCorreo);
            pnlDatosEspecificos0.Controls.Add(label15);
            pnlDatosEspecificos0.Location = new Point(45, 91);
            pnlDatosEspecificos0.Name = "pnlDatosEspecificos0";
            pnlDatosEspecificos0.Size = new Size(372, 237);
            pnlDatosEspecificos0.TabIndex = 25;
            // 
            // cbxTelefono
            // 
            cbxTelefono.BackColor = Color.FromArgb(192, 255, 255);
            cbxTelefono.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTelefono.FlatStyle = FlatStyle.Flat;
            cbxTelefono.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxTelefono.FormattingEnabled = true;
            cbxTelefono.Items.AddRange(new object[] { "0412", "0414", "0424", "0416", "0416" });
            cbxTelefono.Location = new Point(142, 75);
            cbxTelefono.Name = "cbxTelefono";
            cbxTelefono.Size = new Size(58, 21);
            cbxTelefono.TabIndex = 34;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(192, 255, 255);
            txtDireccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(148, 176);
            txtDireccion.MaxLength = 30;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(53, 179);
            label9.Name = "label9";
            label9.Size = new Size(89, 24);
            label9.TabIndex = 32;
            label9.Text = "Dirección";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(192, 255, 255);
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(206, 72);
            txtTelefono.MaxLength = 7;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(142, 27);
            txtTelefono.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(62, 75);
            label10.Name = "label10";
            label10.Size = new Size(80, 24);
            label10.TabIndex = 30;
            label10.Text = "Teléfono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(97, 139);
            label11.Name = "label11";
            label11.Size = new Size(45, 24);
            label11.TabIndex = 28;
            label11.Text = "País";
            // 
            // cbxPais
            // 
            cbxPais.BackColor = Color.FromArgb(192, 255, 255);
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FlatStyle = FlatStyle.Flat;
            cbxPais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxPais.FormattingEnabled = true;
            cbxPais.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahréin", "Bangladés", "Barbados", "Bielorrusia", "Bélgica", "Belice", "Benín", "Bután", "Bolivia", "Bosnia-Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "República Checa", "Chequia", "Chile", "China", "Chipre", "Colombia", "Comoras", "Congo", "República Democrática del Congo", "Corea del Norte", "Corea del Sur", "Costa Rica", "Costa de Marfil", "Croacia", "Cuba", "Dinamarca", "Yibuti", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Fiyi", "Filipinas", "Finlandia", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guinea", "Guinea-Bissau", "Guinea Ecuatorial", "Guyana", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irán", "Iraq", "Irlanda", "Islandia", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Mali / Malí", "Malta", "Marruecos", "Islas Marshall", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Birmania", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Qatar", "Reino Unido", "República Centroafricana", "República Dominicana", "Rumanía / Rumania", "Rusia", "Ruanda", "San Cristóbal y Nieves", "Islas Salomón", "Samoa", "San Marino", "Santa Lucía", "Ciudad del Vaticano", "Santo Tomé y Príncipe", "San Vicente y las Granadinas", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Suazilandia", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabue" });
            cbxPais.Location = new Point(148, 134);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(142, 29);
            cbxPais.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(192, 255, 255);
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(148, 31);
            txtCorreo.MaxLength = 30;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 27);
            txtCorreo.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(76, 33);
            label15.Name = "label15";
            label15.Size = new Size(66, 24);
            label15.TabIndex = 19;
            label15.Text = "Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Bold ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(403, 40);
            label1.TabIndex = 23;
            label1.Text = "Registro De Pacientes";
            // 
            // pnlDatosEspecificos1
            // 
            pnlDatosEspecificos1.BackColor = Color.CadetBlue;
            pnlDatosEspecificos1.Controls.Add(label2);
            pnlDatosEspecificos1.Controls.Add(chbxMedicamento);
            pnlDatosEspecificos1.Controls.Add(txtMedicamento);
            pnlDatosEspecificos1.Controls.Add(label5);
            pnlDatosEspecificos1.Location = new Point(452, 135);
            pnlDatosEspecificos1.Name = "pnlDatosEspecificos1";
            pnlDatosEspecificos1.Size = new Size(332, 152);
            pnlDatosEspecificos1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 56);
            label2.Name = "label2";
            label2.Size = new Size(194, 24);
            label2.TabIndex = 34;
            label2.Text = "Sí (especificar cuáles)";
            // 
            // chbxMedicamento
            // 
            chbxMedicamento.AutoSize = true;
            chbxMedicamento.FlatStyle = FlatStyle.Flat;
            chbxMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbxMedicamento.ForeColor = Color.DarkSlateGray;
            chbxMedicamento.Location = new Point(255, 62);
            chbxMedicamento.Name = "chbxMedicamento";
            chbxMedicamento.Size = new Size(12, 11);
            chbxMedicamento.TabIndex = 34;
            chbxMedicamento.UseVisualStyleBackColor = true;
            // 
            // txtMedicamento
            // 
            txtMedicamento.BackColor = Color.FromArgb(192, 255, 255);
            txtMedicamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMedicamento.Location = new Point(38, 106);
            txtMedicamento.MaxLength = 30;
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(249, 27);
            txtMedicamento.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 9);
            label5.Name = "label5";
            label5.Size = new Size(322, 26);
            label5.TabIndex = 19;
            label5.Text = "¿Tiene Alergias a Medicamentos?";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.PaleTurquoise;
            btnRegresar.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.DarkSlateGray;
            btnRegresar.Location = new Point(540, 429);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(139, 40);
            btnRegresar.TabIndex = 35;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.PaleTurquoise;
            btnSalir.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.DarkSlateGray;
            btnSalir.Location = new Point(685, 429);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 40);
            btnSalir.TabIndex = 36;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // RegistroFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(834, 511);
            Controls.Add(btnSalir);
            Controls.Add(btnRegresar);
            Controls.Add(pnlDatosEspecificos1);
            Controls.Add(btnGuardarDatos1);
            Controls.Add(pnlDatosEspecificos0);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistroFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro De Pacientes - Datos Específicos";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            pnlDatosEspecificos0.ResumeLayout(false);
            pnlDatosEspecificos0.PerformLayout();
            pnlDatosEspecificos1.ResumeLayout(false);
            pnlDatosEspecificos1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnGuardarDatos1;
        private Panel pnlDatosEspecificos0;
        private TextBox txtTelefono;
        private Label label10;
        private Label label11;
        private ComboBox cbxPais;
        private TextBox txtCorreo;
        private Label label15;
        private Label label1;
        private TextBox txtDireccion;
        private Label label9;
        private Panel pnlDatosEspecificos1;
        private TextBox txtMedicamento;
        private Label label5;
        private Label label2;
        private CheckBox chbxMedicamento;
        private ComboBox cbxTelefono;
        private Button btnRegresar;
        private Button btnSalir;
    }
}