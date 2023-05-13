namespace DIMIFiscal {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            sideMenuPanel = new Panel();
            btConfig = new Button();
            btSair = new Button();
            btNotas = new Button();
            btClientes = new Button();
            logoPanel = new Panel();
            containerPanel = new Panel();
            sideMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.AutoScroll = true;
            sideMenuPanel.BackColor = Color.FromArgb(40, 42, 54);
            sideMenuPanel.Controls.Add(btConfig);
            sideMenuPanel.Controls.Add(btSair);
            sideMenuPanel.Controls.Add(btNotas);
            sideMenuPanel.Controls.Add(btClientes);
            sideMenuPanel.Controls.Add(logoPanel);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(220, 532);
            sideMenuPanel.TabIndex = 0;
            // 
            // btConfig
            // 
            btConfig.Dock = DockStyle.Bottom;
            btConfig.FlatAppearance.BorderSize = 0;
            btConfig.FlatStyle = FlatStyle.Flat;
            btConfig.ForeColor = SystemColors.Control;
            btConfig.Location = new Point(0, 452);
            btConfig.Name = "btConfig";
            btConfig.Padding = new Padding(10, 0, 0, 0);
            btConfig.Size = new Size(220, 40);
            btConfig.TabIndex = 4;
            btConfig.Text = "Configurações";
            btConfig.TextAlign = ContentAlignment.MiddleLeft;
            btConfig.UseVisualStyleBackColor = true;
            btConfig.Click += btConfig_Click;
            // 
            // btSair
            // 
            btSair.Dock = DockStyle.Bottom;
            btSair.FlatAppearance.BorderSize = 0;
            btSair.FlatStyle = FlatStyle.Flat;
            btSair.ForeColor = SystemColors.Control;
            btSair.Location = new Point(0, 492);
            btSair.Name = "btSair";
            btSair.Padding = new Padding(10, 0, 0, 0);
            btSair.Size = new Size(220, 40);
            btSair.TabIndex = 3;
            btSair.Text = "Sair";
            btSair.TextAlign = ContentAlignment.MiddleLeft;
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // btNotas
            // 
            btNotas.Dock = DockStyle.Top;
            btNotas.FlatAppearance.BorderSize = 0;
            btNotas.FlatStyle = FlatStyle.Flat;
            btNotas.ForeColor = SystemColors.Control;
            btNotas.Location = new Point(0, 136);
            btNotas.Name = "btNotas";
            btNotas.Padding = new Padding(10, 0, 0, 0);
            btNotas.Size = new Size(220, 40);
            btNotas.TabIndex = 2;
            btNotas.Text = "Baixar NFSes";
            btNotas.TextAlign = ContentAlignment.MiddleLeft;
            btNotas.UseVisualStyleBackColor = true;
            btNotas.Click += btNotas_Click;
            // 
            // btClientes
            // 
            btClientes.Dock = DockStyle.Top;
            btClientes.FlatAppearance.BorderSize = 0;
            btClientes.FlatStyle = FlatStyle.Flat;
            btClientes.ForeColor = SystemColors.Control;
            btClientes.Location = new Point(0, 96);
            btClientes.Name = "btClientes";
            btClientes.Padding = new Padding(10, 0, 0, 0);
            btClientes.Size = new Size(220, 40);
            btClientes.TabIndex = 1;
            btClientes.Text = "Clientes";
            btClientes.TextAlign = ContentAlignment.MiddleLeft;
            btClientes.UseVisualStyleBackColor = true;
            btClientes.Click += btClientes_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackgroundImage = Properties.Resources.DIMILogo;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(220, 96);
            logoPanel.TabIndex = 0;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.FromArgb(68, 71, 90);
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(220, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(564, 532);
            containerPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 532);
            Controls.Add(containerPanel);
            Controls.Add(sideMenuPanel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(800, 571);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            sideMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sideMenuPanel;
        private Button btSair;
        private Button btNotas;
        private Button btClientes;
        private Panel logoPanel;
        private Button btConfig;
        private Panel containerPanel;
    }
}