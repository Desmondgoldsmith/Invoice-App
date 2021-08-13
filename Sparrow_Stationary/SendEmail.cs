using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace Sparrow_Stationary
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var from = textBox1.Text;
            //var to = textBox2.Text;
            //var message = textBox3.Text;
            //var smtp = "smtp.gmail.com";
            //MailMessage mail = new MailMessage(from,to,message,message);
            //mail.Attachments.Add(new Attachment(textBox5.Text));

            //SmtpClient client = new SmtpClient(smtp);
            //client.Port = 587;
            //client.Credentials = new NetworkCredential(textBox1.Text,textBox4.Text);
            //client.EnableSsl = true;
            //client.Send(mail);
            //MessageBox.Show("Mail Sent", "Sent", 0, MessageBoxIcon.Information);


            var addressFrom = new MailAddress(textBox1.Text);
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials =
                            new NetworkCredential(addressFrom.Address, textBox4.Text)
            };

            var message = new MailMessage
            {
                Subject = textBox3.Text,
                Body = textBox5.Text,
                From = addressFrom
            };

            var sTo = textBox2.Text; // comma separated

            message.To.Add(sTo);
            smtp.Send(message);
            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog dialog = new OpenFileDialog();
            // image filters  
           // dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               string imglocation = dialog.FileName.ToString();
                // display image in picture box  
                textBox5.Text = imglocation;
                // image file path  
                // textBox1.Text = open.FileName;
            }
        }
    }
}
