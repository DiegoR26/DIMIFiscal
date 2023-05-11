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
            checkedListBox1 = new CheckedListBox();
            competenciaBox = new GroupBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            emissaoBox = new GroupBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            emissorBox = new GroupBox();
            radioTom = new RadioButton();
            radioPres = new RadioButton();
            panel1 = new Panel();
            arquivosBox = new GroupBox();
            checkPDF = new CheckBox();
            checkXML = new CheckBox();
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
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkedListBox1.BackColor = Color.FromArgb(224, 224, 224);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 48);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(194, 472);
            checkedListBox1.TabIndex = 1;
            // 
            // competenciaBox
            // 
            competenciaBox.Controls.Add(checkBox2);
            competenciaBox.Controls.Add(label2);
            competenciaBox.Controls.Add(label1);
            competenciaBox.Controls.Add(dateTimePicker2);
            competenciaBox.Controls.Add(dateTimePicker1);
            competenciaBox.ForeColor = SystemColors.Control;
            competenciaBox.Location = new Point(212, 48);
            competenciaBox.Name = "competenciaBox";
            competenciaBox.Size = new Size(135, 127);
            competenciaBox.TabIndex = 2;
            competenciaBox.TabStop = false;
            competenciaBox.Text = "Competência";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(114, 0);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 7;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 62);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Início";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Cursor = Cursors.Hand;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(18, 81);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 23);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(18, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // emissaoBox
            // 
            emissaoBox.Controls.Add(checkBox1);
            emissaoBox.Controls.Add(label4);
            emissaoBox.Controls.Add(label3);
            emissaoBox.Controls.Add(dateTimePicker4);
            emissaoBox.Controls.Add(dateTimePicker3);
            emissaoBox.ForeColor = SystemColors.Control;
            emissaoBox.Location = new Point(212, 181);
            emissaoBox.Name = "emissaoBox";
            emissaoBox.Size = new Size(135, 127);
            emissaoBox.TabIndex = 3;
            emissaoBox.TabStop = false;
            emissaoBox.Text = "Emissão";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(114, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
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
            // dateTimePicker4
            // 
            dateTimePicker4.Cursor = Cursors.Hand;
            dateTimePicker4.CustomFormat = "dd/MM/yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(18, 82);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(98, 23);
            dateTimePicker4.TabIndex = 1;
            dateTimePicker4.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Cursor = Cursors.Hand;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(18, 37);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(98, 23);
            dateTimePicker3.TabIndex = 0;
            dateTimePicker3.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // emissorBox
            // 
            emissorBox.Controls.Add(radioTom);
            emissorBox.Controls.Add(radioPres);
            emissorBox.ForeColor = SystemColors.Control;
            emissorBox.Location = new Point(212, 314);
            emissorBox.Name = "emissorBox";
            emissorBox.Size = new Size(135, 97);
            emissorBox.TabIndex = 4;
            emissorBox.TabStop = false;
            emissorBox.Text = "Emissor";
            // 
            // radioTom
            // 
            radioTom.AutoSize = true;
            radioTom.ForeColor = SystemColors.Control;
            radioTom.Location = new Point(18, 59);
            radioTom.Name = "radioTom";
            radioTom.Size = new Size(73, 19);
            radioTom.TabIndex = 1;
            radioTom.Text = "Tomados";
            radioTom.UseVisualStyleBackColor = true;
            // 
            // radioPres
            // 
            radioPres.AutoSize = true;
            radioPres.Checked = true;
            radioPres.ForeColor = SystemColors.Control;
            radioPres.Location = new Point(18, 34);
            radioPres.Name = "radioPres";
            radioPres.Size = new Size(76, 19);
            radioPres.TabIndex = 0;
            radioPres.TabStop = true;
            radioPres.Text = "Prestados";
            radioPres.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(40, 42, 54);
            panel1.Location = new Point(353, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 532);
            panel1.TabIndex = 5;
            // 
            // arquivosBox
            // 
            arquivosBox.Controls.Add(checkPDF);
            arquivosBox.Controls.Add(checkXML);
            arquivosBox.ForeColor = SystemColors.Control;
            arquivosBox.Location = new Point(212, 417);
            arquivosBox.Name = "arquivosBox";
            arquivosBox.Size = new Size(135, 103);
            arquivosBox.TabIndex = 6;
            arquivosBox.TabStop = false;
            arquivosBox.Text = "Arquivos";
            // 
            // checkPDF
            // 
            checkPDF.AutoSize = true;
            checkPDF.ForeColor = SystemColors.Control;
            checkPDF.Location = new Point(18, 64);
            checkPDF.Name = "checkPDF";
            checkPDF.Size = new Size(47, 19);
            checkPDF.TabIndex = 1;
            checkPDF.Text = "PDF";
            checkPDF.UseVisualStyleBackColor = true;
            // 
            // checkXML
            // 
            checkXML.AutoSize = true;
            checkXML.Checked = true;
            checkXML.CheckState = CheckState.Checked;
            checkXML.ForeColor = SystemColors.Control;
            checkXML.Location = new Point(18, 39);
            checkXML.Name = "checkXML";
            checkXML.Size = new Size(50, 19);
            checkXML.TabIndex = 0;
            checkXML.Text = "XML";
            checkXML.UseVisualStyleBackColor = true;
            // 
            // NFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 71, 90);
            ClientSize = new Size(564, 532);
            Controls.Add(arquivosBox);
            Controls.Add(panel1);
            Controls.Add(emissorBox);
            Controls.Add(emissaoBox);
            Controls.Add(competenciaBox);
            Controls.Add(checkedListBox1);
            Controls.Add(btNFClose);
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
        private CheckedListBox checkedListBox1;
        private GroupBox competenciaBox;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private GroupBox emissaoBox;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private GroupBox emissorBox;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private RadioButton radioTom;
        private RadioButton radioPres;
        private GroupBox arquivosBox;
        private CheckBox checkPDF;
        private CheckBox checkXML;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}