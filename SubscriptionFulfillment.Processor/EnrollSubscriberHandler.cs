using System;
using NServiceBus;
using SubscriptionFulfillment.Messages.Commands;
using SubscriptionFulfillment.Messages.Events;

namespace SubscriptionFulfillment.Processor
{
    public class EnrollSubscriberHandler : IHandleMessages<EnrollSubscriber>
    {
        public IBus Bus { get; set; }

        public void Handle(EnrollSubscriber message)
        {
            //TODO: write to database; in the meantime pretend
            Bus.Publish<ISubscriberEnrolled>(x => x.SubscriberId = "subscribers/" + message.SubscriberName);
            Console.WriteLine("Subscriber Enrolled: {0}", message);
        }
    }
}
