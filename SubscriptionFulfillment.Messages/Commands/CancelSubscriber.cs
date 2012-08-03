namespace SubscriptionFulfillment.Messages.Commands
{
    public class CancelSubscriber
    {
        public string SubscriberName { get; set; }

        public override string ToString()
        {
            return string.Format("Cancel SubscriberName: {0}", SubscriberName);
        }
    }
}