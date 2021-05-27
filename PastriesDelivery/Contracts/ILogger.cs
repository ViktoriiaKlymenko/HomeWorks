namespace PastriesDelivery
{
    public interface ILogger
    {
        void LogChanges(string message);

        void CreateFile();
    }
}