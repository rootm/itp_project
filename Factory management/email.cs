using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace Factory_management
{
    public partial class email : Form
    {
        private string emailid;
        public email(string emailid)
        {
            this.emailid = emailid;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = emailid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            
         
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName.ToString();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("homiedvr1995@gmail.com", "interactive1995");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("homiedvr1995@gmail.com");
                msg.Subject = (textBox4.Text);
                if (textBox2.Text != null)
                {
                    msg.Attachments.Add(new Attachment(textBox2.Text)); //Adding attachment
                }


                msg.Body = richTextBox1.Text;
                client.Send(msg);

                MessageBox.Show("Successfully send!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sending Failed!");
            }
        }
    }
}
