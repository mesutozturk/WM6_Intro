namespace InterfaceOrnek.Models
{
    public class EmailMessage : MessageBase
    {
        public string Subject { get; set; }
        public string[] Ccs { get; set; }
        public string[] Bccs { get; set; }
        public byte[] Attachment { get; set; }
    }
}
