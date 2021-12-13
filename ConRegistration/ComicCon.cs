using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicConRegistration
{
    public class ComicCon
    {
        private List<Participant> _participantList = new List<Participant>();

        public List<Participant> Participants
        {
            get
            {
                return _participantList;
            }
        }

        public void AddParticipant(Participant participant)
        {
            _participantList.Add(participant);
        }
    }
}
