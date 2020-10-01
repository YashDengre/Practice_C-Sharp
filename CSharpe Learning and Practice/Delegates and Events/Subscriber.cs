using System;

namespace CustomEventsAndDelegates
{
    class Subscriber
    {
    }
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Mail Service : Sending an email..." + e._Video.Title);
        }
        //now we have to subscribe to the event
    }
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Message Service : Sending a message... " + e._Video.Title);
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video _Video { get; set; }
    }
}
