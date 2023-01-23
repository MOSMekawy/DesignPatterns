namespace Observer.Pattern
{
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange change);
    }
}