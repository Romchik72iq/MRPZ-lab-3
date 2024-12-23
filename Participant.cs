using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPZ3
{
    public class Participant
    {
        public string Name;

        public string ContactInfo;

        public Participant(string name, string contactInfo)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(contactInfo))
                throw new ArgumentException("Contact info cannot be null or empty.", nameof(contactInfo));

            Name = name;
            ContactInfo = contactInfo;
        }
        public Participant() { }
    }
}
