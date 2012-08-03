using System;
using NServiceBus;
using SubscriptionFulfillment.Messages.Commands;
using SubscriptionFulfillment.Messages.Events;

namespace SubscriptionFulfillment.Processor
{
    public class CancelSubscriberHandler : IHandleMessages<CancelSubscriber>
    {
        public IBus Bus { get; set; }

        public void Handle(CancelSubscriber message)
        {
            //TODO: write to database; in the meantime pretend
            Bus.Publish<ISubscriberCancelled>(x => x.SubscriberId = "subscribers/" + message.SubscriberName);
            Console.WriteLine("Subscriber Cancelled: {0}", message);
        }
    }
}