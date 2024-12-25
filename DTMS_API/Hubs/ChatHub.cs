using Microsoft.AspNetCore.SignalR;

namespace DTMS_API.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(message))
            {
                throw new HubException("User or message cannot be null or empty.");
            }

            // Send the message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
