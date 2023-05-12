namespace DIMIFiscal {
    partial class ConfigForm {
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
            btConfigClose = new Button();
            this.btDBSetLabel = new Label();
            DBPathLabel = new Label();
            btDBSet = new Button();
            btDLSet = new Button();
            DLPathLabel = new Label();
            btDLSetLabel = new Label();
            SuspendLayout();
            // 
            // btConfigClose
            // 
            btConfigClose.FlatAppearance.BorderSize = 0;
            btConfigClose.FlatStyle = FlatStyle.Flat;
            btConfigClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btConfigClose.ForeColor = SystemColors.Control;
            btConfigClose.Location = new Point(0, -2);
            btConfigClose.Name = "btConfigClose";
            btConfigClose.Size = new Size(40, 40);
            btConfigClose.TabIndex = 0;
            btConfigClose.Text = "X";
            btConfigClose.UseVisualStyleBackColor = true;
            btConfigClose.Click += btConfigClose_Click;
            // 
            // btDBSetLabel
            // 
            this.btDBSetLabel.AutoSize = true;
            this.btDBSetLabel.ForeColor = SystemColors.Control;
            this.btDBSetLabel.Location = new Point(51, 102);
            this.btDBSetLabel.Name = "btDBSetLabel";
            this.btDBSetLabel.Size = new Size(144, 15);
            this.btDBSetLabel.TabIndex = 2;
            this.btDBSetLabel.Text = "Base de Dados de Clientes";
            // 
            // DBPathLabel
            // 
            DBPathLabel.AutoSize = true;
            DBPathLabel.ForeColor = SystemColors.Control;
            DBPathLabel.Location = new Point(157, 124);
            DBPathLabel.Name = "DBPathLabel";
            DBPathLabel.Size = new Size(21, 15);
            DBPathLabel.TabIndex = 3;
            DBPathLabel.Text = "/...";
            // 
            // btDBSet
            // 
            btDBSet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btDBSet.BackColor = SystemColors.ControlDark;
            btDBSet.Cursor = Cursors.Hand;
            btDBSet.FlatAppearance.BorderSize = 0;
            btDBSet.FlatAppearance.CheckedBackColor = Color.White;
            btDBSet.FlatAppearance.MouseDownBackColor = Color.White;
            btDBSet.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btDBSet.FlatStyle = FlatStyle.Flat;
            btDBSet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDBSet.Location = new Point(51, 120);
            btDBSet.Name = "btDBSet";
            btDBSet.Size = new Size(75, 23);
            btDBSet.TabIndex = 5;
            btDBSet.Text = "Procurar...";
            btDBSet.UseVisualStyleBackColor = false;
            // 
            // btDLSet
            // 
            btDLSet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btDLSet.BackColor = SystemColors.ControlDark;
            btDLSet.Cursor = Cursors.Hand;
            btDLSet.FlatAppearance.BorderSize = 0;
            btDLSet.FlatAppearance.CheckedBackColor = Color.White;
            btDLSet.FlatAppearance.MouseDownBackColor = Color.White;
            btDLSet.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btDLSet.FlatStyle = FlatStyle.Flat;
            btDLSet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDLSet.Location = new Point(51, 200);
            btDLSet.Name = "btDLSet";
            btDLSet.Size = new Size(75, 23);
            btDLSet.TabIndex = 8;
            btDLSet.Text = "Procurar...";
            btDLSet.UseVisualStyleBackColor = false;
            // 
            // DLPathLabel
            // 
            DLPathLabel.AutoSize = true;
            DLPathLabel.ForeColor = SystemColors.Control;
            DLPathLabel.Location = new Point(157, 204);
            DLPathLabel.Name = "DLPathLabel";
            DLPathLabel.Size = new Size(21, 15);
            DLPathLabel.TabIndex = 7;
            DLPathLabel.Text = "/...";
            // 
            // btDLSetLabel
            // 
            btDLSetLabel.AutoSize = true;
            btDLSetLabel.ForeColor = SystemColors.Control;
            btDLSetLabel.Location = new Point(51, 182);
            btDLSetLabel.Name = "btDLSetLabel";
            btDLSetLabel.Size = new Size(139, 15);
            btDLSetLabel.TabIndex = 6;
            btDLSetLabel.Text = "Destino das Notas Fiscais";
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btDLSet);
            Controls.Add(DLPathLabel);
            Controls.Add(btDLSetLabel);
            Controls.Add(btDBSet);
            Controls.Add(DBPathLabel);
            Controls.Add(this.btDBSetLabel);
            Controls.Add(btConfigClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfigForm";
            Text = "ConfigForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConfigClose;
        private Label label1;
        private Label DBPathLabel;
        private Button btDBSet;
        private Button btDLSet;
        private Label DLPathLabel;
        private Label btDLSetLabel;
    }
}