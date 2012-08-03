namespace SubscriptionFulfillment.Messages.Events
{
    public interface ISubscriberCancelled
    {
        string SubscriberId { get; set; }
    }
}