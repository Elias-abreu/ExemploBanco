namespace BancoIF.Telas
{
    partial class Cad_Conta
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tx_rg = new TextBox();
            tx_nome = new TextBox();
            tx_dataN = new MaskedTextBox();
            cb_sexo = new ComboBox();
            cb_agencias = new ComboBox();
            tx_senha1 = new TextBox();
            tx_senha2 = new TextBox();
            button1 = new Button();
            mask_cpf = new MaskedTextBox();
            lb_senha = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 0;
            label1.Text = "Criar Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 88);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 174);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 88);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "RG.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 174);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Sexo.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 225);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Agência.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 270);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 7;
            label8.Text = "Senha.:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 270);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 8;
            label9.Text = "Conf. Senha.:";
            // 
            // tx_rg
            // 
            tx_rg.BorderStyle = BorderStyle.FixedSingle;
            tx_rg.Location = new Point(363, 85);
            tx_rg.Name = "tx_rg";
            tx_rg.Size = new Size(100, 23);
            tx_rg.TabIndex = 10;
            // 
            // tx_nome
            // 
            tx_nome.BorderStyle = BorderStyle.FixedSingle;
            tx_nome.Location = new Point(144, 125);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(319, 23);
            tx_nome.TabIndex = 11;
            // 
            // tx_dataN
            // 
            tx_dataN.BorderStyle = BorderStyle.FixedSingle;
            tx_dataN.Location = new Point(144, 171);
            tx_dataN.Mask = "00/00/0000";
            tx_dataN.Name = "tx_dataN";
            tx_dataN.Size = new Size(116, 23);
            tx_dataN.TabIndex = 12;
            // 
            // cb_sexo
            // 
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cb_sexo.Location = new Point(313, 174);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(150, 23);
            cb_sexo.TabIndex = 13;
            // 
            // cb_agencias
            // 
            cb_agencias.FormattingEnabled = true;
            cb_agencias.Location = new Point(140, 217);
            cb_agencias.Name = "cb_agencias";
            cb_agencias.Size = new Size(121, 23);
            cb_agencias.TabIndex = 14;
            // 
            // tx_senha1
            // 
            tx_senha1.BorderStyle = BorderStyle.FixedSingle;
            tx_senha1.Location = new Point(140, 267);
            tx_senha1.Name = "tx_senha1";
            tx_senha1.PasswordChar = '•';
            tx_senha1.Size = new Size(120, 23);
            tx_senha1.TabIndex = 15;
            // 
            // tx_senha2
            // 
            tx_senha2.BorderStyle = BorderStyle.FixedSingle;
            tx_senha2.Location = new Point(352, 267);
            tx_senha2.Name = "tx_senha2";
            tx_senha2.PasswordChar = '•';
            tx_senha2.Size = new Size(111, 23);
            tx_senha2.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(140, 320);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 17;
            button1.Text = "Criar Conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mask_cpf
            // 
            mask_cpf.BorderStyle = BorderStyle.FixedSingle;
            mask_cpf.Location = new Point(144, 85);
            mask_cpf.Mask = "000,000,000-00";
            mask_cpf.Name = "mask_cpf";
            mask_cpf.Size = new Size(147, 23);
            mask_cpf.TabIndex = 1;
            mask_cpf.TabIndexChanged += maskedTextBox2_Leave;
            mask_cpf.KeyDown += mask_cpf_KeyDown;
            mask_cpf.Leave += maskedTextBox2_Leave;
            // 
            // lb_senha
            // 
            lb_senha.AutoSize = true;
            lb_senha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_senha.ForeColor = Color.Red;
            lb_senha.Location = new Point(139, 300);
            lb_senha.Name = "lb_senha";
            lb_senha.Size = new Size(146, 17);
            lb_senha.TabIndex = 19;
            lb_senha.Text = "Confirmação de Senha";
            // 
            // button2
            // 
            button2.Location = new Point(269, 320);
            button2.Name = "button2";
            button2.Size = new Size(84, 38);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cad_Conta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 381);
            Controls.Add(button2);
            Controls.Add(lb_senha);
            Controls.Add(mask_cpf);
            Controls.Add(button1);
            Controls.Add(tx_senha2);
            Controls.Add(tx_senha1);
            Controls.Add(cb_agencias);
            Controls.Add(cb_sexo);
            Controls.Add(tx_dataN);
            Controls.Add(tx_nome);
            Controls.Add(tx_rg);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cad_Conta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Cad_Conta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tx_rg;
        private TextBox tx_nome;
        private MaskedTextBox tx_dataN;
        private ComboBox cb_sexo;
        private ComboBox cb_agencias;
        private TextBox tx_senha1;
        private TextBox tx_senha2;
        private Button button1;
        private MaskedTextBox mask_cpf;
        private Label lb_senha;
        private Button button2;
    }
}