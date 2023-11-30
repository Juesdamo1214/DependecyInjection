using PracticaIoc.Interface;

namespace PracticaIoc
{
    public class ServiceCall
    {
        private readonly ICall _call;

        public ServiceCall(ICall call)
        {
            _call = call;
        }

        public void Call(int number, string voiceMessage)
        {
            _call.Called(number, voiceMessage);
        }

    }
}
