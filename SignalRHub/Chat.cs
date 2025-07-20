using Microsoft.AspNetCore.SignalR;

namespace PlanningPokerChatServer.SignalRHub;

public class Chat : Hub
{
    public async Task NewMessage(string userName, string message)
    {
        await Clients.All.SendAsync("newMessage", userName, message);    
    }
}
