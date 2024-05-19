using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Email_SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btdSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        public void Send()
        {
            try
            {
                if (tboxUser.Text == null || tboxPassword.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập tài khoản người dùng và mật khẩu");
                }
                else
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential(tboxUser.Text, tboxPassword.Text);
                    string strFrom = tboxUser.Text;
                    MailMessage message = new MailMessage(strFrom, tboxTo.Text);
                    message.Subject = tboxSubject.Text;
                    message.Body = richTextBox1.Text;

                    mailclient.Send(message);
                    MessageBox.Show("Mail đã được gửi đi");
                }
            }
            catch
            {
                MessageBox.Show("Gửi Mail không thành công");
            }
        }
    }
}
