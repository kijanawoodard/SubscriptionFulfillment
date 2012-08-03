namespace SubscriptionFulfillment.Messages.Commands
{
    public class EnrollSubscriber
    {
        public string SubscriberName { get; set; }

        public override string ToString()
        {
            return string.Format("Enroll SubscriberName: {0}", SubscriberName);
        }
    }
}
