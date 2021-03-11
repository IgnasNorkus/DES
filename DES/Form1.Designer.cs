namespace DES
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dKeytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decryptedTexttb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dTexttb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eKeytb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedTexttb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eTexttb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 41);
            this.button4.TabIndex = 31;
            this.button4.Text = "Decrypt CBC ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 30;
            this.button3.Text = "Encrypt CBC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Key";
            // 
            // dKeytb
            // 
            this.dKeytb.Location = new System.Drawing.Point(458, 144);
            this.dKeytb.Name = "dKeytb";
            this.dKeytb.Size = new System.Drawing.Size(248, 22);
            this.dKeytb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Encrypted text";
            // 
            // decryptedTexttb
            // 
            this.decryptedTexttb.Location = new System.Drawing.Point(458, 221);
            this.decryptedTexttb.Name = "decryptedTexttb";
            this.decryptedTexttb.Size = new System.Drawing.Size(248, 22);
            this.decryptedTexttb.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Decrypt ECB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Text";
            // 
            // dTexttb
            // 
            this.dTexttb.Location = new System.Drawing.Point(458, 81);
            this.dTexttb.Name = "dTexttb";
            this.dTexttb.Size = new System.Drawing.Size(248, 22);
            this.dTexttb.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Key";
            // 
            // eKeytb
            // 
            this.eKeytb.Location = new System.Drawing.Point(64, 144);
            this.eKeytb.Name = "eKeytb";
            this.eKeytb.Size = new System.Drawing.Size(248, 22);
            this.eKeytb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Encrypted text";
            // 
            // encryptedTexttb
            // 
            this.encryptedTexttb.Location = new System.Drawing.Point(64, 221);
            this.encryptedTexttb.Name = "encryptedTexttb";
            this.encryptedTexttb.Size = new System.Drawing.Size(248, 22);
            this.encryptedTexttb.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Encrypt ECB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Text";
            // 
            // eTexttb
            // 
            this.eTexttb.Location = new System.Drawing.Point(64, 81);
            this.eTexttb.Name = "eTexttb";
            this.eTexttb.Size = new System.Drawing.Size(248, 22);
            this.eTexttb.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 478);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dKeytb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptedTexttb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTexttb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eKeytb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptedTexttb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eTexttb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dKeytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decryptedTexttb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dTexttb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eKeytb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptedTexttb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eTexttb;
    }
}

