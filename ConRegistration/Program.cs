using ComicConRegistration;

var comicCon = new ComicCon();
var menu = new Menu();

bool runProgram = true;

while (runProgram)
{
    var choice = menu.MainMenu();

    switch (choice)
    {
        case 1:
            var participant = menu.AddParticipant();
            comicCon.AddParticipant(participant);
            break;
        case 2:
            var index = menu.RemoveParticipant(comicCon.Participants);
            if (index != -1)
            {
                comicCon.Remove(index);
            }
            break;
        case 3:
            menu.ListParticipants(comicCon.Participants);
            break;
        case 4:
            comicCon = menu.LoadTextFile();
            break;
        case 5:
            var path = menu.SaveTextFile();
            comicCon.Save(path);
            break;
        case 6:
            menu.DiscountCode();
            break;
        case 7:
            runProgram = false;
            Console.WriteLine("Bye! Have a great day! (^_^) c[_]");
            break;
        default:
            break;
    }
}