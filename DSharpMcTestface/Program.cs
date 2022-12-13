using DSharpMcTestface;
using DSharpMcTestface.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Bot>();
builder.Services.AddHostedService<BotService<Bot>>();

var app = builder.Build();

app.Run();