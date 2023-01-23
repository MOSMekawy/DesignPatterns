namespace Observer.Pattern
{
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange change)
        {
            Console.WriteLine($"Ticket reseller service got notified of a {change.Amount} tickets sale for artist {change.ArtistId}.");
        }
    }
}
