namespace Send_Email_SMTP
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
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.tboxTo = new System.Windows.Forms.TextBox();
            this.tboxSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btdSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(273, 60);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(320, 22);
            this.tboxPassword.TabIndex = 11;
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(273, 23);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(320, 22);
            this.tboxUser.TabIndex = 12;
            // 
            // tboxTo
            // 
            this.tboxTo.Location = new System.Drawing.Point(273, 113);
            this.tboxTo.Name = "tboxTo";
            this.tboxTo.Size = new System.Drawing.Size(320, 22);
            this.tboxTo.TabIndex = 13;
            // 
            // tboxSubject
            // 
            this.tboxSubject.Location = new System.Drawing.Point(89, 141);
            this.tboxSubject.Name = "tboxSubject";
            this.tboxSubject.Size = new System.Drawing.Size(654, 22);
            this.tboxSubject.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "PasswordApp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username@";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subject";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(89, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(654, 288);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btdSend
            // 
            this.btdSend.Location = new System.Drawing.Point(29, 23);
            this.btdSend.Name = "btdSend";
            this.btdSend.Size = new System.Drawing.Size(109, 46);
            this.btdSend.TabIndex = 4;
            this.btdSend.Text = "Send";
            this.btdSend.UseVisualStyleBackColor = true;
            this.btdSend.Click += new System.EventHandler(this.btdSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 478);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUser);
            this.Controls.Add(this.tboxTo);
            this.Controls.Add(this.tboxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btdSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.TextBox tboxTo;
        private System.Windows.Forms.TextBox tboxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btdSend;
    }
}

