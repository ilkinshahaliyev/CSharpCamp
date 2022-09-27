namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new(new UserValidationManager());

            Gamer ilkin = new()
            {
                Id = 1,
                FirstName = "Ilkin",
                LastName = "Shahaliyev",
                IdentityNumber = 1234567,
                BirthYear = 2002
            };

            Gamer ibrahim = new()
            {
                Id = 2,
                FirstName = "Ibrahim",
                LastName = "Ibrahimli",
                IdentityNumber = 12345,
                BirthYear = 1997
            };

            gamerManager.Add(ibrahim);

            Console.WriteLine("-----------------------------------");

            gamerManager.Add(ilkin);
            gamerManager.Update(ilkin);
            gamerManager.Delete(ilkin);
        }
    }
}
