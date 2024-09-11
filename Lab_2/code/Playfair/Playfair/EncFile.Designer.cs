using System.Drawing;
using System.Windows.Forms;
namespace Playfair
{
    partial class EncFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboFileType;
        private Button btnOpenFile;
        private TextBox txtKey;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private RichTextBox fileContentBox;
        private Button btnSaveFile;
        private Label lblStatus;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboFileType = new System.Windows.Forms.ComboBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.fileContentBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radio = new System.Windows.Forms.RadioButton();
            this.nonradio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboFileType
            // 
            this.comboFileType.Items.AddRange(new object[] {
            "PDF",
            "TXT"});
            this.comboFileType.Location = new System.Drawing.Point(20, 41);
            this.comboFileType.Name = "comboFileType";
            this.comboFileType.Size = new System.Drawing.Size(87, 28);
            this.comboFileType.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(114, 41);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(114, 28);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(74, 103);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(574, 26);
            this.txtKey.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(16, 151);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(120, 34);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt File";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(142, 151);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 34);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt File";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_click);
            // 
            // fileContentBox
            // 
            this.fileContentBox.Location = new System.Drawing.Point(24, 235);
            this.fileContentBox.Name = "fileContentBox";
            this.fileContentBox.Size = new System.Drawing.Size(624, 157);
            this.fileContentBox.TabIndex = 5;
            this.fileContentBox.Text = "";
            this.fileContentBox.TextChanged += new System.EventHandler(this.fileContentBox_TextChanged);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(24, 398);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(150, 30);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save Encrypted File";
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 445);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(234, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 28);
            this.textBox1.TabIndex = 2;
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Location = new System.Drawing.Point(24, 205);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(90, 24);
            this.radio.TabIndex = 8;
            this.radio.TabStop = true;
            this.radio.Text = "editable";
            this.radio.UseVisualStyleBackColor = true;
            // 
            // nonradio
            // 
            this.nonradio.AutoSize = true;
            this.nonradio.Location = new System.Drawing.Point(124, 205);
            this.nonradio.Name = "nonradio";
            this.nonradio.Size = new System.Drawing.Size(122, 24);
            this.nonradio.TabIndex = 8;
            this.nonradio.TabStop = true;
            this.nonradio.Text = "non-editable";
            this.nonradio.UseVisualStyleBackColor = true;
            this.nonradio.CheckedChanged += new System.EventHandler(this.nonradio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key";
            // 
            // EncFile
            // 
            this.ClientSize = new System.Drawing.Size(660, 483);
            this.Controls.Add(this.nonradio);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.comboFileType);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.fileContentBox);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Name = "EncFile";
            this.Load += new System.EventHandler(this.EncFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private TextBox textBox1;
        private RadioButton radio;
        private RadioButton nonradio;
        private Label label2;
    }
}
