using PracticaIoc.Interface;

namespace PracticaIoc
{
    public class ServiceEmail
    {
        private readonly IEmail _email;

        public ServiceEmail(IEmail email)
        {
            _email = email;
        }
        public void SendEmail(string Addressee, string subject, string body)
        {
            _email.SendMail(Addressee, subject, body);
        }
    }
}
