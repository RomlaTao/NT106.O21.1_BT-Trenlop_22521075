namespace Chat_UDP
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
            this.btdListen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPortB = new System.Windows.Forms.TextBox();
            this.tboxIPB = new System.Windows.Forms.TextBox();
            this.tboxMessage = new System.Windows.Forms.TextBox();
            this.btdSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPortA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btdListen
            // 
            this.btdListen.Location = new System.Drawing.Point(658, 25);
            this.btdListen.Name = "btdListen";
            this.btdListen.Size = new System.Drawing.Size(120, 32);
            this.btdListen.TabIndex = 0;
            this.btdListen.Text = "Lắng nghe kết nối";
            this.btdListen.UseVisualStyleBackColor = true;
            this.btdListen.Click += new System.EventHandler(this.btdListen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(500, 303);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tin nhắn ";
            // 
            // tboxPortB
            // 
            this.tboxPortB.Location = new System.Drawing.Point(658, 235);
            this.tboxPortB.Name = "tboxPortB";
            this.tboxPortB.Size = new System.Drawing.Size(120, 22);
            this.tboxPortB.TabIndex = 3;
            // 
            // tboxIPB
            // 
            this.tboxIPB.Location = new System.Drawing.Point(658, 288);
            this.tboxIPB.Name = "tboxIPB";
            this.tboxIPB.Size = new System.Drawing.Size(120, 22);
            this.tboxIPB.TabIndex = 3;
            // 
            // tboxMessage
            // 
            this.tboxMessage.Location = new System.Drawing.Point(119, 401);
            this.tboxMessage.Name = "tboxMessage";
            this.tboxMessage.Size = new System.Drawing.Size(409, 22);
            this.tboxMessage.TabIndex = 3;
            // 
            // btdSend
            // 
            this.btdSend.Location = new System.Drawing.Point(585, 404);
            this.btdSend.Name = "btdSend";
            this.btdSend.Size = new System.Drawing.Size(108, 23);
            this.btdSend.TabIndex = 0;
            this.btdSend.Text = "Gửi";
            this.btdSend.UseVisualStyleBackColor = true;
            this.btdSend.Click += new System.EventHandler(this.btdSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tin nhắn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cổng truy xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ truy xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cổng kết nối";
            // 
            // tboxPortA
            // 
            this.tboxPortA.Location = new System.Drawing.Point(658, 142);
            this.tboxPortA.Name = "tboxPortA";
            this.tboxPortA.Size = new System.Drawing.Size(120, 22);
            this.tboxPortA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập tên người dùng";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(550, 91);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(228, 22);
            this.tboxName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxIPB);
            this.Controls.Add(this.tboxMessage);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxPortA);
            this.Controls.Add(this.tboxPortB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btdSend);
            this.Controls.Add(this.btdListen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdListen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPortB;
        private System.Windows.Forms.TextBox tboxIPB;
        private System.Windows.Forms.TextBox tboxMessage;
        private System.Windows.Forms.Button btdSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPortA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxName;
    }
}

