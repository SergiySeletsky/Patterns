using System;

namespace Patterns.Behavioral.Mediator
{
    internal class Participant
    {
        private readonly string name;
        private Chatroom chatroom;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public Chatroom Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }

        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                              from, Name, message);
        }
    }
}