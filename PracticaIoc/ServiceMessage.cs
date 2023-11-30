using PracticaIoc.Interface;

namespace PracticaIoc
{
    public class ServiceMessage
    {
        private readonly IMessage _message;

        public ServiceMessage(IMessage message)
        {
            _message = message;
        }
        public void Message(int number, string messageText)
        {
            _message.MessageText(number, messageText);
        }
    }
}