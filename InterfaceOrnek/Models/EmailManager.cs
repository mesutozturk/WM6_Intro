using System;

namespace InterfaceOrnek.Models
{
    public class EmailManager : INotificator
    {
        public MessageStates MessageState { get; set; }
        public void Send(MessageBase message)
        {
            //email ayarlari ayarlari yapilir
            MessageState = MessageStates.Pending;
            try
            {
                EmailMessage email = message as EmailMessage;

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
