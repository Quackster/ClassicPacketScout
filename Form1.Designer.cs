namespace ClassicPacketScout
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToB64 = new System.Windows.Forms.TextBox();
            this.txtFromB64 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromVL64 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToVL64 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFromB64 = new System.Windows.Forms.Button();
            this.btnToB64 = new System.Windows.Forms.Button();
            this.btnToVL64 = new System.Windows.Forms.Button();
            this.btnFromVL64 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDecodeOutput = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtVL64 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To B64:";
            // 
            // txtToB64
            // 
            this.txtToB64.Location = new System.Drawing.Point(66, 9);
            this.txtToB64.Name = "txtToB64";
            this.txtToB64.Size = new System.Drawing.Size(100, 20);
            this.txtToB64.TabIndex = 1;
            this.txtToB64.Text = "1";
            // 
            // txtFromB64
            // 
            this.txtFromB64.Location = new System.Drawing.Point(250, 9);
            this.txtFromB64.Name = "txtFromB64";
            this.txtFromB64.Size = new System.Drawing.Size(100, 20);
            this.txtFromB64.TabIndex = 3;
            this.txtFromB64.Text = "@A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From B64:";
            // 
            // txtFromVL64
            // 
            this.txtFromVL64.Location = new System.Drawing.Point(250, 86);
            this.txtFromVL64.Name = "txtFromVL64";
            this.txtFromVL64.Size = new System.Drawing.Size(100, 20);
            this.txtFromVL64.TabIndex = 7;
            this.txtFromVL64.Text = "YNE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "From VL64:";
            // 
            // txtToVL64
            // 
            this.txtToVL64.Location = new System.Drawing.Point(66, 86);
            this.txtToVL64.Name = "txtToVL64";
            this.txtToVL64.Size = new System.Drawing.Size(100, 20);
            this.txtToVL64.TabIndex = 5;
            this.txtToVL64.Text = "1337";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "To VL64:";
            // 
            // btnFromB64
            // 
            this.btnFromB64.Location = new System.Drawing.Point(192, 47);
            this.btnFromB64.Name = "btnFromB64";
            this.btnFromB64.Size = new System.Drawing.Size(158, 23);
            this.btnFromB64.TabIndex = 8;
            this.btnFromB64.Text = "Convert from B64";
            this.btnFromB64.UseVisualStyleBackColor = true;
            this.btnFromB64.Click += new System.EventHandler(this.btnFromB64_Click);
            // 
            // btnToB64
            // 
            this.btnToB64.Location = new System.Drawing.Point(18, 47);
            this.btnToB64.Name = "btnToB64";
            this.btnToB64.Size = new System.Drawing.Size(148, 23);
            this.btnToB64.TabIndex = 9;
            this.btnToB64.Text = "Convert to B64";
            this.btnToB64.UseVisualStyleBackColor = true;
            this.btnToB64.Click += new System.EventHandler(this.btnToB64_Click);
            // 
            // btnToVL64
            // 
            this.btnToVL64.Location = new System.Drawing.Point(18, 123);
            this.btnToVL64.Name = "btnToVL64";
            this.btnToVL64.Size = new System.Drawing.Size(148, 23);
            this.btnToVL64.TabIndex = 11;
            this.btnToVL64.Text = "Convert to VL64";
            this.btnToVL64.UseVisualStyleBackColor = true;
            this.btnToVL64.Click += new System.EventHandler(this.btnToVL64_Click);
            // 
            // btnFromVL64
            // 
            this.btnFromVL64.Location = new System.Drawing.Point(192, 123);
            this.btnFromVL64.Name = "btnFromVL64";
            this.btnFromVL64.Size = new System.Drawing.Size(158, 23);
            this.btnFromVL64.TabIndex = 10;
            this.btnFromVL64.Text = "Convert from VL64";
            this.btnFromVL64.UseVisualStyleBackColor = true;
            this.btnFromVL64.Click += new System.EventHandler(this.btnFromVL64_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 249);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDecodeOutput);
            this.tabPage1.Controls.Add(this.btnDecode);
            this.tabPage1.Controls.Add(this.txtVL64);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VL64 Analyser";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDecodeOutput
            // 
            this.txtDecodeOutput.Location = new System.Drawing.Point(8, 90);
            this.txtDecodeOutput.Multiline = true;
            this.txtDecodeOutput.Name = "txtDecodeOutput";
            this.txtDecodeOutput.ReadOnly = true;
            this.txtDecodeOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecodeOutput.Size = new System.Drawing.Size(355, 127);
            this.txtDecodeOutput.TabIndex = 3;
            this.txtDecodeOutput.WordWrap = false;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(8, 58);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(355, 26);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Decode \'n\' split";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtVL64
            // 
            this.txtVL64.Location = new System.Drawing.Point(8, 32);
            this.txtVL64.Name = "txtVL64";
            this.txtVL64.Size = new System.Drawing.Size(355, 20);
            this.txtVL64.TabIndex = 1;
            this.txtVL64.Text = "HIJKQAPASAYNE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "VL64 number string:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnToVL64);
            this.tabPage2.Controls.Add(this.txtToB64);
            this.tabPage2.Controls.Add(this.btnFromVL64);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnToB64);
            this.tabPage2.Controls.Add(this.txtFromB64);
            this.tabPage2.Controls.Add(this.btnFromB64);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtFromVL64);
            this.tabPage2.Controls.Add(this.txtToVL64);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VL64 & B64 Encoder/Decoder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ClassicPacketScout - By Quackster";
            this.Load += new System.EventHandler(this.frmEncoder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToB64;
        private System.Windows.Forms.TextBox txtFromB64;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromVL64;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToVL64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFromB64;
        private System.Windows.Forms.Button btnToB64;
        private System.Windows.Forms.Button btnToVL64;
        private System.Windows.Forms.Button btnFromVL64;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecodeOutput;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtVL64;
    }
}

