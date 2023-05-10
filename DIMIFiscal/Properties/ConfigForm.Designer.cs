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
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btConfigClose);
            Name = "ConfigForm";
            Text = "ConfigForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btConfigClose;
    }
}