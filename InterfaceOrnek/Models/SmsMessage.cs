using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsMessage : MessageBase
    {
        private string _body, _sender;

        public override string Body
        {
            get => _body;
            set
            {
                if (value.Length > 160)
                    throw new Exception("160 karakterden fazla sms gonderemezsiniz");
                _body = value;
            }
        }

        public override string Sender
        {
            get => _sender;
            set
            {
                if (value.Length > 12)
                    throw new Exception("12 karakterden fazla gonderici bilgisi ekleyemezsiniz");
                _sender = value;
            }
        }
    }
}
