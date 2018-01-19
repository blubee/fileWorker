namespace RenameFiles
{
    partial class FileShortener
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceFilePathTb = new System.Windows.Forms.TextBox();
            this.fileExtensionTb = new System.Windows.Forms.TextBox();
            this.removeFromPositionTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeToPositionTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordner Pfad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dateifilter (*.pdf)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entferne Zeichen von 0 bis Position x:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceFilePathTb
            // 
            this.sourceFilePathTb.Location = new System.Drawing.Point(12, 50);
            this.sourceFilePathTb.Name = "sourceFilePathTb";
            this.sourceFilePathTb.Size = new System.Drawing.Size(800, 20);
            this.sourceFilePathTb.TabIndex = 4;
            this.sourceFilePathTb.TextChanged += new System.EventHandler(this.sourceFilePathTb_TextChanged);
            // 
            // fileExtensionTb
            // 
            this.fileExtensionTb.Location = new System.Drawing.Point(12, 104);
            this.fileExtensionTb.Name = "fileExtensionTb";
            this.fileExtensionTb.Size = new System.Drawing.Size(100, 20);
            this.fileExtensionTb.TabIndex = 5;
            // 
            // removeFromPositionTb
            // 
            this.removeFromPositionTb.Location = new System.Drawing.Point(277, 104);
            this.removeFromPositionTb.Name = "removeFromPositionTb";
            this.removeFromPositionTb.Size = new System.Drawing.Size(100, 20);
            this.removeFromPositionTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entferne Zeichen von Position y bis Ende:";
            // 
            // removeToPositionTb
            // 
            this.removeToPositionTb.Location = new System.Drawing.Point(476, 103);
            this.removeToPositionTb.Name = "removeToPositionTb";
            this.removeToPositionTb.Size = new System.Drawing.Size(100, 20);
            this.removeToPositionTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bsp: 123abc456.pdf mit Start 4 und Ende 6 wird zu: abc.pdf";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(628, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Im angegebenen Ordner werden von allen Dateien die Zeichen im angegebenen Positio" +
    "nsbereich beibehalten und der Rest entfernt";
            // 
            // statusTb
            // 
            this.statusTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statusTb.Enabled = false;
            this.statusTb.Location = new System.Drawing.Point(712, 135);
            this.statusTb.Name = "statusTb";
            this.statusTb.Size = new System.Drawing.Size(100, 20);
            this.statusTb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status:";
            // 
            // errorTb
            // 
            this.errorTb.Location = new System.Drawing.Point(12, 168);
            this.errorTb.Multiline = true;
            this.errorTb.Name = "errorTb";
            this.errorTb.ReadOnly = true;
            this.errorTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorTb.Size = new System.Drawing.Size(800, 88);
            this.errorTb.TabIndex = 14;
            // 
            // FileShortener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 268);
            this.Controls.Add(this.errorTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeToPositionTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeFromPositionTb);
            this.Controls.Add(this.fileExtensionTb);
            this.Controls.Add(this.sourceFilePathTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileShortener";
            this.Text = "FileShortener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceFilePathTb;
        private System.Windows.Forms.TextBox fileExtensionTb;
        private System.Windows.Forms.TextBox removeFromPositionTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox removeToPositionTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox errorTb;
    }
}