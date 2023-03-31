namespace CleanArch.Application;

public class SMSAdaptor : ISMSAdaptor
{
    public Task SendAsync(string number, string message, CancellationToken cancellationToken = default) => Task.CompletedTask;
}
