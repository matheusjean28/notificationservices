using Microsoft.AspNetCore.SignalR;

namespace NotificationHubHubs
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string user, string message)
        {
            await Clients.All.SendAsync("ReciveNotification", user, message);
        }
    }
}