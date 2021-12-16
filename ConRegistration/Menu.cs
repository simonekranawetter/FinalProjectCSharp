using static System.Console;

namespace ComicConRegistration
{
    internal class Menu
    {   /// <summary>
        /// Gives the user different choices to add, remove and display all participants. Saving and loading a text file and creating a discount code.
        /// </summary>
        /// <returns>Preferred menu choice</returns>
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
                WriteLine("7. Exit the Program\n\n");

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
                ErrorMessage("Please input a number from 1 - 7 to chose a menu option");
            }
        }
        /// <summary>
        /// Asking the user for input to add a participant to the list.
        /// </summary>
        /// <returns>A new participant object</returns>
        internal Participant AddParticipant()         {
            WriteLine("Enter Participant information for the ComicCon attendee patch!\n");

            Write("First Name:");
            var firstName = ReadLine() ?? "";
            RequiresInput(firstName, "First Name is required");

            Write("Last Name:");
            var lastName = ReadLine() ?? "";
            RequiresInput(lastName, "Last Name is required");

            Write("Email:");
            var email = ReadLine() ?? "";
            RequiresInput(email, "Email is required");

            Write("Favorite Superhero:");
            var favoriteSuperhero = ReadLine() ?? "not specified";
            favoriteSuperhero.Trim();

            Write("Favorite Quote:");
            var favoriteQuote = ReadLine() ?? "All your base are belong to us";
            favoriteQuote.Trim();

            return new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);
        }
        /// <summary>
        /// Lists the participants entered so far and lets the user pick the index of the desired entry
        /// </summary>
        /// <param name="participants">The list of participants</param>
        /// <returns>Removes the desired index from the list</returns>
        internal int RemoveParticipant(List<Participant> participants)
        {
            ListParticipants(participants);
            WriteLine("Enter the index of the participant you'd like to remove");
            while (true)
            {
                var index = ReadLine();

                if (!string.IsNullOrEmpty(index))
                {
                    try
                    {
                        var entryIndex = int.Parse(index);

                        return entryIndex;
                    }
                    catch (Exception)
                    {
                    }
                }
                ErrorMessage("Enter the number of the entry you would like to remove");
            }
        }
        /// <summary>
        /// Printing a list of participants to the console. Only relevant information (Name and email) and an index for easy selection is printed 
        /// </summary>
        /// <param name="particpants"></param>
        internal void ListParticipants(List<Participant> particpants)
        {
            int index = 0;
            foreach (var participant in particpants)
            {
                WriteLine($"{index}. - {participant.FirstName} {participant.LastName}, {participant.Email}\n\n");
                index++;
            }
            if (particpants.Count == 0)
            {
                WriteLine("You haven't added any participants yet");
            }
        }
        /// <summary>
        /// Asks the user for the file path to a previously saved copy
        /// </summary>
        /// <returns>A detailed list with all the information saved in the file</returns>
        internal ComicCon LoadTextFile()
        {
            WriteLine("Load a copy of the registration previously saved to your computer");
            WriteLine("If no path is given, a default path to your C drive will be created.");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter your file path:");
            ForegroundColor = ConsoleColor.Magenta;
            var path = ReadLine() ?? @"C:\conregistration.txt";

            string[] lines = File.ReadAllLines(path);

            var comicCon = new ComicCon();

            foreach (var line in lines)
            {
                var input = line.Split(' ');
                var firstName = input[0];
                var lastName = input[1];
                var email = input[2];
                var favoriteSuperhero = input[3];
                var favoriteQuote = input[4];

                var participant = new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);
                comicCon.AddParticipant(participant);
            }

            return comicCon;
        }
        /// <summary>
        /// Asks user to enter a file path to the console
        /// </summary>
        /// <returns>A text file at the desired path</returns>
        internal string SaveTextFile()
        {
            WriteLine("Save a personal copy of the registration to your computer\n");
            WriteLine("If no path is given, a default path to your C drive will be created.");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Please enter a file path:");
            ForegroundColor = ConsoleColor.Magenta;
            var path = ReadLine() ?? @"C:\conregistration.txt";

            return path;
        }
        /// <summary>
        /// Prints a discount code to the console
        /// </summary>
        internal void DiscountCode()
        {
            WriteLine("Send this discount code to participant if requested");
            WriteLine(ComicCon.CreateDiscountCode());
        }
        /// <summary>
        /// Prints a red error message to the console
        /// </summary>
        /// <param name="message">A string specifying the error encountered</param>
        private static void ErrorMessage(string message)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine(message);
            ForegroundColor = ConsoleColor.Magenta;
        }
        /// <summary>
        /// Handles the possibility of nullable inputs
        /// </summary>
        /// <param name="input">Requires the user to enter something</param>
        /// <param name="message">Specifies the error message displayed with the error</param>
        /// <returns>The required input after whitespace is removed</returns>
        private static string RequiresInput(string input, string message)
        {
            while (string.IsNullOrEmpty(input))
            {
                ErrorMessage(message);
                input = ReadLine() ?? "";
            }
            return input.Trim();
        }
    }
}
