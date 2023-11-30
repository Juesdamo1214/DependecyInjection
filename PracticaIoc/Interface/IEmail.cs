namespace PracticaIoc.Interface
{
    public interface IEmail
    {
        void SendMail(string Addressee, string subject, string body);
    }
}
