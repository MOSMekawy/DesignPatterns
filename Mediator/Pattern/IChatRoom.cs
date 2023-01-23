namespace Mediator.Pattern
{
    public interface IChatRoom
    {
        public void Register(TeamMember teamMember);
        public void Send(string from, string message);
    }
}
