namespace Observer.Pattern
{
    // subject
    public abstract class TicketChangeNotifier
    {
        private List<ITicketChangeListener> _observers = new();

        public void AddObserver(ITicketChangeListener observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ITicketChangeListener observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(TicketChange change) 
        {
            _observers.ForEach(o => o.ReceiveTicketChangeNotification(change));        
        }
    }
}
