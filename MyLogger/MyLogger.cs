namespace MyLogger
{
    public class MyLogger : IMyLogger
    {
        public MyLogger()
        {
            
        }

        public async Task Log(string message)
        {
            await File.WriteAllTextAsync("myLogger.txt", message);
        }

    }
}
