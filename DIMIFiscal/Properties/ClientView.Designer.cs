namespace DIMIFiscal.Properties {
    partial class ClientView {
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btClientOk = new Button();
            btClientCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkSimples = new CheckBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(51, 80);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 23);
            txtName.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(51, 181);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(170, 23);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btClientOk
            // 
            btClientOk.BackColor = SystemColors.ControlDark;
            btClientOk.Cursor = Cursors.Hand;
            btClientOk.FlatAppearance.BorderSize = 0;
            btClientOk.FlatAppearance.MouseDownBackColor = Color.White;
            btClientOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btClientOk.FlatStyle = FlatStyle.Flat;
            btClientOk.ForeColor = SystemColors.ControlText;
            btClientOk.Location = new Point(342, 443);
            btClientOk.Name = "btClientOk";
            btClientOk.Size = new Size(75, 23);
            btClientOk.TabIndex = 5;
            btClientOk.Text = "OK";
            btClientOk.UseVisualStyleBackColor = false;
            btClientOk.Click += button1_Click;
            // 
            // btClientCancel
            // 
            btClientCancel.BackColor = SystemColors.ControlDark;
            btClientCancel.Cursor = Cursors.Hand;
            btClientCancel.FlatAppearance.BorderSize = 0;
            btClientCancel.FlatAppearance.MouseDownBackColor = Color.White;
            btClientCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btClientCancel.FlatStyle = FlatStyle.Flat;
            btClientCancel.ForeColor = SystemColors.ControlText;
            btClientCancel.Location = new Point(423, 443);
            btClientCancel.Name = "btClientCancel";
            btClientCancel.Size = new Size(75, 23);
            btClientCancel.TabIndex = 6;
            btClientCancel.Text = "Cancelar";
            btClientCancel.UseVisualStyleBackColor = false;
            btClientCancel.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(51, 62);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(51, 113);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(51, 163);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(51, 213);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(51, 266);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 11;
            label5.Text = "Simples Nacional";
            // 
            // checkSimples
            // 
            checkSimples.AutoSize = true;
            checkSimples.Location = new Point(54, 284);
            checkSimples.Name = "checkSimples";
            checkSimples.Size = new Size(15, 14);
            checkSimples.TabIndex = 12;
            checkSimples.UseVisualStyleBackColor = true;
            // 
            // ClientView
            // 
            AcceptButton = btClientOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(564, 532);
            Controls.Add(checkSimples);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClientCancel);
            Controls.Add(btClientOk);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "ClientView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btClientOk;
        private Button btClientCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkSimples;
    }
}