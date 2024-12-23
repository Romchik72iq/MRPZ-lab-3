using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace MRPZ3
{
    public class TravelGroup
    {
        public List<Participant> Participants = new();

        public void AddParticipant(Participant participant)
        {
            if (participant == null)
                throw new ArgumentNullException(nameof(participant), "Participant cannot be null.");

            if (Participants.Any(p => p.Name == participant.Name))
                throw new InvalidOperationException("Participant already exists.");

            Participants.Add(participant);
        }
        public void RemoveParticipant(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            var participant = Participants.FirstOrDefault(p => p.Name == name);

            if (participant == null)
                throw new InvalidOperationException("Participant does not exist.");

            Participants.Remove(participant);
        }
       
        public List<Participant> GetAllParticipants()
         {
             return new List<Participant>(Participants);
         }
    }
}
