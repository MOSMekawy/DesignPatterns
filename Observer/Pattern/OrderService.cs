namespace Observer.Pattern
{
    public class OrderService : TicketChangeNotifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            Console.WriteLine($"Completing {amount} ticket sale for artist id {artistId}");
            NotifyObservers(new TicketChange(artistId, amount));
        }
    }
}
