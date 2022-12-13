using DSharpMcTestface.Helpers;
using DSharpMcTestface.Interfaces;
using DSharpMcTestface.Modules;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.SlashCommands;

namespace DSharpMcTestface;

public class Bot : IBot
{
    private DiscordClient? Client { get; set; }

    public async Task StartAsync()
    {
        Client = InitBotAsync();
        RegisterCommands();
        await Client.ConnectAsync();
    }

    public virtual async Task StopAsync()
    {
        if (Client != null)
        {
            await Client.DisconnectAsync();
        }
    }

    public void Dispose()
    {
        Client?.Dispose();
    }

    private void RegisterCommands()
    {
        var commands = Client.UseSlashCommands();
        commands.RegisterCommands<SlashCleanup>(1052284702574256128);
    }

    private async Task ClientOnGuildDownloadCompletedAsync(DiscordClient sender, GuildDownloadCompletedEventArgs e)
    {
        if (Client != null)
        {
            await new StartupHelper(Client).SendStartupMessageAsync();
        }
    }

    private DiscordClient InitBotAsync()
    {
        var client = new DiscordClient(new DiscordConfiguration
        {
            Token = Environment.GetEnvironmentVariable("TOKEN"),
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.Guilds
        });

        client.GuildDownloadCompleted += ClientOnGuildDownloadCompletedAsync;
        return client;
    }
}