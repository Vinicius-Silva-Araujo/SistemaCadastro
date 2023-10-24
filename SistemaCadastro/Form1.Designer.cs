namespace SistemaCadastro
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
            TxtNome = new TextBox();
            DataNascimento = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            CheckCasa = new CheckBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            checkVeiculo = new CheckBox();
            groupBox1 = new GroupBox();
            radioO = new RadioButton();
            radioF = new RadioButton();
            radioM = new RadioButton();
            lista = new ListBox();
            label5 = new Label();
            buttonCasdastre = new Button();
            buttonExcluir = new Button();
            buttonLimpar = new Button();
            comboEstCivil = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 89);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(109, 7);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(362, 23);
            TxtNome.TabIndex = 3;
            // 
            // DataNascimento
            // 
            DataNascimento.Location = new Point(109, 93);
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(249, 23);
            DataNascimento.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 179);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(174, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // CheckCasa
            // 
            CheckCasa.AutoSize = true;
            CheckCasa.Location = new Point(109, 222);
            CheckCasa.Name = "CheckCasa";
            CheckCasa.Size = new Size(127, 19);
            CheckCasa.TabIndex = 6;
            CheckCasa.Text = "Possui casa Propria";
            CheckCasa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 48);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(109, 50);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(362, 23);
            TxtEmail.TabIndex = 8;
            // 
            // checkVeiculo
            // 
            checkVeiculo.AutoSize = true;
            checkVeiculo.Location = new Point(109, 248);
            checkVeiculo.Name = "checkVeiculo";
            checkVeiculo.Size = new Size(101, 19);
            checkVeiculo.TabIndex = 9;
            checkVeiculo.Text = "Possui Veiculo";
            checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioO);
            groupBox1.Controls.Add(radioF);
            groupBox1.Controls.Add(radioM);
            groupBox1.Location = new Point(108, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 135);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            radioO.AutoSize = true;
            radioO.Location = new Point(14, 111);
            radioO.Name = "radioO";
            radioO.Size = new Size(56, 19);
            radioO.TabIndex = 2;
            radioO.TabStop = true;
            radioO.Text = "Outro";
            radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(14, 68);
            radioF.Name = "radioF";
            radioF.Size = new Size(75, 19);
            radioF.TabIndex = 1;
            radioF.TabStop = true;
            radioF.Text = "Feminino";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.Location = new Point(15, 29);
            radioM.Name = "radioM";
            radioM.Size = new Size(80, 19);
            radioM.TabIndex = 0;
            radioM.TabStop = true;
            radioM.Text = "Masculino";
            radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            lista.BorderStyle = BorderStyle.None;
            lista.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lista.FormattingEnabled = true;
            lista.ItemHeight = 17;
            lista.Location = new Point(16, 456);
            lista.Name = "lista";
            lista.Size = new Size(562, 51);
            lista.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 130);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 12;
            label5.Text = "Estado Civil";
            // 
            // buttonCasdastre
            // 
            buttonCasdastre.Location = new Point(24, 425);
            buttonCasdastre.Name = "buttonCasdastre";
            buttonCasdastre.Size = new Size(100, 25);
            buttonCasdastre.TabIndex = 14;
            buttonCasdastre.Text = "Cadastra/Alterar";
            buttonCasdastre.UseVisualStyleBackColor = true;
            buttonCasdastre.Click += buttonCasdastre_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(148, 425);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(100, 25);
            buttonExcluir.TabIndex = 15;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(272, 425);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(100, 25);
            buttonLimpar.TabIndex = 16;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // comboEstCivil
            // 
            comboEstCivil.FormattingEnabled = true;
            comboEstCivil.Items.AddRange(new object[] { "Casado", "Solteiro", "Divorciado", "União Estavel", "Viuvo" });
            comboEstCivil.Location = new Point(107, 130);
            comboEstCivil.Name = "comboEstCivil";
            comboEstCivil.Size = new Size(251, 23);
            comboEstCivil.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(comboEstCivil);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonCasdastre);
            Controls.Add(label5);
            Controls.Add(lista);
            Controls.Add(groupBox1);
            Controls.Add(checkVeiculo);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(CheckCasa);
            Controls.Add(maskedTextBox1);
            Controls.Add(DataNascimento);
            Controls.Add(TxtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNome;
        private DateTimePicker DataNascimento;
        private MaskedTextBox maskedTextBox1;
        private CheckBox CheckCasa;
        private Label label4;
        private TextBox TxtEmail;
        private CheckBox checkVeiculo;
        private GroupBox groupBox1;
        private RadioButton radioO;
        private RadioButton radioF;
        private RadioButton radioM;
        private ListBox lista;
        private Label label5;
        private Button buttonCasdastre;
        private Button buttonExcluir;
        private Button buttonLimpar;
        private ComboBox comboEstCivil;
    }
}