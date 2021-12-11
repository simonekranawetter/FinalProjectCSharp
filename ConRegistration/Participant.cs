using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConRegistration
{   //refactored from commented out class
    public record Participant(string FirstName, string LastName, string Email, string FavoriteSuperhero);
    /*
    public class Participant
    {  
        public Participant(string firstName, string lastName, string email, string favoriteSuperhero)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            FavoriteSuperhero = favoriteSuperhero;
        }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FavoriteSuperhero { get; set; }
        }
    } */
}
