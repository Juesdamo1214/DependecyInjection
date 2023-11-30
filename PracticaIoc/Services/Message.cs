using PracticaIoc.Interface;

namespace PracticaIoc.Services
{
    public class Message : IMessage
    {
        public void MessageText(int number, string messageText)
        {
            Console.WriteLine($"Mensaje de: {number} - Mensaje de texto: {messageText}");
        }
    }
}
