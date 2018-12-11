using System;

namespace InterfaceOrnek.Models
{
    public abstract class MessageBase
    {
        protected MessageBase()
        {
            this.MessageDate = DateTime.Now;
        }
        public virtual string Sender { get; set; }
        public virtual string Body { get; set; }
        public DateTime MessageDate { get; private set; }
    }
}
