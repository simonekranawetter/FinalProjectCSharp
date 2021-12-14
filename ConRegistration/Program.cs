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
            break;
        case 3:
            break;
        case 4:
            comicCon = menu.LoadTextFile();
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }
}