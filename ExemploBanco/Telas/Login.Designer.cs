namespace Telas
{
    partial class Login
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
            tx_conta = new TextBox();
            tx_senha = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            lb_senhaI = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Número da Conta";
            // 
            // tx_conta
            // 
            tx_conta.BorderStyle = BorderStyle.FixedSingle;
            tx_conta.Location = new Point(12, 85);
            tx_conta.Name = "tx_conta";
            tx_conta.Size = new Size(243, 29);
            tx_conta.TabIndex = 1;
            // 
            // tx_senha
            // 
            tx_senha.BorderStyle = BorderStyle.FixedSingle;
            tx_senha.Location = new Point(12, 149);
            tx_senha.Name = "tx_senha";
            tx_senha.PasswordChar = '•';
            tx_senha.Size = new Size(243, 29);
            tx_senha.TabIndex = 2;
            tx_senha.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(12, 206);
            button1.Name = "button1";
            button1.Size = new Size(97, 35);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 206);
            button2.Name = "button2";
            button2.Size = new Size(118, 35);
            button2.TabIndex = 5;
            button2.Text = "Cadastre-se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 9);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 6;
            label3.Text = "Acessar Conta";
            // 
            // lb_senhaI
            // 
            lb_senhaI.AutoSize = true;
            lb_senhaI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_senhaI.ForeColor = Color.Red;
            lb_senhaI.Location = new Point(12, 182);
            lb_senhaI.Name = "lb_senhaI";
            lb_senhaI.Size = new Size(96, 17);
            lb_senhaI.TabIndex = 7;
            lb_senhaI.Text = "Senha e Conta";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 253);
            Controls.Add(lb_senhaI);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tx_senha);
            Controls.Add(tx_conta);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_conta;
        private TextBox tx_senha;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label lb_senhaI;
    }
}