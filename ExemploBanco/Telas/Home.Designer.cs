namespace BancoIF.Telas
{
    partial class Home
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
            ListViewItem listViewItem1 = new ListViewItem("");
            lb_user = new Label();
            lb_saldo = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            bt_depositar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lb_user
            // 
            lb_user.AutoSize = true;
            lb_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_user.Location = new Point(23, 28);
            lb_user.Name = "lb_user";
            lb_user.Size = new Size(266, 30);
            lb_user.TabIndex = 0;
            lb_user.Text = "Seja bem Vindo @usuário";
            // 
            // lb_saldo
            // 
            lb_saldo.AutoSize = true;
            lb_saldo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_saldo.Location = new Point(23, 75);
            lb_saldo.Name = "lb_saldo";
            lb_saldo.Size = new Size(184, 30);
            lb_saldo.TabIndex = 1;
            lb_saldo.Text = "Saldo da Conta XX";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(23, 123);
            listView1.Name = "listView1";
            listView1.Size = new Size(266, 204);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Operação";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.Width = 120;
            // 
            // bt_depositar
            // 
            bt_depositar.Location = new Point(316, 123);
            bt_depositar.Name = "bt_depositar";
            bt_depositar.Size = new Size(152, 42);
            bt_depositar.TabIndex = 3;
            bt_depositar.Text = "Depositar";
            bt_depositar.UseVisualStyleBackColor = true;
            bt_depositar.Click += bt_depositar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 171);
            button2.Name = "button2";
            button2.Size = new Size(152, 42);
            button2.TabIndex = 4;
            button2.Text = "Sacar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(316, 219);
            button3.Name = "button3";
            button3.Size = new Size(152, 42);
            button3.TabIndex = 5;
            button3.Text = "Transferir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(316, 267);
            button4.Name = "button4";
            button4.Size = new Size(152, 42);
            button4.TabIndex = 6;
            button4.Text = "Enviar Pix";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 353);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bt_depositar);
            Controls.Add(listView1);
            Controls.Add(lb_saldo);
            Controls.Add(lb_user);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_user;
        private Label lb_saldo;
        private ListView listView1;
        private Button bt_depositar;
        private Button button2;
        private Button button3;
        private Button button4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}