namespace Services.Services
{
    public interface IServiceTest
    {
        public void PrintTypeName();
        public void LogMessage(string message);
    }

    public sealed class FirstService : IServiceTest
    {
        private readonly ILogger<FirstService> _logger;  

        public FirstService(ILogger<FirstService> logger)
        {
            _logger = logger;
        }

        public void PrintTypeName()
        {
            LogMessage($"{GetType().Name}");
        }

        public void LogMessage(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
