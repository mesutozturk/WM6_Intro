using InterfaceOrnek.Models;
using System;
using System.Windows.Forms;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex < 0) return;

            INotificator notify;
            switch (cmbMethod.SelectedIndex)
            {
                case 0: //sms
                    notify = new SmsManager();
                    MessageBase sms = new SmsMessage()
                    {
                        Body = "sms body",
                        Sender = "sms sender"
                    };
                    notify.Send(sms);
                    break;
                case 1: //email
                    notify = new EmailManager();
                    MessageBase email = new EmailMessage()
                    {
                        Body = "email body",
                        Sender = "email sender",
                        Subject = "email subject"
                    };
                    notify.Send(email);
                    break;
                default: //push
                    notify = new PushManager();
                    MessageBase push = new PushMessage()
                    {
                        Body = "push body",
                        Sender = "push sender",
                        Channel = "push channel"
                    };
                    notify.Send(push);
                    break;
            }
            if (notify.MessageState == MessageStates.Sent)
                MessageBox.Show("Gonderildi");
            
        }
    }
}
