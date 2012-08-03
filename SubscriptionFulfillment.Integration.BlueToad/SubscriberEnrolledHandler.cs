using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using SubscriptionFulfillment.Messages.Events;

namespace SubscriptionFulfillment.Integration.BlueToad
{
    public class SubscriberEnrolledHandler : IHandleMessages<ISubscriberEnrolled>
    {
        public void Handle(ISubscriberEnrolled message)
        {
            //TODO: communicate to Blue Toad
            Console.WriteLine("Enrolled Subscriber on Blue Toad: {0}", message.SubscriberId);
        }
    }
}
