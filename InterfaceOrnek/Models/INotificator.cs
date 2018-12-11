namespace InterfaceOrnek.Models
{
    public interface INotificator
    {
        MessageStates MessageState { get; set; }
        void Send(MessageBase message);
    }
}
