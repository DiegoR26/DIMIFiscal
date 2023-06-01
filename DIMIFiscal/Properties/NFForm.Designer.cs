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
            checkedClientList = new CheckedListBox();
            competenciaBox = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dtCompFin = new DateTimePicker();
            dtCompIni = new DateTimePicker();
            checkPDF = new CheckBox();
            emissaoBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            dtEmitFin = new DateTimePicker();
            dtEmitIni = new DateTimePicker();
            emissorBox = new GroupBox();
            radioTom = new RadioButton();
            radioPres = new RadioButton();
            reportPanel = new Panel();
            checkXML = new CheckBox();
            arquivosBox = new GroupBox();
            btBaixarNF = new Button();
            competenciaBox.SuspendLayout();
            emissaoBox.SuspendLayout();
            emissorBox.SuspendLayout();
            arquivosBox.SuspendLayout();
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
            // checkedClientList
            // 
            checkedClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkedClientList.BackColor = Color.FromArgb(224, 224, 224);
            checkedClientList.FormattingEnabled = true;
            checkedClientList.Location = new Point(12, 48);
            checkedClientList.Name = "checkedClientList";
            checkedClientList.Size = new Size(194, 472);
            checkedClientList.TabIndex = 1;
            // 
            // competenciaBox
            // 
            competenciaBox.Controls.Add(label2);
            competenciaBox.Controls.Add(label1);
            competenciaBox.Controls.Add(dtCompFin);
            competenciaBox.Controls.Add(dtCompIni);
            competenciaBox.ForeColor = SystemColors.Control;
            competenciaBox.Location = new Point(212, 41);
            competenciaBox.Name = "competenciaBox";
            competenciaBox.Size = new Size(135, 127);
            competenciaBox.TabIndex = 2;
            competenciaBox.TabStop = false;
            competenciaBox.Text = "Competência";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Início";
            // 
            // dtCompFin
            // 
            dtCompFin.Cursor = Cursors.Hand;
            dtCompFin.CustomFormat = "dd/MM/yyyy";
            dtCompFin.Format = DateTimePickerFormat.Custom;
            dtCompFin.Location = new Point(18, 81);
            dtCompFin.Name = "dtCompFin";
            dtCompFin.Size = new Size(98, 23);
            dtCompFin.TabIndex = 1;
            dtCompFin.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // dtCompIni
            // 
            dtCompIni.Cursor = Cursors.Hand;
            dtCompIni.CustomFormat = "dd/MM/yyyy";
            dtCompIni.Format = DateTimePickerFormat.Custom;
            dtCompIni.Location = new Point(18, 36);
            dtCompIni.Name = "dtCompIni";
            dtCompIni.Size = new Size(98, 23);
            dtCompIni.TabIndex = 0;
            dtCompIni.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            dtCompIni.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // checkPDF
            // 
            checkPDF.AutoSize = true;
            checkPDF.Location = new Point(18, 47);
            checkPDF.Name = "checkPDF";
            checkPDF.Size = new Size(47, 19);
            checkPDF.TabIndex = 1;
            checkPDF.Text = "PDF";
            checkPDF.UseVisualStyleBackColor = true;
            // 
            // emissaoBox
            // 
            emissaoBox.Controls.Add(label4);
            emissaoBox.Controls.Add(label3);
            emissaoBox.Controls.Add(dtEmitFin);
            emissaoBox.Controls.Add(dtEmitIni);
            emissaoBox.ForeColor = SystemColors.Control;
            emissaoBox.Location = new Point(212, 174);
            emissaoBox.Name = "emissaoBox";
            emissaoBox.Size = new Size(135, 127);
            emissaoBox.TabIndex = 3;
            emissaoBox.TabStop = false;
            emissaoBox.Text = "Emissão";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 64);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Início";
            // 
            // dtEmitFin
            // 
            dtEmitFin.Cursor = Cursors.Hand;
            dtEmitFin.CustomFormat = "dd/MM/yyyy";
            dtEmitFin.Format = DateTimePickerFormat.Custom;
            dtEmitFin.Location = new Point(18, 82);
            dtEmitFin.Name = "dtEmitFin";
            dtEmitFin.Size = new Size(98, 23);
            dtEmitFin.TabIndex = 1;
            dtEmitFin.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // dtEmitIni
            // 
            dtEmitIni.Cursor = Cursors.Hand;
            dtEmitIni.CustomFormat = "dd/MM/yyyy";
            dtEmitIni.Format = DateTimePickerFormat.Custom;
            dtEmitIni.Location = new Point(18, 37);
            dtEmitIni.Name = "dtEmitIni";
            dtEmitIni.Size = new Size(98, 23);
            dtEmitIni.TabIndex = 0;
            dtEmitIni.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            dtEmitIni.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // emissorBox
            // 
            emissorBox.Controls.Add(radioTom);
            emissorBox.Controls.Add(radioPres);
            emissorBox.ForeColor = SystemColors.Control;
            emissorBox.Location = new Point(212, 307);
            emissorBox.Name = "emissorBox";
            emissorBox.Size = new Size(135, 79);
            emissorBox.TabIndex = 4;
            emissorBox.TabStop = false;
            emissorBox.Text = "Emissor";
            // 
            // radioTom
            // 
            radioTom.AutoSize = true;
            radioTom.ForeColor = SystemColors.Control;
            radioTom.Location = new Point(18, 47);
            radioTom.Name = "radioTom";
            radioTom.Size = new Size(73, 19);
            radioTom.TabIndex = 1;
            radioTom.TabStop = true;
            radioTom.Text = "Tomados";
            radioTom.UseVisualStyleBackColor = true;
            // 
            // radioPres
            // 
            radioPres.AutoSize = true;
            radioPres.Checked = true;
            radioPres.ForeColor = SystemColors.Control;
            radioPres.Location = new Point(18, 22);
            radioPres.Name = "radioPres";
            radioPres.Size = new Size(76, 19);
            radioPres.TabIndex = 0;
            radioPres.TabStop = true;
            radioPres.Text = "Prestados";
            radioPres.UseVisualStyleBackColor = true;
            // 
            // reportPanel
            // 
            reportPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportPanel.BackColor = Color.FromArgb(40, 42, 54);
            reportPanel.Location = new Point(353, 0);
            reportPanel.Name = "reportPanel";
            reportPanel.Size = new Size(211, 532);
            reportPanel.TabIndex = 5;
            // 
            // checkXML
            // 
            checkXML.AutoSize = true;
            checkXML.Checked = true;
            checkXML.CheckState = CheckState.Checked;
            checkXML.Location = new Point(18, 22);
            checkXML.Name = "checkXML";
            checkXML.Size = new Size(50, 19);
            checkXML.TabIndex = 0;
            checkXML.Text = "XML";
            checkXML.UseVisualStyleBackColor = true;
            // 
            // arquivosBox
            // 
            arquivosBox.Controls.Add(checkPDF);
            arquivosBox.Controls.Add(checkXML);
            arquivosBox.ForeColor = SystemColors.Control;
            arquivosBox.Location = new Point(212, 392);
            arquivosBox.Name = "arquivosBox";
            arquivosBox.Size = new Size(135, 73);
            arquivosBox.TabIndex = 6;
            arquivosBox.TabStop = false;
            arquivosBox.Text = "Arquivos";
            // 
            // btBaixarNF
            // 
            btBaixarNF.BackColor = SystemColors.ControlDark;
            btBaixarNF.Cursor = Cursors.Hand;
            btBaixarNF.FlatAppearance.BorderSize = 0;
            btBaixarNF.FlatAppearance.CheckedBackColor = Color.White;
            btBaixarNF.FlatAppearance.MouseDownBackColor = Color.White;
            btBaixarNF.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btBaixarNF.FlatStyle = FlatStyle.Flat;
            btBaixarNF.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btBaixarNF.Location = new Point(212, 471);
            btBaixarNF.Name = "btBaixarNF";
            btBaixarNF.Size = new Size(135, 35);
            btBaixarNF.TabIndex = 7;
            btBaixarNF.Text = "Iniciar";
            btBaixarNF.UseVisualStyleBackColor = false;
            btBaixarNF.Click += btBaixarNF_Click;
            // 
            // NFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(btBaixarNF);
            Controls.Add(arquivosBox);
            Controls.Add(reportPanel);
            Controls.Add(emissorBox);
            Controls.Add(emissaoBox);
            Controls.Add(competenciaBox);
            Controls.Add(checkedClientList);
            Controls.Add(btNFClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NFForm";
            Text = "NFForm";
            competenciaBox.ResumeLayout(false);
            competenciaBox.PerformLayout();
            emissaoBox.ResumeLayout(false);
            emissaoBox.PerformLayout();
            emissorBox.ResumeLayout(false);
            emissorBox.PerformLayout();
            arquivosBox.ResumeLayout(false);
            arquivosBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btNFClose;
        private CheckedListBox checkedClientList;
        private GroupBox competenciaBox;
        private DateTimePicker dtCompFin;
        private DateTimePicker dtCompIni;
        private GroupBox emissaoBox;
        private DateTimePicker dtEmitIni;
        private DateTimePicker dtEmitFin;
        private GroupBox emissorBox;
        private Panel reportPanel;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private RadioButton radioTom;
        private RadioButton radioPres;
        private GroupBox arquivosBox;
        private CheckBox checkPDF;
        private CheckBox checkXML;
        private Button btBaixarNF;
    }
}