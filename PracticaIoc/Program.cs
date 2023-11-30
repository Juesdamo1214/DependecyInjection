using PracticaIoc;
using PracticaIoc.Interface;
using PracticaIoc.Services;

class Program
{
    static void Main()
    {

        var service = new ServiceCollection().
        AddScoped<IEmail, Email>().
        AddTransient<ICall, Call>().
        AddSingleton<IMessage, Message>().
        BuildServiceProvider();
    
        var serviceEmail = service.GetRequiredService<IEmail>();
        var serviceCall = service.GetRequiredService<ICall>();
        var serviceMessage = service.GetRequiredService<IMessage>();

        var email = new ServiceEmail(serviceEmail);
        var call = new ServiceCall(serviceCall);
        var message = new ServiceMessage(serviceMessage);

        email.SendEmail("opi@example.com", "Llego diciembre", "Tuturuma");
        call.Call(1234567890, "Se encuentra en estos momentos ocupado,Deja un mensaje de voz");
        message.Message(123456789, "Usted ha sido el ganador de 10.000.000 para reclamarlos entre al siguiente  link Estafado.com");
    }
}