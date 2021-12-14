using static System.Console;

namespace ComicConRegistration
{
    internal class Menu
    {
        public int MainMenu()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("\n\n   ~~Welcome to ComicCon 2021~~      \n");
                WriteLine("1. Add a new Participant to the Con");
                WriteLine("2. Remove Participant from the Con");
                WriteLine("3. List all Participants of the Con");
                WriteLine("4. Load ComicCon Registration File");
                WriteLine("5. Save to File");
                WriteLine("6. Create a discount code");
                WriteLine("7. Exit the Program");

                var input = ReadLine();
                Clear();

                if (!string.IsNullOrEmpty(input))
                {
                    try
                    {
                        var choice = int.Parse(input);
                        return choice;
                    }
                    catch (Exception)
                    {

                    }
                }
                WriteLine("Hi mom!"); //TODO: fix error handling here!
            }
        }

        internal Participant AddParticipant() //TODO: hello there readline null references. (╯°□°）╯︵ ┻━┻
        {
            WriteLine("Enter Participant information for the ComicCon attendee patch!\n");

            Write("First Name:");
            var firstName = ReadLine().Trim();

            Write("Last Name:");
            var lastName = ReadLine().Trim();

            Write("Email:");
            var email = ReadLine().Trim();

            Write("Favorite Superhero:");
            var favoriteSuperhero = ReadLine().Trim();

            Write("Favorite Quote:");
            var favoriteQuote = ReadLine().Trim();

            return new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);
        }

        internal int RemoveParticipant(List<Participant> participants)
        {
            ListParticipants(participants);
            WriteLine("Enter the index of the participant you'd like to remove");

            int index = int.Parse(ReadLine());

            return index;
        }

        internal void ListParticipants(List<Participant> particpants)
        {
            int index = 0;
            foreach (var participant in particpants)
            {
                WriteLine($"{index}. - {participant.FirstName} {participant.LastName}, {participant.Email}\n\n");
                index++;
            }
        }

        internal ComicCon LoadTextFile()
        {
            WriteLine("Save a personal copy of the registration to your computer\n");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter your file path:");
            ResetColor();
            var path = ReadLine(); //TODO: handle possible error here!
           
            string[]? lines = File.ReadAllLines(path);

            var comicCon = new ComicCon();

            foreach (var line in lines)
            {
                var input = line.Split(' ');
                var firstName = input[0];
                var lastName = input[1];
                var email = input[2];
                var favoriteSuperhero = input[3];
                var favoriteQuote = input[4];

                var participant = new Participant (firstName,lastName,email,favoriteSuperhero,favoriteQuote);
                comicCon.AddParticipant (participant);
            }

            return comicCon;
        }

        internal string SaveTextFile()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Please enter a file path:");
            ResetColor ();
            var path = ReadLine();

            return path;
        }
        
        internal void DiscountCode()
        {
            WriteLine("Send this discount code to participant if requested");
            WriteLine(ComicCon.CreateDiscountCode());
        }
    }
}
