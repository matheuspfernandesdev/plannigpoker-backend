using PlanningPokerChatServer.SignalRHub;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(p =>
{
    p.WithOrigins("http://localhost:4200")
     .AllowAnyHeader()
     .AllowAnyMethod()
     .AllowCredentials();
});

app.MapHub<Chat>("/chat");
app.MapGet("/", () => "Backend Planning Poker est� rodando!");

app.Run();
