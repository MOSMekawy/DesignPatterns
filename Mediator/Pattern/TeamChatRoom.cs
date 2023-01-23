namespace Mediator.Pattern
{
    public class TeamChatRoom : IChatRoom
    {
        private readonly Dictionary<string, TeamMember> _teamMembers = new();
        public void Register(TeamMember teamMember)
        {
            teamMember.SetChatRoom(this);
            if (!_teamMembers.ContainsKey(teamMember.Name))
            {
                _teamMembers.Add(teamMember.Name, teamMember);
            }
        }

        public void Send(string from, string message)
        {
            foreach(var member in _teamMembers.Values)
            {
                member.Receive(from, message);
            }
        }
    }
}
