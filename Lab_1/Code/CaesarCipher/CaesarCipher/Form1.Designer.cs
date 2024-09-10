namespace CaesarCipher
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textkey = new System.Windows.Forms.TextBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.BtnEnFile = new System.Windows.Forms.Button();
            this.BtnDe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 15);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(800, 119);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "النص المراد تشفيره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "مفتاح التشفير";
            // 
            // textkey
            // 
            this.textkey.Location = new System.Drawing.Point(24, 186);
            this.textkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textkey.Name = "textkey";
            this.textkey.Size = new System.Drawing.Size(257, 26);
            this.textkey.TabIndex = 3;
            this.textkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKey_KeyPress);
            // 
            // btnEnc
            // 
            this.btnEnc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnEnc.Location = new System.Drawing.Point(15, 399);
            this.btnEnc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(203, 50);
            this.btnEnc.TabIndex = 4;
            this.btnEnc.Text = "تشفير ";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // BtnEnFile
            // 
            this.BtnEnFile.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnEnFile.Location = new System.Drawing.Point(581, 399);
            this.BtnEnFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnFile.Name = "BtnEnFile";
            this.BtnEnFile.Size = new System.Drawing.Size(203, 50);
            this.BtnEnFile.TabIndex = 5;
            this.BtnEnFile.Text = "تشفير ملف ";
            this.BtnEnFile.UseVisualStyleBackColor = true;
            this.BtnEnFile.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnDe
            // 
            this.BtnDe.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnDe.Location = new System.Drawing.Point(321, 399);
            this.BtnDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDe.Name = "BtnDe";
            this.BtnDe.Size = new System.Drawing.Size(203, 50);
            this.BtnDe.TabIndex = 6;
            this.BtnDe.Text = "فك التشفير ";
            this.BtnDe.UseVisualStyleBackColor = true;
            this.BtnDe.Click += new System.EventHandler(this.BtnDe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(365, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "النص المشفر";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(15, 270);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(800, 88);
            this.result.TabIndex = 8;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 486);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDe);
            this.Controls.Add(this.BtnEnFile);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.textkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "خوارومية القيصر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textkey;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button BtnEnFile;
        private System.Windows.Forms.Button BtnDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox result;
    }
}

