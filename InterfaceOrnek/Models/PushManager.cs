using System;

namespace InterfaceOrnek.Models
{
    public class PushManager:INotificator
    {
        public MessageStates MessageState { get; set; }
        public void Send(MessageBase message)
        {
            //push notify. ayarlari ayarlari yapilir
            MessageState = MessageStates.Pending;
            try
            {
                PushMessage push = message as PushMessage;

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
