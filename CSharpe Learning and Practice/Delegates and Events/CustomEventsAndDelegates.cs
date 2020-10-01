using System;
using System.Threading;

namespace Delegates_and_Events
{
    class CustomEventsAndDelegates
    {
    }
}

namespace CustomEventsAndDelegates
{
    public class Events
    {
        // An events is a mechanism for commmunication between objetcs
        //why - Helps in builing loosly couple applcaition
        // Helps extending the application
        // and delegates helps providing the  contract between  Publisher(event sender) and subscriber (event receiver)
        //Delegates determines the signature of the event handler method in subscriber

    }

    public class Video
    {
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string Video_Quality { get; set; }
    }
    public class VideoEncoder
    {
        //Now give this class ot publish an event to notify anyone who is interesting in that event
        //three steps are required
        //1. define the delegate for agreement
        //2. define an event based on that delegate
        //3. raise the event
        /*Typically in .Net we have convention for event handler that first parameter should be an object 
         * (source of the event/class which is sending the event)
           and second parameter is additional data if need to send  
           and eventhandler name should be eventname + EventHandler*/

        //delegates hold the reference of a function which looks like similar to the Delegates
        //step 1. Delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs e);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);


        //Well, we have simpler way to achieve the same outcome.
        //we don't need to specify our own  delegate
        //MS it self provided delegate for Event Handler
        //two forms
        //1. normal       - EventHandler
        //2. Genericc form - EVentHandler
        public EventHandler<VideoEventArgs> VideoEncodedEventHandlerDefault;

        //without sending any data
        public EventHandler VideoEncodedEventHandlerDefaultWithouAdditionalData;

        //step 2. Event based on the delegate
        // public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        //withoutany additional data
        public event EventHandler VideoEncoding;

        //step 3. Raise the event  -  To raise an event we need a method which is responsible for that.
        /*In .Net we have convention - your event publisher method should be protected,
         * virtual and void and naming should be  liek - start with On and  name of the event - OnVideoEncoded 
        */

        protected virtual void OnVideoEncoded(Video video)
        {
            //checking if event has any subscriber
            if (VideoEncoded != null)
            {
                // we need treat this as method call
                //source of the event -  this class // additional data is nothing so use EvenTaArgs.empty
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { _Video = video });

            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine($"Your video {video.Title}, which is {video.Length} seconds long is encoding...");
            Thread.Sleep(4000);
            OnVideoEncoded(video);
        }

        //sending the emails after video Encoded

    }


}
