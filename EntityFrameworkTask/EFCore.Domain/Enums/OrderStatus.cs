namespace EntityFrameworkTask
{
    public enum OrderStatus
    {
        ProcessingStock,
        ReadyForPacking,
        ReadyToDeliver,
        DeliveryInProgress,
        Delivered,
        Received,
        Returned
    }
}