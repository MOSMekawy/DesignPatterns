namespace Observer.Pattern
{
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange change)
        {
            Console.WriteLine($"Ticket stock service got notified of a {change.Amount} tickets sale for artist {change.ArtistId}.");
        }
    }
}
