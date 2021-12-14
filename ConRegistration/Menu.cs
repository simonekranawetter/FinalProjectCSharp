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
                WriteLine("   ~~Welcome to ComicCon 2021~~      \n");
                WriteLine("1. Add a new Participant to the Con");
                WriteLine("2. Remove Participant from the Con");
                WriteLine("3. List all Participants of the Con");
                WriteLine("4. Load ComicCon Registration File");
                WriteLine("5. Save to File");
                WriteLine("6. Exit the Program");

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

        internal Participant AddParticipant()
        {
            WriteLine("Enter Participant information for the ComicCon attendee patch!\n");

            Write("First Name:");
            var firstName = ReadLine();

            Write("Last Name:");
            var lastName = ReadLine();

            Write("Email:");
            var email = ReadLine();

            Write("Favorite Superhero:");
            var favoriteSuperhero = ReadLine();

            Write("Favorite Quote:");
            var favoriteQuote = ReadLine();

            return new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);
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
    }
}
