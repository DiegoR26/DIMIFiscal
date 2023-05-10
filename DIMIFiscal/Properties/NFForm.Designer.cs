namespace DIMIFiscal.Properties {
    partial class NFForm {
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
            btNFClose = new Button();
            SuspendLayout();
            // 
            // btNFClose
            // 
            btNFClose.BackColor = Color.FromArgb(68, 71, 90);
            btNFClose.FlatAppearance.BorderSize = 0;
            btNFClose.FlatStyle = FlatStyle.Flat;
            btNFClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btNFClose.ForeColor = SystemColors.Control;
            btNFClose.Location = new Point(0, -1);
            btNFClose.Name = "btNFClose";
            btNFClose.Size = new Size(40, 40);
            btNFClose.TabIndex = 0;
            btNFClose.Text = "X";
            btNFClose.UseVisualStyleBackColor = false;
            btNFClose.Click += btNFClose_Click;
            // 
            // NFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btNFClose);
            Name = "NFForm";
            Text = "NFForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btNFClose;
    }
}