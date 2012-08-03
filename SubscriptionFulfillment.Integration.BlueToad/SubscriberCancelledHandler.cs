using System;
using NServiceBus;
using SubscriptionFulfillment.Messages.Events;

namespace SubscriptionFulfillment.Integration.BlueToad
{
    public class SubscriberCancelledHandler : IHandleMessages<ISubscriberCancelled>
    {
        public void Handle(ISubscriberCancelled message)
        {
            //TODO: communicate to Blue Toad
            Console.WriteLine("Cancelled Subscriber on Blue Toad: {0}", message.SubscriberId);
        }
    }
}