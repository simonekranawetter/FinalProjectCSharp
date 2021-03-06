using System.Text;
using static System.Console;

namespace ComicConRegistration
{
    public class ComicCon
    {
        private List<Participant> _participantList = new List<Participant>();

        /// <summary>
        /// Constructor for a list of participants
        /// </summary>
        public List<Participant> Participants
        {
            get
            {
                return _participantList;
            }
        }

        /// <summary>
        /// Function to add a participant to the list of participants
        /// </summary>
        /// <param name="participant">participant to be added to the list</param>
        public void AddParticipant(Participant participant)
        {
            _participantList.Add(participant);
        }

        /// <summary>
        /// Remove a participant from the list of participants
        /// </summary>
        /// <param name="index">index of the entry you would like to remove</param>
        public void Remove(int index)
        {
            try
            {
                _participantList.RemoveAt(index);
            }
            catch
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Invalid Input.");
                ForegroundColor = ConsoleColor.Magenta;
            }
        }

        /// <summary>
        /// Creates a discount code
        /// </summary>
        /// <returns>Guid</returns>
        public static Guid CreateDiscountCode()
        {
            var discountCode = Guid.NewGuid();
            return discountCode;
        }

        /// <summary>
        /// Saves the list of participants to a text file
        /// </summary>
        /// <param name="path">desired file path</param>
        public void Save(string path)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var participant in _participantList)
            {
                 sb.AppendLine($"{participant.FirstName} {participant.LastName} {participant.Email} {participant.FavoriteSuperhero} {participant.FavoriteQuote}");
            }

            var inputToSave = sb.ToString();
            try
            {
                File.WriteAllText(path, inputToSave);
                WriteLine($"\nFile saved at:   {path}");
            }
            catch (Exception)
            {
                ForegroundColor= ConsoleColor.DarkRed;
                WriteLine("Filepath is invalid! File not saved!");
            }
        }
    }
}
