namespace Home_s_Pizzaria
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
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            label5 = new Label();
            label6 = new Label();
            txtValor = new TextBox();
            btnSoma = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtpDataInicio = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 252);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(112, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(167, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(114, 158);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(167, 23);
            txtEndereco.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(114, 202);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(167, 23);
            txtTelefone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 23);
            txtEmail.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(152, 339);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 24);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar Evento";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Menu;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(244, 9);
            label5.Name = "label5";
            label5.Size = new Size(198, 27);
            label5.TabIndex = 10;
            label5.Text = "Controle de Eventos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 305);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Valor Orçamento";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(114, 295);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(167, 25);
            txtValor.TabIndex = 12;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(476, 223);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(69, 23);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "Calcular";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(470, 110);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 17;
            label7.Text = "Defina Datas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 147);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 18;
            label8.Text = "Data Inicío";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 191);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 19;
            label9.Text = "Data Fim";
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.CustomFormat = "";
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(448, 141);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(121, 23);
            dtpDataInicio.TabIndex = 20;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(448, 185);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(121, 23);
            dtpDataFim.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(696, 423);
            Controls.Add(dtpDataFim);
            Controls.Add(dtpDataInicio);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnSoma);
            Controls.Add(txtValor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnCadastrar;
        private Label label5;
        private Label label6;
        private TextBox txtValor;
        private Button btnSoma;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpDataInicio;
        private DateTimePicker dtpDataFim;
    }
}
