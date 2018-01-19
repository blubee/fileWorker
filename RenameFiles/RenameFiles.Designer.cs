namespace RenameFiles
{
    partial class RenameFiles
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.startRenameProcessBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderPathTbx = new System.Windows.Forms.TextBox();
            this.folderSelectionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.targetMainFileNameTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetFileCounterBeginTbx = new System.Windows.Forms.TextBox();
            this.fileNameCounterSeperatorTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileOrderCriteriaDdl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startRenameProcessBtn
            // 
            this.startRenameProcessBtn.Location = new System.Drawing.Point(591, 227);
            this.startRenameProcessBtn.Name = "startRenameProcessBtn";
            this.startRenameProcessBtn.Size = new System.Drawing.Size(113, 23);
            this.startRenameProcessBtn.TabIndex = 0;
            this.startRenameProcessBtn.Text = "Starte umbenennen";
            this.startRenameProcessBtn.UseVisualStyleBackColor = true;
            this.startRenameProcessBtn.Click += new System.EventHandler(this.startRenameProcessBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordner";
            // 
            // folderPathTbx
            // 
            this.folderPathTbx.Location = new System.Drawing.Point(16, 30);
            this.folderPathTbx.Name = "folderPathTbx";
            this.folderPathTbx.Size = new System.Drawing.Size(597, 20);
            this.folderPathTbx.TabIndex = 2;
            // 
            // folderSelectionBtn
            // 
            this.folderSelectionBtn.Location = new System.Drawing.Point(629, 27);
            this.folderSelectionBtn.Name = "folderSelectionBtn";
            this.folderSelectionBtn.Size = new System.Drawing.Size(75, 23);
            this.folderSelectionBtn.TabIndex = 3;
            this.folderSelectionBtn.Text = "Auswahl";
            this.folderSelectionBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ziel Hauptdateiname";
            // 
            // targetMainFileNameTbx
            // 
            this.targetMainFileNameTbx.Location = new System.Drawing.Point(19, 85);
            this.targetMainFileNameTbx.Name = "targetMainFileNameTbx";
            this.targetMainFileNameTbx.Size = new System.Drawing.Size(286, 20);
            this.targetMainFileNameTbx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beginne Counter ab (z.B. 0 oder 100)";
            // 
            // targetFileCounterBeginTbx
            // 
            this.targetFileCounterBeginTbx.Location = new System.Drawing.Point(471, 85);
            this.targetFileCounterBeginTbx.Name = "targetFileCounterBeginTbx";
            this.targetFileCounterBeginTbx.Size = new System.Drawing.Size(100, 20);
            this.targetFileCounterBeginTbx.TabIndex = 8;
            // 
            // fileNameCounterSeperatorTbx
            // 
            this.fileNameCounterSeperatorTbx.Location = new System.Drawing.Point(330, 84);
            this.fileNameCounterSeperatorTbx.Name = "fileNameCounterSeperatorTbx";
            this.fileNameCounterSeperatorTbx.Size = new System.Drawing.Size(92, 20);
            this.fileNameCounterSeperatorTbx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trenner (z.B. \' - \')";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bsp: Alle Dateien bekommen den Hauptdateinamen \"Auto\" und Trenner \" - \" und Start" +
    "Counter \"1\". \r\nDie Ausgabe ist dann Auto - 001.txt, Auto - 002.txt usw.";
            // 
            // fileOrderCriteriaDdl
            // 
            this.fileOrderCriteriaDdl.FormattingEnabled = true;
            this.fileOrderCriteriaDdl.Location = new System.Drawing.Point(572, 126);
            this.fileOrderCriteriaDdl.Name = "fileOrderCriteriaDdl";
            this.fileOrderCriteriaDdl.Size = new System.Drawing.Size(121, 21);
            this.fileOrderCriteriaDdl.TabIndex = 11;
            // 
            // RenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 262);
            this.Controls.Add(this.fileOrderCriteriaDdl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileNameCounterSeperatorTbx);
            this.Controls.Add(this.targetFileCounterBeginTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetMainFileNameTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderSelectionBtn);
            this.Controls.Add(this.folderPathTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startRenameProcessBtn);
            this.Name = "RenameFiles";
            this.Text = "Dateien umbenennen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startRenameProcessBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPathTbx;
        private System.Windows.Forms.Button folderSelectionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetMainFileNameTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetFileCounterBeginTbx;
        private System.Windows.Forms.TextBox fileNameCounterSeperatorTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileOrderCriteriaDdl;
    }
}

