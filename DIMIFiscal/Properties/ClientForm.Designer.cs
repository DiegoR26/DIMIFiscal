namespace DIMIFiscal.Properties {
    partial class ClientForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btClientClose = new Button();
            clientGrid = new DataGridView();
            btEditClient = new Button();
            btAddClient = new Button();
            btDelClient = new Button();
            checkSimples = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btSave = new Button();
            btCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)clientGrid).BeginInit();
            SuspendLayout();
            // 
            // btClientClose
            // 
            btClientClose.BackColor = Color.FromArgb(68, 71, 90);
            btClientClose.FlatAppearance.BorderSize = 0;
            btClientClose.FlatStyle = FlatStyle.Flat;
            btClientClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btClientClose.ForeColor = SystemColors.Control;
            btClientClose.Location = new Point(0, -1);
            btClientClose.Name = "btClientClose";
            btClientClose.Size = new Size(40, 40);
            btClientClose.TabIndex = 0;
            btClientClose.Text = "X";
            btClientClose.UseVisualStyleBackColor = false;
            btClientClose.Click += btClientClose_Click;
            // 
            // clientGrid
            // 
            clientGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientGrid.BackgroundColor = Color.FromArgb(224, 224, 224);
            clientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientGrid.Location = new Point(17, 209);
            clientGrid.Name = "clientGrid";
            clientGrid.RowTemplate.Height = 25;
            clientGrid.Size = new Size(535, 303);
            clientGrid.TabIndex = 1;
            // 
            // btEditClient
            // 
            btEditClient.BackColor = SystemColors.ControlDark;
            btEditClient.Cursor = Cursors.Hand;
            btEditClient.FlatAppearance.BorderSize = 0;
            btEditClient.FlatAppearance.CheckedBackColor = Color.White;
            btEditClient.FlatAppearance.MouseDownBackColor = Color.White;
            btEditClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btEditClient.FlatStyle = FlatStyle.Flat;
            btEditClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btEditClient.Location = new Point(435, 78);
            btEditClient.Name = "btEditClient";
            btEditClient.Size = new Size(75, 23);
            btEditClient.TabIndex = 3;
            btEditClient.Text = "Editar";
            btEditClient.UseVisualStyleBackColor = false;
            // 
            // btAddClient
            // 
            btAddClient.BackColor = SystemColors.ControlDark;
            btAddClient.Cursor = Cursors.Hand;
            btAddClient.FlatAppearance.BorderSize = 0;
            btAddClient.FlatAppearance.CheckedBackColor = Color.White;
            btAddClient.FlatAppearance.MouseDownBackColor = Color.White;
            btAddClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btAddClient.FlatStyle = FlatStyle.Flat;
            btAddClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAddClient.Location = new Point(435, 49);
            btAddClient.Name = "btAddClient";
            btAddClient.Size = new Size(75, 23);
            btAddClient.TabIndex = 4;
            btAddClient.Text = "Adicionar";
            btAddClient.UseVisualStyleBackColor = false;
            btAddClient.Click += btAddClient_Click;
            // 
            // btDelClient
            // 
            btDelClient.BackColor = SystemColors.ControlDark;
            btDelClient.Cursor = Cursors.Hand;
            btDelClient.FlatAppearance.BorderSize = 0;
            btDelClient.FlatAppearance.CheckedBackColor = Color.White;
            btDelClient.FlatAppearance.MouseDownBackColor = Color.White;
            btDelClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btDelClient.FlatStyle = FlatStyle.Flat;
            btDelClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDelClient.Location = new Point(435, 107);
            btDelClient.Name = "btDelClient";
            btDelClient.Size = new Size(75, 23);
            btDelClient.TabIndex = 2;
            btDelClient.Text = "Excluir";
            btDelClient.UseVisualStyleBackColor = false;
            // 
            // checkSimples
            // 
            checkSimples.AutoSize = true;
            checkSimples.Location = new Point(274, 151);
            checkSimples.Name = "checkSimples";
            checkSimples.Size = new Size(15, 14);
            checkSimples.TabIndex = 22;
            checkSimples.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(265, 133);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 21;
            label5.Text = "Simples Nacional";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(265, 82);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 20;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(265, 31);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 19;
            label3.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(82, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(82, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(265, 49);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 23);
            txtUser.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 13;
            // 
            // btSave
            // 
            btSave.BackColor = SystemColors.ControlDark;
            btSave.Cursor = Cursors.Hand;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatAppearance.CheckedBackColor = Color.White;
            btSave.FlatAppearance.MouseDownBackColor = Color.White;
            btSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSave.Location = new Point(435, 136);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 23;
            btSave.Text = "Salvar";
            btSave.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            btCancel.BackColor = SystemColors.ControlDark;
            btCancel.Cursor = Cursors.Hand;
            btCancel.FlatAppearance.BorderSize = 0;
            btCancel.FlatAppearance.CheckedBackColor = Color.White;
            btCancel.FlatAppearance.MouseDownBackColor = Color.White;
            btCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btCancel.FlatStyle = FlatStyle.Flat;
            btCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(435, 165);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 24;
            btCancel.Text = "Cancelar";
            btCancel.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btCancel);
            Controls.Add(btSave);
            Controls.Add(checkSimples);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btDelClient);
            Controls.Add(btAddClient);
            Controls.Add(btEditClient);
            Controls.Add(clientGrid);
            Controls.Add(btClientClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClientClose;
        private DataGridView clientGrid;
        private Button btEditClient;
        private Button btAddClient;
        private Button btDelClient;
        private CheckBox checkSimples;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtName;
        private TextBox txtId;
        private Button btSave;
        private Button btCancel;
    }
}