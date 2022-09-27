using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber == 1234567 && gamer.FirstName == "Ilkin" && gamer.LastName == "Shahaliyev" && gamer.BirthYear == 2002)
            {
                return true;
            }

            return false;
        }
    }
}
