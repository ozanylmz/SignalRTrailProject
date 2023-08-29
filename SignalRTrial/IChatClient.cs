namespace SignalRTrial
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
