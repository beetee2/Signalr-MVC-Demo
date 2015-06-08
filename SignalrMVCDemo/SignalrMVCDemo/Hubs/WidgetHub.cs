using Microsoft.AspNet.SignalR;

namespace SignalrMVCDemo.Hubs
{
    public class WidgetHub : Hub
    {
        public static int WidgetCount { get; set; }
    }
}