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
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btClientClose);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btClientClose;
    }
}