using DSharpMcTestface.Interfaces;

namespace DSharpMcTestface.Services;

public class BotService<T> : IHostedService, IDisposable where T : IBot
{
    private readonly T _bot;

    public BotService(T bot)
    {
        _bot = bot;
    }

    public void Dispose()
    {
        _bot.Dispose();
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _bot.StartAsync();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await _bot.StopAsync();
    }
}