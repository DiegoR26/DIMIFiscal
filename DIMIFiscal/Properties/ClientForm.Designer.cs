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
            clientGrid.Location = new Point(17, 97);
            clientGrid.Name = "clientGrid";
            clientGrid.RowTemplate.Height = 25;
            clientGrid.Size = new Size(535, 319);
            clientGrid.TabIndex = 1;
            // 
            // btEditClient
            // 
            btEditClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEditClient.BackColor = SystemColors.ControlDark;
            btEditClient.Cursor = Cursors.Hand;
            btEditClient.FlatAppearance.BorderSize = 0;
            btEditClient.FlatAppearance.CheckedBackColor = Color.White;
            btEditClient.FlatAppearance.MouseDownBackColor = Color.White;
            btEditClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btEditClient.FlatStyle = FlatStyle.Flat;
            btEditClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btEditClient.Location = new Point(396, 422);
            btEditClient.Name = "btEditClient";
            btEditClient.Size = new Size(75, 23);
            btEditClient.TabIndex = 3;
            btEditClient.Text = "Editar";
            btEditClient.UseVisualStyleBackColor = false;
            // 
            // btAddClient
            // 
            btAddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btAddClient.BackColor = SystemColors.ControlDark;
            btAddClient.Cursor = Cursors.Hand;
            btAddClient.FlatAppearance.BorderSize = 0;
            btAddClient.FlatAppearance.CheckedBackColor = Color.White;
            btAddClient.FlatAppearance.MouseDownBackColor = Color.White;
            btAddClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btAddClient.FlatStyle = FlatStyle.Flat;
            btAddClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAddClient.Location = new Point(315, 422);
            btAddClient.Name = "btAddClient";
            btAddClient.Size = new Size(75, 23);
            btAddClient.TabIndex = 4;
            btAddClient.Text = "Adicionar";
            btAddClient.UseVisualStyleBackColor = false;
            btAddClient.Click += btAddClient_Click;
            // 
            // btDelClient
            // 
            btDelClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btDelClient.BackColor = SystemColors.ControlDark;
            btDelClient.Cursor = Cursors.Hand;
            btDelClient.FlatAppearance.BorderSize = 0;
            btDelClient.FlatAppearance.CheckedBackColor = Color.White;
            btDelClient.FlatAppearance.MouseDownBackColor = Color.White;
            btDelClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btDelClient.FlatStyle = FlatStyle.Flat;
            btDelClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDelClient.Location = new Point(477, 422);
            btDelClient.Name = "btDelClient";
            btDelClient.Size = new Size(75, 23);
            btDelClient.TabIndex = 2;
            btDelClient.Text = "Excluir";
            btDelClient.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btDelClient);
            Controls.Add(btAddClient);
            Controls.Add(btEditClient);
            Controls.Add(clientGrid);
            Controls.Add(btClientClose);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btClientClose;
        private DataGridView clientGrid;
        private Button btEditClient;
        private Button btAddClient;
        private Button btDelClient;
    }
}