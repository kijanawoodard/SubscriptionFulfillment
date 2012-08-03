using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubscriptionFulfillment.Messages.Events
{
    public interface ISubscriberEnrolled
    {
        string SubscriberId { get; set; }
    }
}
