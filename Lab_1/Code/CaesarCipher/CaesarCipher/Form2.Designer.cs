namespace CaesarCipher
{
    partial class Form2
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DecodeFileBtn = new System.Windows.Forms.Button();
            this.EncodeFileBtn = new System.Windows.Forms.Button();
            this.textkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewbox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiopdf = new System.Windows.Forms.RadioButton();
            this.radiotxt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(317, 88);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(496, 55);
            this.output.TabIndex = 17;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(857, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "مسار حفظ الملف";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // DecodeFileBtn
            // 
            this.DecodeFileBtn.Enabled = false;
            this.DecodeFileBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DecodeFileBtn.Location = new System.Drawing.Point(657, 357);
            this.DecodeFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DecodeFileBtn.Name = "DecodeFileBtn";
            this.DecodeFileBtn.Size = new System.Drawing.Size(156, 46);
            this.DecodeFileBtn.TabIndex = 15;
            this.DecodeFileBtn.Text = "فك التشفير ";
            this.DecodeFileBtn.UseVisualStyleBackColor = true;
            this.DecodeFileBtn.Click += new System.EventHandler(this.BtnDe_Click);
            // 
            // EncodeFileBtn
            // 
            this.EncodeFileBtn.Enabled = false;
            this.EncodeFileBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.EncodeFileBtn.Location = new System.Drawing.Point(491, 357);
            this.EncodeFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EncodeFileBtn.Name = "EncodeFileBtn";
            this.EncodeFileBtn.Size = new System.Drawing.Size(158, 46);
            this.EncodeFileBtn.TabIndex = 14;
            this.EncodeFileBtn.Text = "تشفير ملف ";
            this.EncodeFileBtn.UseVisualStyleBackColor = true;
            this.EncodeFileBtn.Click += new System.EventHandler(this.BtnEnFile_Click);
            // 
            // textkey
            // 
            this.textkey.Enabled = false;
            this.textkey.Location = new System.Drawing.Point(13, 162);
            this.textkey.Margin = new System.Windows.Forms.Padding(4);
            this.textkey.Multiline = true;
            this.textkey.Name = "textkey";
            this.textkey.Size = new System.Drawing.Size(800, 44);
            this.textkey.TabIndex = 12;
            this.textkey.TextChanged += new System.EventHandler(this.textkey_TextChanged);
            this.textkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypr);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(857, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "مفتاح التشفير";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(857, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "مسار الملف";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 24);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(800, 56);
            this.txtInput.TabIndex = 9;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 18;
            // 
            // viewbox
            // 
            this.viewbox.Enabled = false;
            this.viewbox.Location = new System.Drawing.Point(12, 213);
            this.viewbox.Name = "viewbox";
            this.viewbox.Size = new System.Drawing.Size(801, 118);
            this.viewbox.TabIndex = 19;
            this.viewbox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(824, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = " محتوى الملف لاصلي";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(491, 410);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 112);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(838, 413);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "المخرجات";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiotxt);
            this.groupBox1.Controls.Add(this.radiopdf);
            this.groupBox1.Location = new System.Drawing.Point(13, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(288, 56);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حفظ كـ";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // radiopdf
            // 
            this.radiopdf.AutoSize = true;
            this.radiopdf.Location = new System.Drawing.Point(6, 23);
            this.radiopdf.Name = "radiopdf";
            this.radiopdf.Size = new System.Drawing.Size(57, 24);
            this.radiopdf.TabIndex = 0;
            this.radiopdf.TabStop = true;
            this.radiopdf.Text = "pdf";
            this.radiopdf.UseVisualStyleBackColor = true;
            // 
            // radiotxt
            // 
            this.radiotxt.AutoSize = true;
            this.radiotxt.Location = new System.Drawing.Point(83, 24);
            this.radiotxt.Name = "radiotxt";
            this.radiotxt.Size = new System.Drawing.Size(60, 24);
            this.radiotxt.TabIndex = 0;
            this.radiotxt.TabStop = true;
            this.radiotxt.Text = "text";
            this.radiotxt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.viewbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DecodeFileBtn);
            this.Controls.Add(this.EncodeFileBtn);
            this.Controls.Add(this.textkey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecodeFileBtn;
        private System.Windows.Forms.Button EncodeFileBtn;
        private System.Windows.Forms.TextBox textkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox viewbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiotxt;
        private System.Windows.Forms.RadioButton radiopdf;
        private System.Windows.Forms.Button button1;
    }
}