namespace DSharpMcTestface.Interfaces;

public interface IBot
{
    Task StartAsync();
    Task StopAsync();
    void Dispose();
}