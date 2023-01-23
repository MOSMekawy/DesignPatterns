namespace Mediator.Pattern
{
    public abstract class TeamMember 
    {
        private IChatRoom? _chatRoom;
        public string Name { get; }

        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatRoom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom?.Send(Name, message);
        }
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"Message from {from} to {Name}: {message}");
        }
    }
}
