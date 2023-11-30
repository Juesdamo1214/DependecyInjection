using PracticaIoc.Interface;

namespace PracticaIoc.Services
{
    public class Email : IEmail
    {
        public void SendMail(string Addressee, string subject, string body)
        {
            Console.WriteLine($"Se envio correo a {Addressee} - Asunto: {subject} - Cuerpo: {body}");
        }
    }
}
