using PracticaIoc.Interface;

namespace PracticaIoc.Services
{
    public class Call : ICall
    {
        public void Called(int number, string voiceMessage)
        {
            Console.WriteLine($"Llamada al numero: {number} - Mensaje de Voz {voiceMessage}");
        }
    }
}
