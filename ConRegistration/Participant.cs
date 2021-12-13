using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicConRegistration
{   
    public record Participant(string FirstName, string LastName, string Email, string FavoriteSuperhero, string FavoriteQuote);
}
