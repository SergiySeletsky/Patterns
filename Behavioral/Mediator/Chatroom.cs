using System.Collections;

namespace Patterns.Behavioral.Mediator
{
    internal class Chatroom : AbstractChatroom
    {
        private readonly Hashtable participants = new Hashtable();

        public override void Register(Participant participant)
        {
            if (participants[participant.Name] == null)
            {
                participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(
            string from, string to, string message)
        {
            var pto = (Participant) participants[to];
            if (pto != null)
            {
                pto.Receive(from, message);
            }
        }
    }
}