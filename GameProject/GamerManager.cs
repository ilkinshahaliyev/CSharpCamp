using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine($"{gamer.FirstName} registered to database successfully.");
            }
            else
            {
                Console.WriteLine("Validation is unsuccessfull, register is unsuccessfull.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName}'s information updated successfully.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} deleted from database successfully.");
        }
    }
}
