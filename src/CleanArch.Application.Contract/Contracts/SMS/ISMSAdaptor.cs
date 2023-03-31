namespace CleanArch.Application;

public interface ISMSAdaptor
{
    public Task SendAsync(string number, string message, CancellationToken cancellationToken = default);
}
