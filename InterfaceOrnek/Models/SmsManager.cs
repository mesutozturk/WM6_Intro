using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsManager : INotificator
    {
        public MessageStates MessageState { get; set; }
        public void Send(MessageBase message)
        {
            //sms ayarlari yapilir
            MessageState = MessageStates.Pending;
            try
            {
                SmsMessage sms = message as SmsMessage;
                
                MessageState = MessageStates.Sent;
            }
            catch (Exception ex)
            {
                MessageState = MessageStates.Failed;
                throw ex;
            }
        }
    }
}
